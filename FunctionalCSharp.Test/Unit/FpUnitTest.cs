using System.Reflection;

namespace FunctionalCSharp.Test;

[TestFixture]
internal class FpUnitTest : FpTestBase
{

    private static object[] parameters = new object[0];

    [TestCase(false)]
    [TestCase(true)]
    public void Create_AllOverloadedCreateMethods_ArgumentsPassedCorrectlyAndReturnsUnit(bool isAsync)
    {
        var actionMethods = GetMethods<FpUnitTest>(nameof(FpUnitTest.ActionMethod), BindingFlags.Instance | BindingFlags.Public);
        var createMethods = GetMethods<Unit>(
            isAsync ? nameof(Unit.CreateAsync) : nameof(Unit.Create),
            BindingFlags.Static | BindingFlags.Public).MakeGenericMethodIfPossible();
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

                Assert.That(GetResult(isAsync, result) as Unit, Is.SameAs(Fp.UnitValue), $"Unit.Create({genericParamsLength} generic params) did not return expected Unit instance");
            }
        });
    }

    [TestCase(false)]
    [TestCase(true)]
    public void Unit_AllOverloadedUnitExtensionMethods_ArgumentsPassedCorrectlyAndReturnsUnit(bool isAsync)
    {
        var actionMethods = GetMethods<FpUnitTest>(nameof(FpUnitTest.ActionMethod), BindingFlags.Instance | BindingFlags.Public);
        var unitMethods = GetMethods(
            typeof(Fp), 
            isAsync ? nameof(Fp.UnitAsync) : nameof(Fp.Unit), 
            BindingFlags.Static | BindingFlags.Public).MakeGenericMethodIfPossible();
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
                var resultObject = unitMethod.Invoke(null, unitParams.ToArray());
                object? result = isAsync
                    ? resultObject as Task<Unit>
                    : resultObject as Unit; //cast just to make sure type is correct (otherwise 'as' returns null obviously)

                Assert.That(GetResult(isAsync, result), Is.SameAs(Fp.UnitValue), $"Fp.Unit({genericParamsLength} generic params) did not return expected Unit instance");
            }
        });
    }

    #region FpUnitTest

    protected object? GetResult(bool isAsync, object? result)
        => isAsync ? (result as Task<Unit>)!.Result : result;

    #endregion

    #region FpTestBase

    protected override void AssertActionMethod(params object?[] parameters)
    {
        AssertActionParams(FpUnitTest.parameters, parameters);
    }

    #endregion


}
