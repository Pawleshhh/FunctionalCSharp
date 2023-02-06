namespace FunctionalCSharp;

internal abstract class IfBase<T> : IConditionStep<T>
{
    protected bool? condition;
    protected Func<bool>? funcCondition;

    protected IfBase<T>? ElseStep { get; private set; }
    protected IfBase<T>? ParentStep { get; private set; }

    public IConditionStep<T> Elif(bool condition, T then)
    {
        ElseStep = new IfValue<T>(condition, then) { ParentStep = this };
        return ElseStep;
    }

    public IConditionStep<T> Elif(Func<bool> condition, T then)
    {
        ElseStep = new IfValue<T>(condition, then) { ParentStep = this };
        return ElseStep;
    }

    public IConditionStep<T> Elif(bool condition, Func<T> then)
    {
        ElseStep = new IfExpression<T>(condition, then) { ParentStep = this };
        return ElseStep;
    }

    public IConditionStep<T> Elif(Func<bool> condition, Func<T> then)
    {
        ElseStep = new IfExpression<T>(condition, then) { ParentStep = this };
        return ElseStep;
    }

    public ICondition<T> Else(T value)
    {
        ElseStep = new IfValue<T>(true, value) { ParentStep = this };
        return ElseStep;
    }

    public ICondition<T> Else(Func<T> expression)
    {
        ElseStep = new IfExpression<T>(true, expression) { ParentStep = this };
        return ElseStep;
    }

    public T? Evaluate()
    {
        IfBase<T> step = this;
        while (step.ParentStep != null)
        {
            step = step.ParentStep;
        }

        while (step.ElseStep != null && !step.GetCondition())
        {
            step = step.ElseStep;
        }

        return step.EvaluateStep();
    }

    protected bool GetCondition()
        => condition ?? funcCondition!();

    protected abstract T? EvaluateStep();

}
