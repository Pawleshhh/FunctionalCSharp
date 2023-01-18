namespace FunctionalCSharp;

internal class IfValue<T> : IfBase<T>
{
    private bool? condition;
    private Func<bool>? funcCondition;
    private T? then;

    internal IfValue(bool condition, T then)
    {
        this.condition = condition;
        this.then = then;
    }

    internal IfValue(Func<bool> condition, T then)
    {
        this.funcCondition = condition;
        this.then = then;
    }

    public override ICondition<T> Else(T value)
    {
        then = value;
        return this;
    }

    public override ICondition<T> Else(Func<T> expression)
    {
        then = expression();
        return this;
    }

    public override T? Evaluate()
    {
        if (condition.HasValue)
        {
            return condition.Value ? then : (@else is not null ? @else.Evaluate() : default);
        }
        else
        {
            return funcCondition!() ? then : (@else is not null ? @else.Evaluate() : default);
        }
    }
}
