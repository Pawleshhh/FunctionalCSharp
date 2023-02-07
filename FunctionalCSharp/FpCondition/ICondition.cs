namespace FunctionalCSharp;

/// <summary>
/// Defines a condition which can be evaluated.
/// </summary>
/// <typeparam name="T">Type of value which is returned upon evaluation.</typeparam>
public interface ICondition<T>
{
    /// <summary>
    /// Evaluates the condition.
    /// </summary>
    /// <returns>Returns value of the condition.</returns>
    public T? Evaluate();
}

/// <summary>
/// Defines a step of condition that can be evaluated.
/// </summary>
/// <typeparam name="T">Type of value which is returned upon evaluation.</typeparam>
public interface IConditionStep<T> : ICondition<T>
{
    /// <summary>
    /// Builds condition which returns provided <paramref name="then"/> value when <paramref name="condition"/> is <see langword="true"/> and previous condition step is <see langword="false"/>; otherwise a default value of <typeparamref name="T"/> is returned.
    /// </summary>
    /// <param name="condition">Indicates the condition is <see langword="true"/> or <see langword="false"/>.</param>
    /// <param name="then">Returned value by the evaluated condition if <paramref name="condition"/> is <see langword="true"/>.</param>
    /// <returns>Returns condition which then can be evaluated.</returns>
    public IConditionStep<T> Elif(bool condition, T then);

    /// <summary>
    /// Builds condition which returns provided <paramref name="then"/> value when <paramref name="condition"/> returns <see langword="true"/> and previous condition step is <see langword="false"/>; otherwise a default value of <typeparamref name="T"/> is returned.
    /// </summary>
    /// <param name="condition">Delegate which returns if the condition is <see langword="true"/> or <see langword="false"/>.</param>
    /// <param name="then">Returned value by the evaluated condition if <paramref name="condition"/> is <see langword="true"/>.</param>
    /// <returns>Returns condition which then can be evaluated.</returns>
    public IConditionStep<T> Elif(Func<bool> condition, T then);

    /// <summary>
    /// Builds condition which returns provided <paramref name="then"/> delegate when <paramref name="condition"/> is <see langword="true"/> and previous condition step is <see langword="false"/>; otherwise the delegate returns default value of <typeparamref name="T"/>.
    /// </summary>
    /// <param name="condition">Indicates the condition is <see langword="true"/> or <see langword="false"/>.</param>
    /// <param name="then">Returned delegate by the evaluated condition if <paramref name="condition"/> is <see langword="true"/>.</param>
    /// <returns>Returns condition which then can be evaluated.</returns>
    public IConditionStep<T> Elif(bool condition, Func<T> then);

    /// <summary>
    /// Builds condition which returns provided <paramref name="then"/> delegate when <paramref name="condition"/> returns <see langword="true"/> and previous condition step is <see langword="false"/>; otherwise the delegate returns default value of <typeparamref name="T"/>.
    /// </summary>
    /// <param name="condition">Delegate which returns if the condition is <see langword="true"/> or <see langword="false"/>.</param>
    /// <param name="then">Returned delegate by the evaluated condition if <paramref name="condition"/> is <see langword="true"/>.</param>
    /// <returns>Returns condition which then can be evaluated.</returns>
    public IConditionStep<T> Elif(Func<bool> condition, Func<T> then);

    /// <summary>
    /// Builds condition which returns provided <paramref name="value"/> when all of the previous steps did not meet their conditions.
    /// </summary>
    /// <param name="value">Value to be returned.</param>
    /// <returns>Returns given <paramref name="value"/>.</returns>
    public ICondition<T> Else(T value);

    /// <summary>
    /// Builds condition which returns provided <paramref name="expression"/> when all of the previous steps did not meet their conditions.
    /// </summary>
    /// <param name="expression">Delegate to be returned.</param>
    /// <returns>Returns given <paramref name="expression"/> delegate.</returns>
    public ICondition<T> Else(Func<T> expression);
}

