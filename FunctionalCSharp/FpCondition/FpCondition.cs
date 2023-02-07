namespace FunctionalCSharp;

public static partial class Fp
{

    /// <summary>
    /// Builds condition which returns provided <paramref name="then"/> value when <paramref name="condition"/> is <see langword="true"/>; otherwise a default value of <typeparamref name="T"/> is returned.
    /// </summary>
    /// <typeparam name="T">Type of value which is returned upon evaluation.</typeparam>
    /// <param name="condition">Indicates the condition is <see langword="true"/> or <see langword="false"/>.</param>
    /// <param name="then">Returned value by the evaluated condition if <paramref name="condition"/> is <see langword="true"/>.</param>
    /// <returns>Returns condition which then can be evaluated.</returns>
    public static IConditionStep<T> If<T>(bool condition, T then)
        => new IfValue<T>(condition, then);

    /// <summary>
    /// Builds condition which returns provided <paramref name="then"/> value when <paramref name="condition"/> returns <see langword="true"/>; otherwise a default value of <typeparamref name="T"/> is returned.
    /// </summary>
    /// <typeparam name="T">Type of value which is returned upon evaluation.</typeparam>
    /// <param name="condition">Delegate which returns if the condition is <see langword="true"/> or <see langword="false"/>.</param>
    /// <param name="then">Returned value by the evaluated condition if <paramref name="condition"/> is <see langword="true"/>.</param>
    /// <returns>Returns condition which then can be evaluated.</returns>
    public static IConditionStep<T> If<T>(Func<bool> condition, T then)
        => new IfValue<T>(condition, then);

    /// <summary>
    /// Builds condition which returns provided <paramref name="then"/> delegate when <paramref name="condition"/> is <see langword="true"/>; otherwise the delegate returns default value of <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">Type of value which is returned upon evaluation.</typeparam>
    /// <param name="condition">Indicates the condition is <see langword="true"/> or <see langword="false"/>.</param>
    /// <param name="then">Returned delegate by the evaluated condition if <paramref name="condition"/> is <see langword="true"/>.</param>
    /// <returns>Returns condition which then can be evaluated.</returns>
    public static IConditionStep<T> If<T>(bool condition, Func<T> then)
        => new IfExpression<T>(condition, then);

    /// <summary>
    /// Builds condition which returns provided <paramref name="then"/> delegate when <paramref name="condition"/> returns <see langword="true"/>; otherwise the delegate returns default value of <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">Type of value which is returned upon evaluation.</typeparam>
    /// <param name="condition">Delegate which returns if the condition is <see langword="true"/> or <see langword="false"/>.</param>
    /// <param name="then">Returned delegate by the evaluated condition if <paramref name="condition"/> is <see langword="true"/>.</param>
    /// <returns>Returns condition which then can be evaluated.</returns>
    public static IConditionStep<T> If<T>(Func<bool> condition, Func<T> then)
        => new IfExpression<T>(condition, then);

}