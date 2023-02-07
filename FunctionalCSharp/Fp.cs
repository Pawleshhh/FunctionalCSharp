namespace FunctionalCSharp;

/// <summary>
/// Helper class which provides functionalities for functional-like programming.
/// </summary>
public static partial class Fp
{

    /// <summary>
    /// Converts given <paramref name="value"/> to a <see cref="Func{T}"/> which returns that value.
    /// </summary>
    /// <typeparam name="T">Type of returned value.</typeparam>
    /// <param name="value">Value to be returned by returned <see cref="Func{T}"/> delegate.</param>
    /// <returns>Returns a <see cref="Func{T}"/> delegate which returns given <paramref name="value"/>.</returns>
    public static Func<T> AsFunc<T>(this T value)
    {
        return () => value;
    }

}