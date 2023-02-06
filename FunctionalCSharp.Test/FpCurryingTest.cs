using System.Reflection;

namespace FunctionalCSharp.Test;

[TestFixture]
internal class FpCurryingTest : FpTestBase
{

    #region Tests

    private static object[] actionParameters = new object[0];
    private static object[] funcParameters = new object[0];
    private static object funcResult = new object();

    [Test]
    public void Curry_ActionDelegate_ParametersAreValid()
    {
        var curryMethods = GetMethods(typeof(Fp), nameof(Fp.Curry), BindingFlags.Static | BindingFlags.Public, m => !m.ReturnType.Name.Contains("Func"))
            .MakeGenericMethodIfPossible();
        var actionMethods = GetMethods<FpCurryingTest>(nameof(FpCurryingTest.ActionMethod));
        Assert.Multiple(() =>
        {
            foreach (var curryMethod in curryMethods)
            {
                var actionType = curryMethod.GetParameters().First().ParameterType;
                var @delegate = actionMethods.CreateDelegateOfType(actionType, this);

                FpCurryingTest.actionParameters = GenerateParams(actionType.GenericTypeArguments.Length);
                int returnTypeArgsCount = curryMethod.ReturnType.GenericTypeArguments.Length;

                var actionResult = curryMethod.Invoke(
                    null,
                    BuildParameters(@delegate, FpCurryingTest.actionParameters.SkipLast(returnTypeArgsCount))) as Delegate;

                if (returnTypeArgsCount == 0)
                {
                    actionResult!.DynamicInvoke();
                }
                else
                {
                    actionResult!.DynamicInvoke(FpCurryingTest.actionParameters
                        .Skip(FpCurryingTest.actionParameters.Length - returnTypeArgsCount).ToArray());
                }
            }
        });
    }

    [Test]
    public void Curry_FuncDelegate_ParametersAndReturnValueAreValid()
    {
        var curryMethods = GetMethods(typeof(Fp), nameof(Fp.Curry), BindingFlags.Static | BindingFlags.Public, m => !m.ReturnType.Name.Contains("Action"))
            .MakeGenericMethodIfPossible();
        var funcMethods = GetMethods<FpCurryingTest>(nameof(FpCurryingTest.FuncMethod));
        Assert.Multiple(() =>
        {
            foreach (var curryMethod in curryMethods)
            {
                var funcType = curryMethod.GetParameters().First().ParameterType;
                var @delegate = funcMethods.CreateDelegateOfType(funcType, this);

                FpCurryingTest.funcParameters = GenerateParams(funcType.GenericTypeArguments.Length - 1);
                int returnTypeArgsCount = curryMethod.ReturnType.GenericTypeArguments.Length - 1;

                var funcResult = curryMethod.Invoke(
                    null,
                    BuildParameters(@delegate, FpCurryingTest.funcParameters.SkipLast(returnTypeArgsCount))) as Delegate;

                object? result;
                if (returnTypeArgsCount == 0)
                {
                    result = funcResult!.DynamicInvoke();
                }
                else
                {
                    result = funcResult!.DynamicInvoke(FpCurryingTest.funcParameters
                        .Skip(FpCurryingTest.funcParameters.Length - returnTypeArgsCount).ToArray());
                }

                Assert.That(result, Is.SameAs(FpCurryingTest.funcResult));
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
                Assert.That(parameters[i], Is.SameAs(FpCurryingTest.actionParameters[i]));
            }
        });
    }

    protected override R AssertFuncMethod<R>(params object?[] parameters)
    {
        Assert.Multiple(() =>
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                Assert.That(parameters[i], Is.SameAs(FpCurryingTest.funcParameters[i]));
            }
        });

        return (R)FpCurryingTest.funcResult;
    }

    #endregion

}
