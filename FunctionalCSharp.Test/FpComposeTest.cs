using System.Reflection;

namespace FunctionalCSharp.Test;

internal class FpComposeTest
{

    #region Test

    private static object[] func1Parameters = new object[0];
    private static object[] func2Parameters = new object[0];
    private static readonly object resultObj = new object();

    private static bool composeBackTest = false;

    [Test]
    public void Compose_AllOverloadedComposeMethods_ArgumentsPassedAndComposedCorrectly()
    {
        FpComposeTest.composeBackTest = false;
        var composeMethods = GetComposeMethods()
            .Select(x => x.MakeGenericMethod(GetObjectTypes(x.GetGenericArguments().Length)));
        var funcMethods1 = GetFuncMethods1();
        var funcMethods2 = GetFuncMethods2();
        foreach (var composeMethod in composeMethods)
        {
            var allGenericParamsLength = composeMethod.GetGenericArguments().Length;
            var passedGenericParamsLength = allGenericParamsLength - 1;
            var composeMethodParams = composeMethod.GetParameters();
            var funcType = composeMethodParams[0].ParameterType;
            var funcMethod1 = funcMethods1.Where(x => x.GetGenericArguments().Length == funcType.GenericTypeArguments.Length).Single();
            var genericFunc1 = funcMethod1.MakeGenericMethod(GetObjectTypes(funcType.GetGenericArguments().Length));
            var funcMethod2 = funcMethods2.Where(x => x.GetGenericArguments().Length == funcType.GenericTypeArguments.Length).Single();
            var genericFunc2 = funcMethod2.MakeGenericMethod(GetObjectTypes(funcType.GetGenericArguments().Length));
            var func1Delegate = genericFunc1.CreateDelegate(funcType);
            var func2Delegate = genericFunc2.CreateDelegate(funcType);

            FpComposeTest.func1Parameters = GenerateParams(funcType.GetGenericArguments().Length - 1);
            FpComposeTest.func2Parameters = GenerateParams(funcType.GetGenericArguments().Length - 1);
            var allParams = new object[] { func1Delegate }.Concat(FpComposeTest.func1Parameters.SkipLast(1))
                .Concat(new object[] { func2Delegate }.Concat(FpComposeTest.func2Parameters.SkipLast(1))).ToArray();

            var resultFunc = composeMethod.Invoke(null, allParams) as Func<object, object>;

            Assert.That(resultFunc!(FpComposeTest.func1Parameters.Last()), Is.SameAs(FpComposeTest.resultObj));
        }

        Type[] GetObjectTypes(int length)
            => GenerateParams(length).Select(x => x.GetType()).ToArray();

        object[] GenerateParams(int length)
            => Enumerable.Range(0, length).Select(x => new object()).ToArray();
    }

    [Test]
    public void ComposeBack_AllOverloadedComposeBackMethods_ArgumentsPassedAndComposedCorrectly()
    {
        FpComposeTest.composeBackTest = true;
        var composeMethods = GetComposeBackMethods()
            .Select(x => x.MakeGenericMethod(GetObjectTypes(x.GetGenericArguments().Length)));
        var funcMethods1 = GetFuncMethods1();
        var funcMethods2 = GetFuncMethods2();
        foreach (var composeMethod in composeMethods)
        {
            var allGenericParamsLength = composeMethod.GetGenericArguments().Length;
            var passedGenericParamsLength = allGenericParamsLength - 1;
            var composeMethodParams = composeMethod.GetParameters();
            var funcType = composeMethodParams[0].ParameterType;
            var funcMethod1 = funcMethods1.Where(x => x.GetGenericArguments().Length == funcType.GenericTypeArguments.Length).Single();
            var genericFunc1 = funcMethod1.MakeGenericMethod(GetObjectTypes(funcType.GetGenericArguments().Length));
            var funcMethod2 = funcMethods2.Where(x => x.GetGenericArguments().Length == funcType.GenericTypeArguments.Length).Single();
            var genericFunc2 = funcMethod2.MakeGenericMethod(GetObjectTypes(funcType.GetGenericArguments().Length));
            var func1Delegate = genericFunc1.CreateDelegate(funcType);
            var func2Delegate = genericFunc2.CreateDelegate(funcType);

            FpComposeTest.func1Parameters = GenerateParams(funcType.GetGenericArguments().Length - 1);
            FpComposeTest.func2Parameters = GenerateParams(funcType.GetGenericArguments().Length - 1);
            var allParams = new object[] { func1Delegate }.Concat(FpComposeTest.func1Parameters.SkipLast(1))
                .Concat(new object[] { func2Delegate }.Concat(FpComposeTest.func2Parameters.SkipLast(1))).ToArray();

            var resultFunc = composeMethod.Invoke(null, allParams) as Func<object, object>;

            Assert.That(resultFunc!(FpComposeTest.func2Parameters.Last()), Is.SameAs(FpComposeTest.resultObj));
        }

        Type[] GetObjectTypes(int length)
            => GenerateParams(length).Select(x => x.GetType()).ToArray();

        object[] GenerateParams(int length)
            => Enumerable.Range(0, length).Select(x => new object()).ToArray();
    }

    private IEnumerable<MethodInfo> GetComposeMethods()
        => typeof(Fp)
        .GetMethods(BindingFlags.Static | BindingFlags.Public)
        .Where(x => x.Name == nameof(Fp.Compose));

    private IEnumerable<MethodInfo> GetComposeBackMethods()
        => typeof(Fp)
        .GetMethods(BindingFlags.Static | BindingFlags.Public)
        .Where(x => x.Name == nameof(Fp.ComposeBack));

    private IEnumerable<MethodInfo> GetFuncMethods1()
        => typeof(FpComposeTest)
        .GetMethods(BindingFlags.Static | BindingFlags.Public)
        .Where(x => x.Name == nameof(FpComposeTest.FuncMethod1));

    private IEnumerable<MethodInfo> GetFuncMethods2()
        => typeof(FpComposeTest)
        .GetMethods(BindingFlags.Static | BindingFlags.Public)
        .Where(x => x.Name == nameof(FpComposeTest.FuncMethod2));

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

    #region Methods to make delegates from

    public static R FuncMethod1<T1, R>(T1 t1) => AssertComposeParametersFunc1<R>(t1);
    public static R FuncMethod1<T1, T2, R>(
        T1 t1, T2 t2)
        => AssertComposeParametersFunc1<R>(t1, t2);
    public static R FuncMethod1<T1, T2, T3, R>(
        T1 t1, T2 t2, T3 t3) 
        => AssertComposeParametersFunc1<R>(t1, t2, t3);
    public static R FuncMethod1<T1, T2, T3, T4, R>(
        T1 t1, T2 t2, T3 t3, T4 t4)
        => AssertComposeParametersFunc1<R>(t1, t2, t3, t4);
    public static R FuncMethod1<T1, T2, T3, T4, T5, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) 
        => AssertComposeParametersFunc1<R>(t1, t2, t3, t4, t5);
    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) 
        => AssertComposeParametersFunc1<R>(t1, t2, t3, t4, t5, t6);
    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
        => AssertComposeParametersFunc1<R>(t1, t2, t3, t4, t5, t6, t7);
    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
        => AssertComposeParametersFunc1<R>(t1, t2, t3, t4, t5, t6, t7, t8);
    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) 
        => AssertComposeParametersFunc1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9);
    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) 
        => AssertComposeParametersFunc1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) 
        => AssertComposeParametersFunc1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
        => AssertComposeParametersFunc1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
        => AssertComposeParametersFunc1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) 
        => AssertComposeParametersFunc1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
        => AssertComposeParametersFunc1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16) 
        => AssertComposeParametersFunc1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);

    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18)
        => AssertComposeParametersFunc1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18);

    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20)
        => AssertComposeParametersFunc1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20);

    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22)
        => AssertComposeParametersFunc1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22);

    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24)
        => AssertComposeParametersFunc1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24);

    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26)
        => AssertComposeParametersFunc1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26);

    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28)
        => AssertComposeParametersFunc1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28);

    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30) 
        => AssertComposeParametersFunc1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30);

    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32)
        => AssertComposeParametersFunc1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32);

    public static R FuncMethod2<T1, R>(T1 t1) => AssertComposeParametersFunc2<R>(t1);
    public static R FuncMethod2<T1, T2, R>(
        T1 t1, T2 t2)
        => AssertComposeParametersFunc2<R>(t1, t2);
    public static R FuncMethod2<T1, T2, T3, R>(
        T1 t1, T2 t2, T3 t3)
        => AssertComposeParametersFunc2<R>(t1, t2, t3);
    public static R FuncMethod2<T1, T2, T3, T4, R>(
        T1 t1, T2 t2, T3 t3, T4 t4)
        => AssertComposeParametersFunc2<R>(t1, t2, t3, t4);
    public static R FuncMethod2<T1, T2, T3, T4, T5, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        => AssertComposeParametersFunc2<R>(t1, t2, t3, t4, t5);
    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
        => AssertComposeParametersFunc2<R>(t1, t2, t3, t4, t5, t6);
    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
        => AssertComposeParametersFunc2<R>(t1, t2, t3, t4, t5, t6, t7);
    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
        => AssertComposeParametersFunc2<R>(t1, t2, t3, t4, t5, t6, t7, t8);
    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
        => AssertComposeParametersFunc2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9);
    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
        => AssertComposeParametersFunc2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
        => AssertComposeParametersFunc2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
        => AssertComposeParametersFunc2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
        => AssertComposeParametersFunc2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
        => AssertComposeParametersFunc2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
        => AssertComposeParametersFunc2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16)
        => AssertComposeParametersFunc2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);

    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18)
        => AssertComposeParametersFunc2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18);

    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20)
        => AssertComposeParametersFunc2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20);

    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22)
        => AssertComposeParametersFunc2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22);

    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24)
        => AssertComposeParametersFunc2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24);

    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26)
        => AssertComposeParametersFunc2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26);

    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28)
        => AssertComposeParametersFunc2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28);

    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30)
        => AssertComposeParametersFunc2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30);

    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32)
        => AssertComposeParametersFunc2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32);

    #endregion

}
