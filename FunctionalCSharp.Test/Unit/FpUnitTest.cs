using System.Reflection;

namespace FunctionalCSharp.Test;

[TestFixture]
internal class FpUnitTest : FpTestBase
{

    private static object[] parameters = new object[0];

    [Test]
    public void Void_Passes()
        => new Unit().Void();

    [Test]
    public void Create_AllOverloadedCreateMethods_ArgumentsPassedCorrectlyAndReturnsUnit()
    {
        var actionMethods = GetMethods<FpUnitTest>(nameof(FpUnitTest.ActionMethod), BindingFlags.Instance | BindingFlags.Public);
        var createMethods = GetMethods<Unit>(nameof(Unit.Create), BindingFlags.Static | BindingFlags.Public)
            .MakeGenericMethodIfPossible();
        Assert.Multiple(() =>
        {
            foreach (var createMethod in createMethods)
            {
                var genericParamsLength = createMethod.GenericArgCount();
                FpUnitTest.parameters = GenerateParams(genericParamsLength);
                var actionType = createMethod.GetParameters().Single().ParameterType;
                var @delegate = actionMethods.CreateDelegateOfType(actionType, this);
                var func = createMethod.Invoke(null, new[] { @delegate }) as Delegate;
                var result = func!.DynamicInvoke(FpUnitTest.parameters);

                Assert.That(result as Unit, Is.SameAs(Fp.UnitValue), $"Unit.Create({genericParamsLength} generic params) did not return expected Unit instance");
            }
        });
    }

    [Test]
    public void Unit_AllOverloadedUnitExtensionMethods_ArgumentsPassedCorrectlyAndReturnsUnit()
    {
        var actionMethods = GetMethods<FpUnitTest>(nameof(FpUnitTest.ActionMethod), BindingFlags.Instance | BindingFlags.Public);
        var unitMethods = GetMethods(typeof(Fp), nameof(Fp.Unit), BindingFlags.Static | BindingFlags.Public)
            .MakeGenericMethodIfPossible();
        Assert.Multiple(() =>
        {
            foreach (var unitMethod in unitMethods)
            {
                var genericParamsLength = unitMethod.GenericArgCount();
                FpUnitTest.parameters = GenerateParams(genericParamsLength);
                var actionType = unitMethod.GetParameters().First().ParameterType;
                var @delegate = actionMethods.CreateDelegateOfType(actionType, this);
                var unitParams = new List<object>() { @delegate };
                unitParams.AddRange(FpUnitTest.parameters);
                var result = unitMethod.Invoke(null, unitParams.ToArray()) as Unit;

                Assert.That(result, Is.SameAs(Fp.UnitValue), $"Fp.Unit({genericParamsLength} generic params) did not return expected Unit instance");
            }
        });
    }


    #region FpTestBase

    protected override void AssertActionMethod(params object?[] parameters)
    {
        AssertActionParams(FpUnitTest.parameters, parameters);
    }

    #endregion


}
