using NUnit.Framework.Constraints;

namespace FunctionalCSharp.Test;

[TestFixture]
internal abstract class FpConditionBaseTest<T>
{

    #region If

    [Test]
    public void If_ValueConditionThenValue_ReturnsThenValue()
    {
        T value = GetValue();
        Assert.That(Fp.If(true, value).Evaluate(), IsAsExpected(value));
    }

    [Test]
    public void If_ValueConditionThenValue_ReturnsDefaultValue()
        => Assert.That(Fp.If(false, GetValue()).Evaluate(), IsDefault());

    [Test]
    public void If_ValueConditionThenExpression_ReturnThenExpression()
    {
        T value = GetValue();
        Assert.That(Fp.If(true, () => value).Evaluate(), IsAsExpected(value));
    }

    [Test]
    public void If_ValueConditionThenExpression_ReturnsDefaultValue()
        => Assert.That(Fp.If(false, () => GetValue()).Evaluate(), IsDefault());

    [Test]
    public void If_ExpressionConditionThenValue_ReturnsThenValue()
    {
        T value = GetValue();
        Assert.That(Fp.If(() => true, value).Evaluate(), IsAsExpected(value));
    }

    [Test]
    public void If_ExpressionConditionThenValue_ReturnsDefaultValue()
        => Assert.That(Fp.If(() => false, GetValue()).Evaluate(), IsDefault());

    [Test]
    public void If_ExpressionConditionThenExpression_ReturnThenExpression()
    {
        T value = GetValue();
        Assert.That(Fp.If(true, () => value).Evaluate(), IsAsExpected(value));
    }

    [Test]
    public void If_ExpressionConditionThenExpression_ReturnsDefaultValue()
        => Assert.That(Fp.If(() => false, () => GetValue()).Evaluate(), IsDefault());

    #endregion

    
    #region IfElse

    [Test]
    public void IfElse_ValueConditionThenValue_ReturnsThenValue()
    {
        T thenValue = GetValue(), elseValue = GetValue(1);
        Assert.That(Fp.If(true, thenValue).Else(elseValue).Evaluate(), IsAsExpected(thenValue));
    }

    [Test]
    public void IfElse_ValueConditionThenValue_ReturnsElseValue()
    {
        T thenValue = GetValue(), elseValue = GetValue(1);
        Assert.That(Fp.If(false, thenValue).Else(elseValue).Evaluate(), IsAsExpected(elseValue));
    }

    [Test]
    public void IfElse_ValueConditionThenValue_ReturnsElseExpression()
    {
        T thenValue = GetValue(), elseValue = GetValue(1);
        Assert.That(Fp.If(false, thenValue).Else(() => elseValue).Evaluate(), IsAsExpected(elseValue));
    }

    [Test]
    public void IfElse_ValueConditionThenExpression_ReturnThenExpression()
    {
        T thenValue = GetValue(), elseValue = GetValue(1);
        Assert.That(Fp.If(true, () => thenValue).Else(elseValue).Evaluate(), IsAsExpected(thenValue));
    }

    [Test]
    public void IfElse_ValueConditionThenExpression_ReturnsElseValue()
    {
        T thenValue = GetValue(), elseValue = GetValue(1);
        Assert.That(Fp.If(false, () => thenValue).Else(elseValue).Evaluate(), IsAsExpected(elseValue));
    }

    [Test]
    public void IfElse_ValueConditionThenExpression_ReturnsElseExpression()
    {
        T thenValue = GetValue(), elseValue = GetValue(1);
        Assert.That(Fp.If(false, () => thenValue).Else(() => elseValue).Evaluate(), IsAsExpected(elseValue));
    }

    [Test]
    public void IfElse_ExpressionConditionThenValue_ReturnsThenValue()
    {
        T thenValue = GetValue(), elseValue = GetValue(1);
        Assert.That(Fp.If(() => true, thenValue).Else(elseValue).Evaluate(), IsAsExpected(thenValue));
    }

    [Test]
    public void IfElse_ExpressionConditionThenValue_ReturnsElseValue()
    {
        T thenValue = GetValue(), elseValue = GetValue(1);
        Assert.That(Fp.If(() => false, thenValue).Else(elseValue).Evaluate(), IsAsExpected(elseValue));
    }

    [Test]
    public void IfElse_ExpressionConditionThenValue_ReturnsElseExpression()
    {
        T thenValue = GetValue(), elseValue = GetValue(1);
        Assert.That(Fp.If(() => false, thenValue).Else(() => elseValue).Evaluate(), IsAsExpected(elseValue));
    }

    [Test]
    public void IfElse_ExpressionConditionThenExpression_ReturnThenExpression()
    {
        T thenValue = GetValue(), elseValue = GetValue(1);
        Assert.That(Fp.If(() => true, () => thenValue).Else(elseValue).Evaluate(), IsAsExpected(thenValue));
    }

    [Test]
    public void IfElse_ExpressionConditionThenExpression_ReturnsElseValue()
    {
        T thenValue = GetValue(), elseValue = GetValue(1);
        Assert.That(Fp.If(() => false, () => thenValue).Else(elseValue).Evaluate(), IsAsExpected(elseValue));
    }

    [Test]
    public void IfElse_ExpressionConditionThenExpression_ReturnsElseExpression()
    {
        T thenValue = GetValue(), elseValue = GetValue(1);
        Assert.That(Fp.If(() => false, () => thenValue).Else(() => elseValue).Evaluate(), IsAsExpected(elseValue));
    }

    #endregion

    #region IfElseIf

    [Test]
    public void IfElseIf_ValueConditionThenValue_ReturnsThenValue()
    {
        T thenValue = GetValue(), elseIfValue = GetValue(1);
        Assert.That(Fp.If(true, thenValue).Elif(true, elseIfValue).Evaluate(), IsAsExpected(thenValue));
    }

    [Test]
    public void IfElseIf_ValueConditionThenValue_ReturnsElseIfValue()
    {
        T thenValue = GetValue(), elseIfValue = GetValue(1);
        Assert.That(Fp.If(false, thenValue).Elif(true, elseIfValue).Evaluate(), IsAsExpected(elseIfValue));
    }

    [Test]
    public void IfElseIf_ValueConditionThenExpression_ReturnThenExpression()
    {
        T thenValue = GetValue(), elseIfValue = GetValue(1);
        Assert.That(Fp.If(true, () => thenValue).Elif(true, () => elseIfValue).Evaluate(), IsAsExpected(thenValue));
    }

    [Test]
    public void IfElseIf_ValueConditionThenExpression_ReturnsElseIfValue()
    {
        T thenValue = GetValue(), elseIfValue = GetValue(1);
        Assert.That(Fp.If(false, () => thenValue).Elif(true, () => elseIfValue).Evaluate(), IsAsExpected(elseIfValue));
    }

    [Test]
    public void IfElseIf_ExpressionConditionThenValue_ReturnsThenValue()
    {
        T thenValue = GetValue(), elseIfValue = GetValue(1);
        Assert.That(Fp.If(() => true, thenValue).Elif(() => true, elseIfValue).Evaluate(), IsAsExpected(thenValue));
    }

    [Test]
    public void IfElseIf_ExpressionConditionThenValue_ReturnsElseIfValue()
    {
        T thenValue = GetValue(), elseIfValue = GetValue(1);
        Assert.That(Fp.If(() => false, thenValue).Elif(() => true, elseIfValue).Evaluate(), IsAsExpected(elseIfValue));
    }

    [Test]
    public void IfElseIf_ExpressionConditionThenExpression_ReturnThenExpression()
    {
        T thenValue = GetValue(), elseIfValue = GetValue(1);
        Assert.That(Fp.If(() => true, () => thenValue).Elif(() => true, () => elseIfValue).Evaluate(), IsAsExpected(thenValue));
    }

    [Test]
    public void IfElseIf_ExpressionConditionThenExpression_ReturnsElseIfValue()
    {
        T thenValue = GetValue(), elseIfValue = GetValue(1);
        Assert.That(Fp.If(() => false, () => thenValue).Elif(() => true, () => elseIfValue).Evaluate(), IsAsExpected(elseIfValue));
    }

    [Test]
    public void IfElseIf_ValueConditionThenValue_ReturnsDefaultValue()
    {
        T thenValue = GetValue(), elseIfValue = GetValue(1);
        Assert.That(Fp.If(false, thenValue).Elif(false, elseIfValue).Evaluate(), IsDefault());
    }

    [Test]
    public void IfElseIf_ValueConditionThenExpression_ReturnsDefaultValue()
    {
        T thenValue = GetValue(), elseIfValue = GetValue(1);
        Assert.That(Fp.If(false, () => thenValue).Elif(false, () => elseIfValue).Evaluate(), IsDefault());
    }

    [Test]
    public void IfElseIf_ExpressionConditionThenValue_ReturnsDefaultValue()
    {
        T thenValue = GetValue(), elseIfValue = GetValue(1);
        Assert.That(Fp.If(() => false, thenValue).Elif(() => false, elseIfValue).Evaluate(), IsDefault());
    }

    [Test]
    public void IfElseIf_ExpressionConditionThenExpression_ReturnsDefaultValue()
    {
        T thenValue = GetValue(), elseIfValue = GetValue(1);
        Assert.That(Fp.If(() => false, () => thenValue).Elif(() => false, () => elseIfValue).Evaluate(), IsDefault());
    }

    #endregion

    #region IfElseIfElse

    [Test]
    public void IfElseIfElse_ValueConditionThenValue_ReturnsThenValue()
    {
        T thenValue = GetValue(), elseIfValue = GetValue(1), elseValue = GetValue(2);
        Assert.That(Fp.If(true, thenValue).Elif(true, elseIfValue).Else(elseValue).Evaluate(), IsAsExpected(thenValue));
    }

    [Test]
    public void IfElseIfElse_ValueConditionThenValue_ReturnsElseIfValue()
    {
        T thenValue = GetValue(), elseIfValue = GetValue(1), elseValue = GetValue(2);
        Assert.That(Fp.If(false, thenValue).Elif(true, elseIfValue).Else(elseValue).Evaluate(), IsAsExpected(elseIfValue));
    }

    [Test]
    public void IfElseIfElse_ValueConditionThenExpression_ReturnThenExpression()
    {
        T thenValue = GetValue(), elseIfValue = GetValue(1), elseValue = GetValue(2);
        Assert.That(Fp.If(true, () => thenValue).Elif(true, () => elseIfValue).Else(elseValue).Evaluate(), IsAsExpected(thenValue));
    }

    [Test]
    public void IfElseIfElse_ValueConditionThenExpression_ReturnsElseIfValue()
    {
        T thenValue = GetValue(), elseIfValue = GetValue(1), elseValue = GetValue(2);
        Assert.That(Fp.If(false, () => thenValue).Elif(true, () => elseIfValue).Else(elseValue).Evaluate(), IsAsExpected(elseIfValue));
    }

    [Test]
    public void IfElseIfElse_ExpressionConditionThenValue_ReturnsThenValue()
    {
        T thenValue = GetValue(), elseIfValue = GetValue(1), elseValue = GetValue(2);
        Assert.That(Fp.If(() => true, thenValue).Elif(() => true, elseIfValue).Else(elseValue).Evaluate(), IsAsExpected(thenValue));
    }

    [Test]
    public void IfElseIfElse_ExpressionConditionThenValue_ReturnsElseIfValue()
    {
        T thenValue = GetValue(), elseIfValue = GetValue(1), elseValue = GetValue(2);
        Assert.That(Fp.If(() => false, thenValue).Elif(() => true, elseIfValue).Else(elseValue).Evaluate(), IsAsExpected(elseIfValue));
    }

    [Test]
    public void IfElseIfElse_ExpressionConditionThenExpression_ReturnThenExpression()
    {
        T thenValue = GetValue(), elseIfValue = GetValue(1), elseValue = GetValue(2);
        Assert.That(Fp.If(() => true, () => thenValue).Elif(() => true, () => elseIfValue).Else(elseValue).Evaluate(), IsAsExpected(thenValue));
    }

    [Test]
    public void IfElseIfElse_ExpressionConditionThenExpression_ReturnsElseIfValue()
    {
        T thenValue = GetValue(), elseIfValue = GetValue(1), elseValue = GetValue(2);
        Assert.That(Fp.If(() => false, () => thenValue).Elif(() => true, () => elseIfValue).Else(elseValue).Evaluate(), IsAsExpected(elseIfValue));
    }

    [Test]
    public void IfElseIfElse_ValueConditionThenValue_ReturnsDefaultValue()
    {
        T thenValue = GetValue(), elseIfValue = GetValue(1), elseValue = GetValue(2);
        Assert.That(Fp.If(false, thenValue).Elif(false, elseIfValue).Else(elseValue).Evaluate(), IsAsExpected(elseValue));
    }

    [Test]
    public void IfElseIfElse_ValueConditionThenExpression_ReturnsDefaultValue()
    {
        T thenValue = GetValue(), elseIfValue = GetValue(1), elseValue = GetValue(2);
        Assert.That(Fp.If(false, () => thenValue).Elif(false, () => elseIfValue).Else(elseValue).Evaluate(), IsAsExpected(elseValue));
    }

    [Test]
    public void IfElseIfElse_ExpressionConditionThenValue_ReturnsDefaultValue()
    {
        T thenValue = GetValue(), elseIfValue = GetValue(1), elseValue = GetValue(2);
        Assert.That(Fp.If(() => false, thenValue).Elif(() => false, elseIfValue).Else(elseValue).Evaluate(), IsAsExpected(elseValue));
    }

    [Test]
    public void IfElseIfElse_ExpressionConditionThenExpression_ReturnsDefaultValue()
    {
        T thenValue = GetValue(), elseIfValue = GetValue(1), elseValue = GetValue(2);
        Assert.That(Fp.If(() => false, () => thenValue).Elif(() => false, () => elseIfValue).Else(elseValue).Evaluate(), IsAsExpected(elseValue));
    }

    #endregion

    #region Base

    protected abstract T GetValue(int seed = 0);
    protected abstract Constraint IsDefault();
    protected abstract Constraint IsAsExpected(T value);

    #endregion

}
