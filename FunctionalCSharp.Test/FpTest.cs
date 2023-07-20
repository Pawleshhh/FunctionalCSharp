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

    public class BaseClass { }
    public class DerivedClass : BaseClass { }

    [Test]
    public void As_ValidConversion_ShouldReturnConvertedValue()
    {
        // Arrange
        BaseClass baseObject = new DerivedClass();

        // Act
        var result = baseObject.As<DerivedClass>();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.InstanceOf<DerivedClass>());
            Assert.That(result, Is.SameAs(baseObject));
        });
    }

    [Test]
    public void As_InvalidConversion_ShouldReturnNull()
    {
        // Arrange
        BaseClass baseObject = new BaseClass();

        // Act
        var result = baseObject.As<DerivedClass>();

        // Assert
        Assert.That(result, Is.Null);
    }

    [Test]
    public void As_NullInput_ShouldReturnNull()
    {
        // Arrange
        BaseClass? baseObject = null;

        // Act
        var result = baseObject.As<DerivedClass>();

        // Assert
        Assert.That(result, Is.Null);
    }

    [Test]
    public void Cast_ValidConversion_ShouldReturnConvertedValue()
    {
        // Arrange
        BaseClass baseObject = new DerivedClass();

        // Act
        var result = baseObject.Cast<DerivedClass>();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.InstanceOf<DerivedClass>());
            Assert.That(result, Is.SameAs(baseObject));
        });
    }

    [Test]
    public void Cast_InvalidConversion_ShouldThrowInvalidCastException()
    {
        // Arrange
        BaseClass baseObject = new BaseClass();

        // Act & Assert
        Assert.Throws<InvalidCastException>(() => baseObject.Cast<DerivedClass>());
    }

    [Test]
    public void Cast_NullInput_ShouldReturnNull()
    {
        // Arrange
        BaseClass? baseObject = null;

        // Act
        var result = baseObject.Cast<DerivedClass>();

        // Assert
        Assert.That(result, Is.Null);
    }
}
