using System.Diagnostics;
using System.Reflection;

namespace FunctionalCSharp.Test;

internal abstract partial class FpTestBase
{

    #region Static helpers

    public static void AssertActionParams(object[] expected, object?[] parameters)
    {
        Assert.Multiple(() =>
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                Assert.That(parameters[i], Is.SameAs(expected[i]), $"Action {GetCallingMethod()?.Name} failed at {i} parameter");
            }
        });
    }

    public static R AssertFuncParams<R>(object result, object[] expected, object?[] parameters)
    {
        Assert.Multiple(() =>
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                Assert.That(parameters[i], Is.SameAs(expected[i]), $"Func {GetCallingMethod()?.Name} failed at {i} parameter");
            }
        });

        return (R)result;
    }

    public static Type[] GetObjectTypes(int length)
        => GenerateParams(length).Select(x => x.GetType()).ToArray();

    public static object[] GenerateParams(int length)
        => Enumerable.Range(0, length).Select(x => new object()).ToArray();

    public static IEnumerable<MethodInfo> GetMethods<T>(string name, BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.Public)
        => typeof(T)
        .GetMethods(bindingAttr)
        .Where(x => x.Name == name);

    public static IEnumerable<MethodInfo> GetMethods(Type type, string name, BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.Public)
        => type
        .GetMethods(bindingAttr)
        .Where(x => x.Name == name);

    public static object[] BuildParameters(params object[] parameters)
    {
        IEnumerable<object> result = Enumerable.Empty<object>();

        foreach (var p in parameters)
        {
            if (p is IEnumerable<object> en)
            {
                result = result.Concat(en);
            }
            else
            {
                result = result.Append(p);
            }
        }

        return result.ToArray();
    }

    private static MethodBase? GetCallingMethod()
        => new StackTrace()?.GetFrame(2)?.GetMethod();

    #endregion

    #region Abstract

    protected virtual void AssertActionMethod(params object?[] parameters) => Assert.Pass();
    protected virtual R AssertFuncMethod<R>(params object?[] parameters) { Assert.Pass(); return default; }

    #endregion

}