using System.Reflection;

namespace FunctionalCSharp.Test;

[TestFixture]
internal class FpComposeTest : FpTestBase
{

    #region Test

    private static object[] func1Parameters = new object[0];
    private static object[] func2Parameters = new object[0];
    private static readonly object resultObj = new object();

    private static int funcId = 0;

    private static bool composeBackTest = false;

    [Test]
    public void Compose_AllOverloadedComposeMethods_ArgumentsPassedAndComposedCorrectly()
    {
        FpComposeTest.composeBackTest = false;
        var composeMethods = GetMethods(typeof(Fp), nameof(Fp.Compose), BindingFlags.Static | BindingFlags.Public)
            .MakeGenericMethodIfPossible();
        var funcMethods = GetMethods<FpComposeTest>(nameof(FpComposeTest.FuncMethod));
        Assert.Multiple(() =>
        {
            foreach (var composeMethod in composeMethods)
            {
                FpComposeTest.funcId = 1;

                var funcType = composeMethod.GetParameters().First().ParameterType;
                var funcDelegate1 = funcMethods.CreateDelegateOfType(funcType, this);
                var funcDelegate2 = (Delegate)funcDelegate1.Clone();

                FpComposeTest.func1Parameters = GenerateParams(funcType.GetGenericArguments().Length - 1);
                FpComposeTest.func2Parameters = GenerateParams(funcType.GetGenericArguments().Length - 1);

                var allParams = BuildComposeParameters(funcDelegate1, funcDelegate2);
                var resultFunc = composeMethod.Invoke(null, allParams) as Func<object, object>;

                Assert.That(resultFunc!(FpComposeTest.func1Parameters.Last()), Is.SameAs(FpComposeTest.resultObj));
            }
        });
    }

    [Test]
    public void ComposeBack_AllOverloadedComposeBackMethods_ArgumentsPassedAndComposedCorrectly()
    {
        FpComposeTest.composeBackTest = true;
        var composeMethods = GetMethods(typeof(Fp), nameof(Fp.ComposeBack), BindingFlags.Static | BindingFlags.Public)
            .MakeGenericMethodIfPossible();
        var funcMethods = GetMethods<FpComposeTest>(nameof(FpComposeTest.FuncMethod));
        Assert.Multiple(() =>
        {
            foreach (var composeMethod in composeMethods)
            {
                FpComposeTest.funcId = 2;

                var funcType = composeMethod.GetParameters().First().ParameterType;
                var funcDelegate1 = funcMethods.CreateDelegateOfType(funcType, this);
                var funcDelegate2 = (Delegate)funcDelegate1.Clone();

                FpComposeTest.func1Parameters = GenerateParams(funcType.GetGenericArguments().Length - 1);
                FpComposeTest.func2Parameters = GenerateParams(funcType.GetGenericArguments().Length - 1);

                var allParams = BuildComposeParameters(funcDelegate1, funcDelegate2);
                var resultFunc = composeMethod.Invoke(null, allParams) as Func<object, object>;

                Assert.That(resultFunc!(FpComposeTest.func2Parameters.Last()), Is.SameAs(FpComposeTest.resultObj));
            }
        });
    }

    private static object[] BuildComposeParameters(Delegate funcDelegate1, Delegate funcDelegate2)
    {
        return BuildParameters(
            funcDelegate1,
            FpComposeTest.func1Parameters.SkipLast(1),
            funcDelegate2,
            FpComposeTest.func2Parameters.SkipLast(1));
    }

    private static R AssertComposeParameters<R>(object result, object[] expected, object?[] parameters)
    {
        Assert.Multiple(() =>
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                Assert.That(parameters[i], Is.SameAs(expected[i]));
            }
        });

        return (R)result;
    }

    private static R AssertComposeParametersFunc1<R>(params object?[] parameters)
    {
        if (FpComposeTest.composeBackTest)
        {
            return AssertComposeParameters<R>(FpComposeTest.resultObj, FpComposeTest.func1Parameters, parameters);
        }
        else
        {
            return AssertComposeParameters<R>(FpComposeTest.func2Parameters.Last(), FpComposeTest.func1Parameters, parameters);
        }
    }

    private static R AssertComposeParametersFunc2<R>(params object?[] parameters)
    {
        if (FpComposeTest.composeBackTest)
        {
            return AssertComposeParameters<R>(FpComposeTest.func1Parameters.Last(), FpComposeTest.func2Parameters, parameters);
        }
        else
        {
            return AssertComposeParameters<R>(FpComposeTest.resultObj, FpComposeTest.func2Parameters, parameters);
        }
    }

    #endregion

    #region FpTestBase

    protected override R AssertFuncMethod<R>(params object?[] parameters)
    {
        if (FpComposeTest.composeBackTest)
        {
            if (FpComposeTest.funcId == 2)
            {
                FpComposeTest.funcId--;
                return AssertComposeParametersFunc2<R>(parameters);
            }

            return AssertComposeParametersFunc1<R>(parameters);
        }

        if (FpComposeTest.funcId == 1)
        {
            FpComposeTest.funcId++;
            return AssertComposeParametersFunc1<R>(parameters);
        }

        return AssertComposeParametersFunc2<R>(parameters);
    }

    #endregion

}
