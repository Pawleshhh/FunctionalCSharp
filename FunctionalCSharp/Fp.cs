namespace FunctionalCSharp;

/// <summary>
/// Helper of managing delegates for functional programming.
/// </summary>
public static partial class Fp
{

    public static Func<T> AsFunc<T>(this T value)
    {
        return () => value;
    }

}
