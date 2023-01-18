namespace FunctionalCSharp;

internal class IfExpression<T> : IfBase<T>
{
    private bool? condition;
    private Func<bool>? funcCondition;
    private Func<T>? then;

    internal IfExpression(bool condition, Func<T> then)
    {
        this.condition = condition;
        this.then = then;
    }

    internal IfExpression(Func<bool> condition, Func<T> then)
    {
        this.funcCondition = condition;
        this.then = then;
    }

    public override ICondition<T> Else(T value)
    {
        then = value.AsFunc();
        return this;
    }

    public override ICondition<T> Else(Func<T> expression)
    {
        then = expression;
        return this;
    }

    public override T? Evaluate()
    {
        if (condition.HasValue)
        {
            return condition.Value ? then!() : (@else is not null ? @else.Evaluate() : default);
        }
        else
        {
            return funcCondition!() ? then!() : (@else is not null ? @else.Evaluate() : default);
        }
    }

}
