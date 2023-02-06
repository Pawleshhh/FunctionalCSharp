using NUnit.Framework.Constraints;

namespace FunctionalCSharp.Test;

[TestFixture]
internal class FpConditionStructTest : FpConditionBaseTest<int>
{

    protected override int GetValue(int seed = 0) => seed;

    protected override Constraint IsAsExpected(int value)
        => Is.EqualTo(value);

    protected override Constraint IsDefault()
        => Is.EqualTo(0);

}
