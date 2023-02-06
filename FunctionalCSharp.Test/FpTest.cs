namespace FunctionalCSharp.Test;

[TestFixture]
internal class FpTest
{

    [Test]
    public void AsFunc_PassValue_ResultOfFuncIsThePassedValue()
    {
        // ARRANGE
        object value = new object();

        // ACT
        var result = Fp.AsFunc(value);

        // ASSERT
        Assert.That(result(), Is.SameAs(value));
    }

}
