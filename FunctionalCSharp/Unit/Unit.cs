namespace FunctionalCSharp;

/// <summary>
/// Defines value which is returned by 'side-effect' functions.
/// </summary>
public class Unit 
{

    /// <summary>
    /// Helper method which converts an expression of functions to a statement.
    /// </summary>
    public void Void() { }

    #region Create

    /// <summary>
    /// Converts given <paramref name="action"/> to a func delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to a func delegate.</returns>
    public static Func<Unit> Create
        (Action action)
        => () =>
        {
            action();
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to a func delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to a func delegate.</returns>
    public static Func<T, Unit> Create<T>
        (Action<T> action)
        => t =>
        {
            action(t);
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to a func delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to a func delegate.</returns>
    public static Func<T1, T2, Unit> Create<T1, T2>
        (Action<T1, T2> action)
        => (t1, t2) =>
        {
            action(t1, t2);
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to a func delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to a func delegate.</returns>
    public static Func<T1, T2, T3, Unit> Create<T1, T2, T3>
        (Action<T1, T2, T3> action)
        => (t1, t2, t3) =>
        {
            action(t1, t2, t3);
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to a func delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to a func delegate.</returns>
    public static Func<T1, T2, T3, T4, Unit> Create<T1, T2, T3, T4>
        (Action<T1, T2, T3, T4> action)
        => (t1, t2, t3, t4) =>
        {
            action(t1, t2, t3, t4);
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to a func delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to a func delegate.</returns>
    public static Func<T1, T2, T3, T4, T5, Unit> Create<T1, T2, T3, T4, T5>
        (Action<T1, T2, T3, T4, T5> action)
        => (t1, t2, t3, t4, t5) =>
        {
            action(t1, t2, t3, t4, t5);
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to a func delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to a func delegate.</returns>
    public static Func<T1, T2, T3, T4, T5, T6, Unit> Create<T1, T2, T3, T4, T5, T6>
        (Action<T1, T2, T3, T4, T5, T6> action)
        => (t1, t2, t3, t4, t5, t6) =>
        {
            action(t1, t2, t3, t4, t5, t6);
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to a func delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to a func delegate.</returns>
    public static Func<T1, T2, T3, T4, T5, T6, T7, Unit> Create<T1, T2, T3, T4, T5, T6, T7>
        (Action<T1, T2, T3, T4, T5, T6, T7> action)
        => (t1, t2, t3, t4, t5, t6, t7) =>
        {
            action(t1, t2, t3, t4, t5, t6, t7);
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to a func delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to a func delegate.</returns>
    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Unit> Create<T1, T2, T3, T4, T5, T6, T7, T8>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        => (t1, t2, t3, t4, t5, t6, t7, t8) =>
        {
            action(t1, t2, t3, t4, t5, t6, t7, t8);
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to a func delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to a func delegate.</returns>
    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Unit> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        => (t1, t2, t3, t4, t5, t6, t7, t8, t9) =>
        {
            action(t1, t2, t3, t4, t5, t6, t7, t8, t9);
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to a func delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to a func delegate.</returns>
    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Unit> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action)
        => (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) =>
        {
            action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to a func delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to a func delegate.</returns>
    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Unit> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action)
        => (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) =>
        {
            action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to a func delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to a func delegate.</returns>
    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Unit> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action)
        => (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) =>
        {
            action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to a func delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to a func delegate.</returns>
    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Unit> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action)
        => (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) =>
        {
            action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to a func delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to a func delegate.</returns>
    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Unit> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action)
        => (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) =>
        {
            action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to a func delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to a func delegate.</returns>
    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Unit> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action)
        => (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) =>
        {
            action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to a func delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to a func delegate.</returns>
    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Unit> Create<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action)
        => (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) =>
        {
            action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);
            return Fp.UnitValue;
        };

    #endregion

    #region CreateAsync

    /// <summary>
    /// Converts given <paramref name="action"/> to an asynchronous delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to an asynchronous delegate.</returns>
    public static Func<Task<Unit>> CreateAsync
        (Action action)
        => async () =>
        {
            await Task.Run(action);
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to an asynchronous delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to an asynchronous delegate.</returns>
    public static Func<T, Task<Unit>> CreateAsync<T>
        (Action<T> action)
        => async t =>
        {
            await Task.Run(() => action(t));
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to an asynchronous delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to an asynchronous delegate.</returns>
    public static Func<T1, T2, Task<Unit>> CreateAsync<T1, T2>
        (Action<T1, T2> action)
        => async (t1, t2) =>
        {
            await Task.Run(() => action(t1, t2));
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to an asynchronous delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to an asynchronous delegate.</returns>
    public static Func<T1, T2, T3, Task<Unit>> CreateAsync<T1, T2, T3>
        (Action<T1, T2, T3> action)
        => async (t1, t2, t3) =>
        {
            await Task.Run(() => action(t1, t2, t3));
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to an asynchronous delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to an asynchronous delegate.</returns>
    public static Func<T1, T2, T3, T4, Task<Unit>> CreateAsync<T1, T2, T3, T4>
        (Action<T1, T2, T3, T4> action)
        => async (t1, t2, t3, t4) =>
        {
            await Task.Run(() => action(t1, t2, t3, t4));
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to an asynchronous delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to an asynchronous delegate.</returns>
    public static Func<T1, T2, T3, T4, T5, Task<Unit>> CreateAsync<T1, T2, T3, T4, T5>
        (Action<T1, T2, T3, T4, T5> action)
        => async (t1, t2, t3, t4, t5) =>
        {
            await Task.Run(() => action(t1, t2, t3, t4, t5));
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to an asynchronous delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to an asynchronous delegate.</returns>
    public static Func<T1, T2, T3, T4, T5, T6, Task<Unit>> CreateAsync<T1, T2, T3, T4, T5, T6>
        (Action<T1, T2, T3, T4, T5, T6> action)
        => async (t1, t2, t3, t4, t5, t6) =>
        {
            await Task.Run(() => action(t1, t2, t3, t4, t5, t6));
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to an asynchronous delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to an asynchronous delegate.</returns>
    public static Func<T1, T2, T3, T4, T5, T6, T7, Task<Unit>> CreateAsync<T1, T2, T3, T4, T5, T6, T7>
        (Action<T1, T2, T3, T4, T5, T6, T7> action)
        => async (t1, t2, t3, t4, t5, t6, t7) =>
        {
            await Task.Run(() => action(t1, t2, t3, t4, t5, t6, t7));
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to an asynchronous delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to an asynchronous delegate.</returns>
    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<Unit>> CreateAsync<T1, T2, T3, T4, T5, T6, T7, T8>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
        => async (t1, t2, t3, t4, t5, t6, t7, t8) =>
        {
            await Task.Run(() => action(t1, t2, t3, t4, t5, t6, t7, t8));
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to an asynchronous delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to an asynchronous delegate.</returns>
    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<Unit>> CreateAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
        => async (t1, t2, t3, t4, t5, t6, t7, t8, t9) =>
        {
            await Task.Run(() => action(t1, t2, t3, t4, t5, t6, t7, t8, t9));
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to an asynchronous delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to an asynchronous delegate.</returns>
    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<Unit>> CreateAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action)
        => async (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10) =>
        {
            await Task.Run(() => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10));
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to an asynchronous delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to an asynchronous delegate.</returns>
    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<Unit>> CreateAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action)
        => async (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11) =>
        {
            await Task.Run(() => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11));
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to an asynchronous delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to an asynchronous delegate.</returns>
    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<Unit>> CreateAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action)
        => async (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12) =>
        {
            await Task.Run(() => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12));
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to an asynchronous delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to an asynchronous delegate.</returns>
    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<Unit>> CreateAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action)
        => async (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13) =>
        {
            await Task.Run(() => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13));
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to an asynchronous delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to an asynchronous delegate.</returns>
    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<Unit>> CreateAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action)
        => async (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14) =>
        {
            await Task.Run(() => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14));
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to an asynchronous delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to an asynchronous delegate.</returns>
    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<Unit>> CreateAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action)
        => async (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15) =>
        {
            await Task.Run(() => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15));
            return Fp.UnitValue;
        };
    /// <summary>
    /// Converts given <paramref name="action"/> to an asynchronous delegate.
    /// </summary>
    /// <param name="action">Delegate to be converted.</param>
    /// <returns>Returns converted <paramref name="action"/> to an asynchronous delegate.</returns>
    public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<Unit>> CreateAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
        (Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action)
        => async (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16) =>
        {
            await Task.Run(() => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16));
            return Fp.UnitValue;
        };

    #endregion

}