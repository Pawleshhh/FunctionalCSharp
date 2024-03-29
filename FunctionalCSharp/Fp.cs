﻿namespace FunctionalCSharp;

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

#pragma warning disable IDE0060 // Remove unused parameter
    /// <summary>
    /// Converts the given object into a statement without returning any value.
    /// </summary>
    /// <param name="value">The object to be converted into a statement.</param>
    public static void ToStatement(this object value) { }

    /// <summary>
    /// Converts the given object into a <see cref="Unit"/> value.
    /// </summary>
    /// <param name="value">The object to be converted into a <see cref="Unit"/> value.</param>
    /// <returns>A <see cref="Unit"/> value representing the conversion completion.</returns>
    public static Unit AsUnit(this object value)
        => UnitValue;
#pragma warning restore IDE0060 // Remove unused parameter

    /// <summary>
    /// Performs a safe type conversion or casting on the input object to the specified type.
    /// If the conversion is valid, returns the converted value; otherwise, returns null.
    /// </summary>
    /// <typeparam name="TOut">The type to which the input object should be converted.</typeparam>
    /// <param name="in">The input object to be converted.</param>
    /// <returns>The converted value if conversion is valid; otherwise, null.</returns>
    public static TOut? As<TOut>(this object? @in)
        where TOut : class
        => @in as TOut;

    /// <summary>
    /// Performs a type conversion or casting on the input object to the specified type.
    /// If the conversion is valid, returns the converted value; otherwise, throws an InvalidCastException.
    /// </summary>
    /// <typeparam name="TOut">The type to which the input object should be converted.</typeparam>
    /// <param name="in">The input object to be converted.</param>
    /// <returns>The converted value if the conversion is valid.</returns>
    /// <exception cref="InvalidCastException">Thrown when the conversion is not possible.</exception>
    public static TOut? Cast<TOut>(this object? @in)
        => (TOut?)@in;
}