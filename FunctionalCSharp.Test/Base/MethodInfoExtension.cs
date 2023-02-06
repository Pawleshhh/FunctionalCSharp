using System.Reflection;

namespace FunctionalCSharp.Test;

static class MethodInfoExtension
{

    public static int GenericArgCount(this MethodInfo method)
        => method.GetGenericArguments().Length;

    public static IEnumerable<MethodInfo> MakeGenericMethodIfPossible(this IEnumerable<MethodInfo> methodInfos)
        => methodInfos.Select(x => x.IsGenericMethod
        ? x.MakeGenericMethod(x.GenericArgCount())
        : x);

    public static MethodInfo MakeGenericMethod(this MethodInfo methodInfo, int count)
        => methodInfo.MakeGenericMethod(FpTestBase.GetObjectTypes(count));

    public static Delegate CreateDelegateOfType(this IEnumerable<MethodInfo> methodInfos, Type methodType, object? target = null)
    {
        var properMethod = methodInfos.Where(x => x.GenericArgCount() == methodType.GenericTypeArguments.Length).Single();

        return properMethod.IsGenericMethodDefinition
            ? properMethod.MakeGenericMethod(methodType.GetGenericArguments().Length).CreateDelegate(methodType, target)
            : properMethod.CreateDelegate(methodType, target);
    }

}