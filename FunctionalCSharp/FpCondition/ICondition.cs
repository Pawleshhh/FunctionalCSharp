namespace FunctionalCSharp;

public interface ICondition<T>
{
    public T? Evaluate();
}

public interface IConditionStep<T> : ICondition<T>
{

    public IConditionStep<T> Elif(bool condition, T then);
    public IConditionStep<T> Elif(Func<bool> condition, T then);
    public IConditionStep<T> Elif(bool condition, Func<T> then);
    public IConditionStep<T> Elif(Func<bool> condition, Func<T> then);
    public ICondition<T> Else(T value);
    public ICondition<T> Else(Func<T> expression);
}

