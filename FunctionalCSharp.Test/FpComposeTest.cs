using System.Reflection;

namespace FunctionalCSharp.Test;

internal class FpComposeTest
{

    #region Test

    private static object[] func1Parameters = new object[0];
    private static object[] func2Parameters = new object[0];
    private static readonly object resultObj = new object();

    [Test]
    public void Compose_AllOverloadedComposeMethods_ArgumentsPassedAndComposedCorrectly()
    {
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

    private IEnumerable<MethodInfo> GetComposeMethods()
        => typeof(Fp)
        .GetMethods(BindingFlags.Static | BindingFlags.Public)
        .Where(x => x.Name == nameof(Fp.Compose));

    private IEnumerable<MethodInfo> GetFuncMethods1()
        => typeof(FpComposeTest)
        .GetMethods(BindingFlags.Static | BindingFlags.Public)
        .Where(x => x.Name == nameof(FpComposeTest.FuncMethod1));

    private IEnumerable<MethodInfo> GetFuncMethods2()
        => typeof(FpComposeTest)
        .GetMethods(BindingFlags.Static | BindingFlags.Public)
        .Where(x => x.Name == nameof(FpComposeTest.FuncMethod2));

    private static R AssertCreateParameters1<R>(params object?[] parameters)
    {
        Assert.Multiple(() =>
        {
            for(int i = 0; i < parameters.Length; i++)
            {
                Assert.That(parameters[i], Is.SameAs(FpComposeTest.func1Parameters[i]));
            }
        });

        return (R)FpComposeTest.func2Parameters.Last();
    }

    private static R AssertCreateParameters2<R>(params object?[] parameters)
    {
        Assert.Multiple(() =>
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                Assert.That(parameters[i], Is.SameAs(FpComposeTest.func2Parameters[i]));
            }
        });

        return (R)FpComposeTest.resultObj;
    }

    #endregion

    #region Methods to make delegates from

    public static R FuncMethod1<T1, R>(T1 t1) => AssertCreateParameters1<R>(t1);
    public static R FuncMethod1<T1, T2, R>(
        T1 t1, T2 t2)
        => AssertCreateParameters1<R>(t1, t2);
    public static R FuncMethod1<T1, T2, T3, R>(
        T1 t1, T2 t2, T3 t3) 
        => AssertCreateParameters1<R>(t1, t2, t3);
    public static R FuncMethod1<T1, T2, T3, T4, R>(
        T1 t1, T2 t2, T3 t3, T4 t4)
        => AssertCreateParameters1<R>(t1, t2, t3, t4);
    public static R FuncMethod1<T1, T2, T3, T4, T5, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) 
        => AssertCreateParameters1<R>(t1, t2, t3, t4, t5);
    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) 
        => AssertCreateParameters1<R>(t1, t2, t3, t4, t5, t6);
    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
        => AssertCreateParameters1<R>(t1, t2, t3, t4, t5, t6, t7);
    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
        => AssertCreateParameters1<R>(t1, t2, t3, t4, t5, t6, t7, t8);
    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) 
        => AssertCreateParameters1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9);
    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) 
        => AssertCreateParameters1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) 
        => AssertCreateParameters1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
        => AssertCreateParameters1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
        => AssertCreateParameters1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) 
        => AssertCreateParameters1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
        => AssertCreateParameters1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16) 
        => AssertCreateParameters1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);

    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18)
        => AssertCreateParameters1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18);

    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20)
        => AssertCreateParameters1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20);

    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22)
        => AssertCreateParameters1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22);

    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24)
        => AssertCreateParameters1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24);

    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26)
        => AssertCreateParameters1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26);

    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28)
        => AssertCreateParameters1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28);

    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30) 
        => AssertCreateParameters1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30);

    public static R FuncMethod1<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32)
        => AssertCreateParameters1<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32);

    public static R FuncMethod2<T1, R>(T1 t1) => AssertCreateParameters2<R>(t1);
    public static R FuncMethod2<T1, T2, R>(
        T1 t1, T2 t2)
        => AssertCreateParameters2<R>(t1, t2);
    public static R FuncMethod2<T1, T2, T3, R>(
        T1 t1, T2 t2, T3 t3)
        => AssertCreateParameters2<R>(t1, t2, t3);
    public static R FuncMethod2<T1, T2, T3, T4, R>(
        T1 t1, T2 t2, T3 t3, T4 t4)
        => AssertCreateParameters2<R>(t1, t2, t3, t4);
    public static R FuncMethod2<T1, T2, T3, T4, T5, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        => AssertCreateParameters2<R>(t1, t2, t3, t4, t5);
    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
        => AssertCreateParameters2<R>(t1, t2, t3, t4, t5, t6);
    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
        => AssertCreateParameters2<R>(t1, t2, t3, t4, t5, t6, t7);
    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
        => AssertCreateParameters2<R>(t1, t2, t3, t4, t5, t6, t7, t8);
    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
        => AssertCreateParameters2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9);
    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
        => AssertCreateParameters2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
        => AssertCreateParameters2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
        => AssertCreateParameters2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
        => AssertCreateParameters2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
        => AssertCreateParameters2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
        => AssertCreateParameters2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16)
        => AssertCreateParameters2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);

    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18)
        => AssertCreateParameters2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18);

    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20)
        => AssertCreateParameters2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20);

    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22)
        => AssertCreateParameters2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22);

    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24)
        => AssertCreateParameters2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24);

    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26)
        => AssertCreateParameters2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26);

    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28)
        => AssertCreateParameters2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28);

    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30)
        => AssertCreateParameters2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30);

    public static R FuncMethod2<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32)
        => AssertCreateParameters2<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32);

    #endregion

}
