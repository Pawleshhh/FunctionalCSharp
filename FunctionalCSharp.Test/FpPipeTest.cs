using System.Reflection;

namespace FunctionalCSharp.Test;

[TestFixture]
internal class FpPipeTest : FpTestBase
{

    #region Test

    private static object[] actionIntoParameters = new object[0];
    private static object actionIntoLastArg = new object();
    
    private static object[] funcParameters = new object[0];
    private static object funcIntoArg = new object();
    private static object funcResult = new object();

    [Test]
    public void Into_ActionDelegate_ParametersAreValid()
    {
        var intoMethods = GetMethods(
            typeof(Fp), nameof(Fp.Into), 
            BindingFlags.Static | BindingFlags.Public, 
            m => !m.GetParameters().ElementAt(1).ParameterType.Name!.Contains("Func")).MakeGenericMethodIfPossible();
        var actionMethods = GetMethods<FpPipeTest>(nameof(FpPipeTest.ActionMethod));
        Assert.Multiple(() =>
        {
            foreach(var intoMethod in intoMethods)
            {
                var actionType = intoMethod.GetParameters().ElementAt(1).ParameterType;
                var @delegate = actionMethods.CreateDelegateOfType(actionType, this);
                FpPipeTest.actionIntoParameters = GenerateParams(actionType.GenericTypeArguments.Length);
                FpPipeTest.actionIntoLastArg = FpPipeTest.actionIntoParameters.Last();

                intoMethod.Invoke(null, BuildParameters(FpPipeTest.actionIntoLastArg, @delegate, FpPipeTest.actionIntoParameters.SkipLast(1)));
            }
        });
    }

    [Test]
    public void Into_FuncDelegate_ParametersAndReturnValueAreValid()
    {
        var intoMethods = GetMethods(
            typeof(Fp), 
            nameof(Fp.Into), 
            BindingFlags.Static | BindingFlags.Public,
            m => !m.GetParameters().ElementAt(1).ParameterType.Name!.Contains("Action")).MakeGenericMethodIfPossible();
        var funcMethods = GetMethods<FpPipeTest>(nameof(FpPipeTest.FuncMethod));
        Assert.Multiple(() =>
        {
            foreach (var intoMethod in intoMethods)
            {
                var funcType = intoMethod.GetParameters().ElementAt(1).ParameterType;
                var @delegate = funcMethods.CreateDelegateOfType(funcType, this);
                FpPipeTest.funcParameters = GenerateParams(funcType.GenericTypeArguments.Length - 1);
                FpPipeTest.funcIntoArg = FpPipeTest.funcParameters.Last();

                var result = intoMethod.Invoke(null, BuildParameters(FpPipeTest.funcIntoArg, @delegate, FpPipeTest.funcParameters.SkipLast(1)));

                Assert.That(result, Is.SameAs(FpPipeTest.funcResult));
            }
        });
    }

    [Test]
    public void Into1_FuncDelegate_ParametersAndReturnValueAreValid()
    {
        var intoMethods = GetMethods(
            typeof(Fp),
            nameof(Fp.Into1),
            BindingFlags.Static | BindingFlags.Public,
            m => !m.GetParameters().ElementAt(1).ParameterType.Name!.Contains("Action")).MakeGenericMethodIfPossible();
        var funcMethods = GetMethods<FpPipeTest>(nameof(FpPipeTest.FuncMethod));
        Assert.Multiple(() =>
        {
            foreach (var intoMethod in intoMethods)
            {
                var funcType = intoMethod.GetParameters().ElementAt(1).ParameterType;
                var @delegate = funcMethods.CreateDelegateOfType(funcType, this);
                FpPipeTest.funcParameters = GenerateParams(funcType.GenericTypeArguments.Length - 1);
                FpPipeTest.funcIntoArg = FpPipeTest.funcParameters.First();

                var result = intoMethod.Invoke(null, BuildParameters(FpPipeTest.funcIntoArg, @delegate, FpPipeTest.funcParameters.Skip(1)));

                Assert.That(result, Is.SameAs(FpPipeTest.funcResult));
            }
        });
    }

    #endregion

    #region TestBase

    protected override void AssertActionMethod(params object?[] parameters)
    {
        Assert.Multiple(() =>
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                Assert.That(parameters[i], Is.SameAs(FpPipeTest.actionIntoParameters[i]));
            }
        });
    }

    protected override R AssertFuncMethod<R>(params object?[] parameters)
    {
        Assert.Multiple(() =>
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                Assert.That(parameters[i], Is.SameAs(FpPipeTest.funcParameters[i]));
            }
        });

        return (R)FpPipeTest.funcResult;
    }

    #endregion

}
