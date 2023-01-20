namespace FunctionalCSharp;

internal class IfExpression<T> : IfBase<T>
{
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

    protected override T? EvaluateStep()
    {
        if (condition.HasValue)
        {
            return condition.Value ? then!() : (ElseStep is not null ? ElseStep.Evaluate() : default);
        }
        else
        {
            return funcCondition!() ? then!() : (ElseStep is not null ? ElseStep.Evaluate() : default);
        }
    }

}
