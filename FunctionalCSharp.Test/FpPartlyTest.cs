using System.Reflection;

namespace FunctionalCSharp.Test;

[TestFixture]
internal class FpPartlyTest : FpTestBase
{

    #region Tests

    private static object[] actionParameters = new object[0];
    private static object[] funcParameters = new object[0];
    private static object funcResult = new object();

    [Test]
    public void Partly_ActionDelegate_ParametersAreValid()
    {
        var partlyMethods = GetMethods(typeof(Fp), nameof(Fp.Partly), BindingFlags.Static | BindingFlags.Public, m => !m.ReturnType.Name.Contains("Func"))
            .MakeGenericMethodIfPossible();
        var actionMethods = GetMethods<FpPartlyTest>(nameof(FpPartlyTest.ActionMethod));
        Assert.Multiple(() =>
        {
            foreach (var partlyMethod in partlyMethods)
            {
                var actionType = partlyMethod.GetParameters().First().ParameterType;
                var @delegate = actionMethods.CreateDelegateOfType(actionType, this);

                FpPartlyTest.actionParameters = GenerateParams(actionType.GenericTypeArguments.Length);
                int returnTypeArgsCount = partlyMethod.ReturnType.GenericTypeArguments.Length;

                var actionResult = partlyMethod.Invoke(
                    null,
                    BuildParameters(@delegate, FpPartlyTest.actionParameters.SkipLast(returnTypeArgsCount))) as Delegate;

                if (returnTypeArgsCount == 0)
                {
                    actionResult!.DynamicInvoke();
                }
                else
                {
                    actionResult!.DynamicInvoke(FpPartlyTest.actionParameters
                        .Skip(FpPartlyTest.actionParameters.Length - returnTypeArgsCount).ToArray());
                }
            }
        });
    }

    [Test]
    public void Partly_FuncDelegate_ParametersAndReturnValueAreValid()
    {
        var partlyMethods = GetMethods(typeof(Fp), nameof(Fp.Partly), BindingFlags.Static | BindingFlags.Public, m => !m.ReturnType.Name.Contains("Action"))
            .MakeGenericMethodIfPossible();
        var funcMethods = GetMethods<FpPartlyTest>(nameof(FpPartlyTest.FuncMethod));
        Assert.Multiple(() =>
        {
            foreach (var partlyMethod in partlyMethods)
            {
                var funcType = partlyMethod.GetParameters().First().ParameterType;
                var @delegate = funcMethods.CreateDelegateOfType(funcType, this);

                FpPartlyTest.funcParameters = GenerateParams(funcType.GenericTypeArguments.Length - 1);
                int returnTypeArgsCount = partlyMethod.ReturnType.GenericTypeArguments.Length - 1;

                var funcResult = partlyMethod.Invoke(
                    null,
                    BuildParameters(@delegate, FpPartlyTest.funcParameters.SkipLast(returnTypeArgsCount))) as Delegate;

                object? result;
                if (returnTypeArgsCount == 0)
                {
                    result = funcResult!.DynamicInvoke();
                }
                else
                {
                    result = funcResult!.DynamicInvoke(FpPartlyTest.funcParameters
                        .Skip(FpPartlyTest.funcParameters.Length - returnTypeArgsCount).ToArray());
                }

                Assert.That(result, Is.SameAs(FpPartlyTest.funcResult));
            }
        });
    }

    #endregion

    #region FpTestBase

    protected override void AssertActionMethod(params object?[] parameters)
    {
        Assert.Multiple(() =>
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                Assert.That(parameters[i], Is.SameAs(FpPartlyTest.actionParameters[i]));
            }
        });
    }

    protected override R AssertFuncMethod<R>(params object?[] parameters)
    {
        Assert.Multiple(() =>
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                Assert.That(parameters[i], Is.SameAs(FpPartlyTest.funcParameters[i]));
            }
        });

        return (R)FpPartlyTest.funcResult;
    }

    #endregion

}
