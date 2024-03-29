﻿namespace FunctionalCSharp;

public static partial class Fp
{

    /// <summary>
    /// Unit value to be returned by 'side-effect' functions.
    /// </summary>
    public static readonly Unit UnitValue = new();

    #region Unit

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static Unit Unit(this Action action)
    {
        action();
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static Unit Unit<T>
        (this Action<T> action, T t)
    {
        action(t);
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static Unit Unit<T1, T2>
        (this Action<T1, T2> action,
        T1 t1, T2 t2)
    {
        action(t1, t2);
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static Unit Unit<T1, T2, T3>
        (this Action<T1, T2, T3> action,
        T1 t1, T2 t2, T3 t3)
    {
        action(t1, t2, t3);
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static Unit Unit<T1, T2, T3, T4>
        (this Action<T1, T2, T3, T4> action,
        T1 t1, T2 t2, T3 t3, T4 t4)
    {
        action(t1, t2, t3, t4);
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static Unit Unit<T1, T2, T3, T4, T5>
        (this Action<T1, T2, T3, T4, T5> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
    {
        action(t1, t2, t3, t4, t5);
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static Unit Unit<T1, T2, T3, T4, T5, T6>
        (this Action<T1, T2, T3, T4, T5, T6> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
    {
        action(t1, t2, t3, t4, t5, t6);
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static Unit Unit<T1, T2, T3, T4, T5, T6, T7>
        (this Action<T1, T2, T3, T4, T5, T6, T7> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
    {
        action(t1, t2, t3, t4, t5, t6, t7);
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static Unit Unit<T1, T2, T3, T4, T5, T6, T7, T8>
        (this Action<T1, T2, T3, T4, T5, T6, T7, T8> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
    {
        action(t1, t2, t3, t4, t5, t6, t7, t8);
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static Unit Unit<T1, T2, T3, T4, T5, T6, T7, T8, T9>
        (this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
    {
        action(t1, t2, t3, t4, t5, t6, t7, t8, t9);
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static Unit Unit<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
        (this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
    {
        action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static Unit Unit<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
        (this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
    {
        action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static Unit Unit<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
        (this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
    {
        action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static Unit Unit<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
        (this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
    {
        action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static Unit Unit<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
        (this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
    {
        action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static Unit Unit<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
        (this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
    {
        action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static Unit Unit<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
        (this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16)
    {
        action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);
        return UnitValue;
    }

    #endregion

    #region Async Unit

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate asynchronously and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static async Task<Unit> UnitAsync(this Action action)
    {
        await Task.Run(action);
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate asynchronously and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static async Task<Unit> UnitAsync<T>
        (this Action<T> action, T t)
    {
        await Task.Run(() => action(t));
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate asynchronously and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static async Task<Unit> UnitAsync<T1, T2>
        (this Action<T1, T2> action,
        T1 t1, T2 t2)
    {
        await Task.Run(() => action(t1, t2));
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate asynchronously and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static async Task<Unit> UnitAsync<T1, T2, T3>
        (this Action<T1, T2, T3> action,
        T1 t1, T2 t2, T3 t3)
    {
        await Task.Run(() => action(t1, t2, t3));
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate asynchronously and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static async Task<Unit> UnitAsync<T1, T2, T3, T4>
        (this Action<T1, T2, T3, T4> action,
        T1 t1, T2 t2, T3 t3, T4 t4)
    {
        await Task.Run(() => action(t1, t2, t3, t4));
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate asynchronously and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static async Task<Unit> UnitAsync<T1, T2, T3, T4, T5>
        (this Action<T1, T2, T3, T4, T5> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
    {
        await Task.Run(() => action(t1, t2, t3, t4, t5));
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate asynchronously and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static async Task<Unit> UnitAsync<T1, T2, T3, T4, T5, T6>
        (this Action<T1, T2, T3, T4, T5, T6> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
    {
        await Task.Run(() => action(t1, t2, t3, t4, t5, t6));
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate asynchronously and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static async Task<Unit> UnitAsync<T1, T2, T3, T4, T5, T6, T7>
        (this Action<T1, T2, T3, T4, T5, T6, T7> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
    {
        await Task.Run(() => action(t1, t2, t3, t4, t5, t6, t7));
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate asynchronously and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static async Task<Unit> UnitAsync<T1, T2, T3, T4, T5, T6, T7, T8>
        (this Action<T1, T2, T3, T4, T5, T6, T7, T8> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
    {
        await Task.Run(() => action(t1, t2, t3, t4, t5, t6, t7, t8));
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate asynchronously and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static async Task<Unit> UnitAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>
        (this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
    {
        await Task.Run(() => action(t1, t2, t3, t4, t5, t6, t7, t8, t9));
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate asynchronously and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static async Task<Unit> UnitAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
        (this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
    {
        await Task.Run(() => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate asynchronously and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static async Task<Unit> UnitAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
        (this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
    {
        await Task.Run(() => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate asynchronously and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static async Task<Unit> UnitAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
        (this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
    {
        await Task.Run(() => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate asynchronously and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static async Task<Unit> UnitAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
        (this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
    {
        await Task.Run(() => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate asynchronously and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static async Task<Unit> UnitAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
        (this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
    {
        await Task.Run(() => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate asynchronously and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static async Task<Unit> UnitAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
        (this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
    {
        await Task.Run(() => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
        return UnitValue;
    }

    /// <summary>
    /// Invokes provided <paramref name="action"/> delegate asynchronously and returns <see cref="FunctionalCSharp.Unit"/> value.
    /// </summary>
    /// <param name="action">Action to be invoked.</param>
    /// <returns>Returns <see cref="FunctionalCSharp.Unit"/> value.</returns>
    public static async Task<Unit> UnitAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
        (this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16)
    {
        await Task.Run(() => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16));
        return UnitValue;
    }

    #endregion

}
