using System.Reflection;

namespace FunctionalCSharp.Test;

[TestFixture]
internal class FpCurryingTest : FpTestBase
{

    #region Tests

    private static object[] actionParameters = new object[0];

    [Test]
    public void Curry_ActionDelegate_ParametersAreValid()
    {
        var curryMethods = GetMethods(typeof(Fp), nameof(Fp.Curry), BindingFlags.Static | BindingFlags.Public, m => !m.ReturnType.Name.Contains("Func"))
            .MakeGenericMethodIfPossible();
        var actionMethods = GetMethods<FpCurryingTest>(nameof(FpCurryingTest.ActionMethod));
        foreach (var curryMethod in curryMethods)
        {
            var actionType = curryMethod.GetParameters().First().ParameterType;
            var @delegate = actionMethods.CreateDelegateOfType(actionType, this);

            FpCurryingTest.actionParameters = GenerateParams(actionType.GenericTypeArguments.Length);
            int returnTypeArgsCount = curryMethod.ReturnType.GenericTypeArguments.Length;

            var result = curryMethod.Invoke(
                null, 
                BuildParameters(@delegate, FpCurryingTest.actionParameters.SkipLast(returnTypeArgsCount))) as Delegate;

            if (returnTypeArgsCount == 0)
            {
                result!.DynamicInvoke();
            }
            else
            {
                result!.DynamicInvoke(FpCurryingTest.actionParameters
                    .Skip(FpCurryingTest.actionParameters.Length - returnTypeArgsCount).ToArray());
            }
        }
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

    #endregion

}
