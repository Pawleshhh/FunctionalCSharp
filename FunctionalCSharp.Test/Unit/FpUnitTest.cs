using System.Reflection;

namespace FunctionalCSharp.Test;

[TestFixture]
internal class FpUnitTest
{

    [Test]
    public void Void_Passes()
        => new Unit().Void();

    private static object[] parameters = new object[0];

    [Test]
    public void Create_AllOverloadedCreateMethods_ArgumentsPassedCorrectlyAndReturnsUnit()
    {
        var actionMethods = GetActionMethods();
        var createMethods = GetCreateMethods().Select(x => x.IsGenericMethod
            ? x.MakeGenericMethod(GetObjectTypes(x.GetGenericArguments().Length))
            : x);
        foreach (var createMethod in createMethods)
        {
            var genericParamsLength = createMethod.GetGenericArguments().Length;
            FpUnitTest.parameters = Enumerable.Range(0, genericParamsLength).Select(x => new object()).ToArray();
            var createMethodParams = createMethod.GetParameters();
            var actionType = createMethodParams.Single().ParameterType;
            var actionMethod = actionMethods.Where(x => x.GetGenericArguments().Length == genericParamsLength).Single();
            var genericMethod = actionMethod.IsGenericMethodDefinition
                ? actionMethod.MakeGenericMethod(GetObjectTypes(genericParamsLength))
                : actionMethod;
            var @delegate = genericMethod.CreateDelegate(actionType);
            var func = createMethod.Invoke(null, new[] { @delegate }) as Delegate;
            var result = func!.DynamicInvoke(FpUnitTest.parameters);

            Assert.That(result as Unit, Is.SameAs(Fp.UnitValue), $"Create({genericParamsLength} generic params)");
        }

        Type[] GetObjectTypes(int length)
            => Enumerable.Range(0, length).Select(x => new object()).Select(x => x.GetType()).ToArray();
    }

    [Test]
    public void Unit_AllOverloadedUnitExtensionMethods_ArgumentsPassedCorrectlyAndReturnsUnit()
    {
        var actionMethods = GetActionMethods();
        var unitMethods = GetUnitMethods().Select(x => x.IsGenericMethod
            ? x.MakeGenericMethod(GetObjectTypes(x.GetGenericArguments().Length))
            : x);
        foreach (var unitMethod in unitMethods)
        {
            var genericParamsLength = unitMethod.GetGenericArguments().Length;
            FpUnitTest.parameters = Enumerable.Range(0, genericParamsLength).Select(x => new object()).ToArray();
            var unitMethodParams = unitMethod.GetParameters();
            var actionType = unitMethodParams.First().ParameterType;
            var actionMethod = actionMethods.Where(x => x.GetGenericArguments().Length == genericParamsLength).Single();
            var genericMethod = actionMethod.IsGenericMethodDefinition
                ? actionMethod.MakeGenericMethod(GetObjectTypes(genericParamsLength))
                : actionMethod;
            var @delegate = genericMethod.CreateDelegate(actionType);
            var unitParams = new List<object>() { @delegate };
            unitParams.AddRange(FpUnitTest.parameters);
            var result = unitMethod.Invoke(null, unitParams.ToArray()) as Unit;

            Assert.That(result, Is.SameAs(Fp.UnitValue), $"Create({genericParamsLength} generic params)");
        }

        Type[] GetObjectTypes(int length)
            => Enumerable.Range(0, length).Select(x => new object()).Select(x => x.GetType()).ToArray();
    }

    private IEnumerable<MethodInfo> GetCreateMethods()
        => typeof(Unit)
        .GetMethods(BindingFlags.Static | BindingFlags.Public)
        .Where(x => x.Name == nameof(Unit.Create));

    private IEnumerable<MethodInfo> GetUnitMethods()
        => typeof(Fp)
        .GetMethods(BindingFlags.Static | BindingFlags.Public)
        .Where(x => x.Name == nameof(Fp.Unit));

    private IEnumerable<MethodInfo> GetActionMethods()
        => typeof(FpUnitTest)
        .GetMethods(BindingFlags.Static | BindingFlags.Public)
        .Where(x => x.Name == nameof(FpUnitTest.ActionMethod));

    private static void AssertCreateParameters(params object?[] parameters)
        => Assert.Multiple(() =>
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                var p = parameters[i];
                Assert.That(p, Is.SameAs(FpUnitTest.parameters[i]));
            }
        });

    #region Methods to make delegates from

    public static void ActionMethod() => AssertCreateParameters();
    public static void ActionMethod<T1>(T1 t1) => AssertCreateParameters(t1);
    public static void ActionMethod<T1, T2>(T1 t1, T2 t2) => AssertCreateParameters(t1, t2);
    public static void ActionMethod<T1, T2, T3>(T1 t1, T2 t2, T3 t3) => AssertCreateParameters(t1, t2, t3);
    public static void ActionMethod<T1, T2, T3, T4>(T1 t1, T2 t2, T3 t3, T4 t4) => AssertCreateParameters(t1, t2, t3, t4);
    public static void ActionMethod<T1, T2, T3, T4, T5>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => AssertCreateParameters(t1, t2, t3, t4, t5);
    public static void ActionMethod<T1, T2, T3, T4, T5, T6>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => AssertCreateParameters(t1, t2, t3, t4, t5, t6);
    public static void ActionMethod<T1, T2, T3, T4, T5, T6, T7>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => AssertCreateParameters(t1, t2, t3, t4, t5, t6, t7);
    public static void ActionMethod<T1, T2, T3, T4, T5, T6, T7, T8>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => AssertCreateParameters(t1, t2, t3, t4, t5, t6, t7, t8);
    public static void ActionMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) => AssertCreateParameters(t1, t2, t3, t4, t5, t6, t7, t8, t9);
    public static void ActionMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) => AssertCreateParameters(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
    public static void ActionMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) => AssertCreateParameters(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
    public static void ActionMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) => AssertCreateParameters(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
    public static void ActionMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) => AssertCreateParameters(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
    public static void ActionMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) => AssertCreateParameters(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
    public static void ActionMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) => AssertCreateParameters(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
    public static void ActionMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16) => AssertCreateParameters(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);

    #endregion

}
