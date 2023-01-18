namespace FunctionalCSharp;

public static partial class Fp
{
    public static IConditionStep<T> If<T>(bool condition, T then)
        => new IfValue<T>(condition, then);

    public static IConditionStep<T> If<T>(Func<bool> condition, T then)
        => new IfValue<T>(condition, then);

    public static IConditionStep<T> If<T>(bool condition, Func<T> then)
        => new IfExpression<T>(condition, then);

    public static IConditionStep<T> If<T>(Func<bool> condition, Func<T> then)
        => new IfExpression<T>(condition, then);

}