using NUnit.Framework.Constraints;

namespace FunctionalCSharp.Test;

[TestFixture]
internal class FpConditionReferenceTest : FpConditionBaseTest<FpConditionDataClassTest>
{

    protected override FpConditionDataClassTest GetValue(int seed = 0)
        => new() { Value = seed };

    protected override Constraint IsAsExpected(FpConditionDataClassTest value)
        => Is.SameAs(value);

    protected override Constraint IsDefault()
        => Is.Null;
}

internal class FpConditionDataClassTest
{ 
    public required int Value { get; init; }

}