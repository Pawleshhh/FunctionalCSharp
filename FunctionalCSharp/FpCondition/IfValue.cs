namespace FunctionalCSharp;

internal class IfValue<T> : IfBase<T>
{
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

    protected override T? EvaluateStep()
    {
        if (condition.HasValue)
        {
            return condition.Value ? then : (ElseStep is not null ? ElseStep.Evaluate() : default);
        }
        else
        {
            return funcCondition!() ? then : (ElseStep is not null ? ElseStep.Evaluate() : default);
        }
    }

}
