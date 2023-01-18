namespace FunctionalCSharp;

internal abstract class IfBase<T> : IConditionStep<T>
{
    protected IConditionStep<T>? @else;

    public IConditionStep<T> Elif(bool condition, T then)
    {
        @else = new IfValue<T>(condition, then);
        return @else;
    }

    public IConditionStep<T> Elif(Func<bool> condition, T then)
    {
        @else = new IfValue<T>(condition, then);
        return @else;
    }

    public IConditionStep<T> Elif(bool condition, Func<T> then)
    {
        @else = new IfExpression<T>(condition, then);
        return @else;
    }

    public IConditionStep<T> Elif(Func<bool> condition, Func<T> then)
    {
        @else = new IfExpression<T>(condition, then);
        return @else;
    }

    public abstract ICondition<T> Else(T value);

    public abstract ICondition<T> Else(Func<T> expression);

    public abstract T? Evaluate();
}
