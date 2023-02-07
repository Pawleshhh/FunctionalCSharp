namespace FunctionalCSharp;

public static partial class Fp
{

    #region Curry Action Last arg

    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action Curry<TLast>(this Action<TLast> action, TLast last) => () => action(last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<TLast> Curry<T1, TLast>(this Action<T1, TLast> action,
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
        T1 t1) => last => action(t1, last);
    public static Action<TLast> Curry<T1, T2, TLast>(this Action<T1, T2, TLast> action,
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
        T1 t1, T2 t2) => last => action(t1, t2, last);
    public static Action<TLast> Curry<T1, T2, T3, TLast>(this Action<T1, T2, T3, TLast> action,
        T1 t1, T2 t2, T3 t3) => last => action(t1, t2, t3, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<TLast> Curry<T1, T2, T3, T4, TLast>(this Action<T1, T2, T3, T4, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4) => last => action(t1, t2, t3, t4, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<TLast> Curry<T1, T2, T3, T4, T5, TLast>(this Action<T1, T2, T3, T4, T5, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => last => action(t1, t2, t3, t4, t5, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<TLast> Curry<T1, T2, T3, T4, T5, T6, TLast>(this Action<T1, T2, T3, T4, T5, T6, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => last => action(t1, t2, t3, t4, t5, t6, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<TLast> Curry<T1, T2, T3, T4, T5, T6, T7, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => last => action(t1, t2, t3, t4, t5, t6, t7, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => last => action(t1, t2, t3, t4, t5, t6, t7, t8, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) => last => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) => last => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) => last => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) => last => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) => last => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) => last => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) => last => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);

    #endregion Curry Action

    #region Curry Action Last 2 args

    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T2, TLast> Curry<T1, T2, TLast>(this Action<T1, T2, TLast> action,
        T1 t1) => (t2, last) => action(t1, t2, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T3, TLast> Curry<T1, T2, T3, TLast>(this Action<T1, T2, T3, TLast> action,
        T1 t1, T2 t2) => (t3, last) => action(t1, t2, t3, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T4, TLast> Curry<T1, T2, T3, T4, TLast>(this Action<T1, T2, T3, T4, TLast> action,
        T1 t1, T2 t2, T3 t3) => (t4, last) => action(t1, t2, t3, t4, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T5, TLast> Curry<T1, T2, T3, T4, T5, TLast>(this Action<T1, T2, T3, T4, T5, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4) => (t5, last) => action(t1, t2, t3, t4, t5, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T6, TLast> Curry<T1, T2, T3, T4, T5, T6, TLast>(this Action<T1, T2, T3, T4, T5, T6, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, last) => action(t1, t2, t3, t4, t5, t6, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T7, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, last) => action(t1, t2, t3, t4, t5, t6, t7, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T8, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => (t8, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T9, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => (t9, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T10, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) => (t10, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T11, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) => (t11, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T12, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) => (t12, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T13, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) => (t13, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T14, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) => (t14, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T15, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) => (t15, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);

    #endregion Curry Action

    #region Curry Action Last 3 args
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T2, T3, TLast> Curry<T1, T2, T3, TLast>(this Action<T1, T2, T3, TLast> action,
        T1 t1) => (t2, t3, last) => action(t1, t2, t3, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T3, T4, TLast> Curry<T1, T2, T3, T4, TLast>(this Action<T1, T2, T3, T4, TLast> action,
        T1 t1, T2 t2) => (t3, t4, last) => action(t1, t2, t3, t4, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T4, T5, TLast> Curry<T1, T2, T3, T4, T5, TLast>(this Action<T1, T2, T3, T4, T5, TLast> action,
        T1 t1, T2 t2, T3 t3) => (t4, t5, last) => action(t1, t2, t3, t4, t5, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T5, T6, TLast> Curry<T1, T2, T3, T4, T5, T6, TLast>(this Action<T1, T2, T3, T4, T5, T6, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, last) => action(t1, t2, t3, t4, t5, t6, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T6, T7, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, last) => action(t1, t2, t3, t4, t5, t6, t7, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T7, T8, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, t8, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T8, T9, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => (t8, t9, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T9, T10, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => (t9, t10, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T10, T11, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) => (t10, t11, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T11, T12, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) => (t11, t12, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T12, T13, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) => (t12, t13, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T13, T14, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) => (t13, t14, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T14, T15, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) => (t14, t15, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    #endregion

    #region Curry Action Last 4 args
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T2, T3, T4, TLast> Curry<T1, T2, T3, T4, TLast>(this Action<T1, T2, T3, T4, TLast> action,
        T1 t1) => (t2, t3, t4, last) => action(t1, t2, t3, t4, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T3, T4, T5, TLast> Curry<T1, T2, T3, T4, T5, TLast>(this Action<T1, T2, T3, T4, T5, TLast> action,
        T1 t1, T2 t2) => (t3, t4, t5, last) => action(t1, t2, t3, t4, t5, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T4, T5, T6, TLast> Curry<T1, T2, T3, T4, T5, T6, TLast>(this Action<T1, T2, T3, T4, T5, T6, TLast> action,
        T1 t1, T2 t2, T3 t3) => (t4, t5, t6, last) => action(t1, t2, t3, t4, t5, t6, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T5, T6, T7, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, last) => action(t1, t2, t3, t4, t5, t6, t7, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T6, T7, T8, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, t8, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T7, T8, T9, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, t8, t9, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T8, T9, T10, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => (t8, t9, t10, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T9, T10, T11, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => (t9, t10, t11, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T10, T11, T12, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) => (t10, t11, t12, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T11, T12, T13, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) => (t11, t12, t13, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T12, T13, T14, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) => (t12, t13, t14, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T13, T14, T15, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) => (t13, t14, t15, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    #endregion

    #region Curry Action Last 5 args
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T2, T3, T4, T5, TLast> Curry<T1, T2, T3, T4, T5, TLast>(this Action<T1, T2, T3, T4, T5, TLast> action,
        T1 t1) => (t2, t3, t4, t5, last) => action(t1, t2, t3, t4, t5, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T3, T4, T5, T6, TLast> Curry<T1, T2, T3, T4, T5, T6, TLast>(this Action<T1, T2, T3, T4, T5, T6, TLast> action,
        T1 t1, T2 t2) => (t3, t4, t5, t6, last) => action(t1, t2, t3, t4, t5, t6, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T4, T5, T6, T7, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, TLast> action,
        T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, last) => action(t1, t2, t3, t4, t5, t6, t7, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T5, T6, T7, T8, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, t8, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T6, T7, T8, T9, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, t8, t9, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T7, T8, T9, T10, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, t8, t9, t10, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T8, T9, T10, T11, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => (t8, t9, t10, t11, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T9, T10, T11, T12, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => (t9, t10, t11, t12, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T10, T11, T12, T13, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) => (t10, t11, t12, t13, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T11, T12, T13, T14, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) => (t11, t12, t13, t14, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T12, T13, T14, T15, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) => (t12, t13, t14, t15, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    #endregion

    #region Curry Action Last 6 args
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T2, T3, T4, T5, T6, TLast> Curry<T1, T2, T3, T4, T5, T6, TLast>(this Action<T1, T2, T3, T4, T5, T6, TLast> action,
        T1 t1) => (t2, t3, t4, t5, t6, last) => action(t1, t2, t3, t4, t5, t6, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T3, T4, T5, T6, T7, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, TLast> action,
        T1 t1, T2 t2) => (t3, t4, t5, t6, t7, last) => action(t1, t2, t3, t4, t5, t6, t7, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T4, T5, T6, T7, T8, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, TLast> action,
        T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, t8, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T5, T6, T7, T8, T9, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, t8, t9, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T6, T7, T8, T9, T10, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, t8, t9, t10, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T7, T8, T9, T10, T11, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, t8, t9, t10, t11, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T8, T9, T10, T11, T12, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => (t8, t9, t10, t11, t12, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T9, T10, T11, T12, T13, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => (t9, t10, t11, t12, t13, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T10, T11, T12, T13, T14, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) => (t10, t11, t12, t13, t14, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T11, T12, T13, T14, T15, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) => (t11, t12, t13, t14, t15, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    #endregion

    #region Curry Action Last 7 args
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T2, T3, T4, T5, T6, T7, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, TLast> action,
        T1 t1) => (t2, t3, t4, t5, t6, t7, last) => action(t1, t2, t3, t4, t5, t6, t7, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T3, T4, T5, T6, T7, T8, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, TLast> action,
        T1 t1, T2 t2) => (t3, t4, t5, t6, t7, t8, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T4, T5, T6, T7, T8, T9, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast> action,
        T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, t8, t9, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T5, T6, T7, T8, T9, T10, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, t8, t9, t10, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T6, T7, T8, T9, T10, T11, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, t8, t9, t10, t11, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T7, T8, T9, T10, T11, T12, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, t8, t9, t10, t11, t12, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T8, T9, T10, T11, T12, T13, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => (t8, t9, t10, t11, t12, t13, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T9, T10, T11, T12, T13, T14, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => (t9, t10, t11, t12, t13, t14, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T10, T11, T12, T13, T14, T15, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) => (t10, t11, t12, t13, t14, t15, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    #endregion

    #region Curry Action Last 8 args
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T2, T3, T4, T5, T6, T7, T8, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, TLast> action,
        T1 t1) => (t2, t3, t4, t5, t6, t7, t8, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T3, T4, T5, T6, T7, T8, T9, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast> action,
        T1 t1, T2 t2) => (t3, t4, t5, t6, t7, t8, t9, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T4, T5, T6, T7, T8, T9, T10, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast> action,
        T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, t8, t9, t10, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T5, T6, T7, T8, T9, T10, T11, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, t8, t9, t10, t11, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T6, T7, T8, T9, T10, T11, T12, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, t8, t9, t10, t11, t12, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T7, T8, T9, T10, T11, T12, T13, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, t8, t9, t10, t11, t12, t13, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T8, T9, T10, T11, T12, T13, T14, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => (t8, t9, t10, t11, t12, t13, t14, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T9, T10, T11, T12, T13, T14, T15, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => (t9, t10, t11, t12, t13, t14, t15, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    #endregion

    #region Curry Action Last 9 args
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T2, T3, T4, T5, T6, T7, T8, T9, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast> action,
        T1 t1) => (t2, t3, t4, t5, t6, t7, t8, t9, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T3, T4, T5, T6, T7, T8, T9, T10, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast> action,
        T1 t1, T2 t2) => (t3, t4, t5, t6, t7, t8, t9, t10, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T4, T5, T6, T7, T8, T9, T10, T11, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast> action,
        T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, t8, t9, t10, t11, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T5, T6, T7, T8, T9, T10, T11, T12, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, t8, t9, t10, t11, t12, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T6, T7, T8, T9, T10, T11, T12, T13, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, t8, t9, t10, t11, t12, t13, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T7, T8, T9, T10, T11, T12, T13, T14, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, t8, t9, t10, t11, t12, t13, t14, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T8, T9, T10, T11, T12, T13, T14, T15, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => (t8, t9, t10, t11, t12, t13, t14, t15, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    #endregion

    #region Curry Action Last 10 args
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast> action,
        T1 t1) => (t2, t3, t4, t5, t6, t7, t8, t9, t10, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast> action,
        T1 t1, T2 t2) => (t3, t4, t5, t6, t7, t8, t9, t10, t11, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast> action,
        T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, t8, t9, t10, t11, t12, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, t8, t9, t10, t11, t12, t13, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, t8, t9, t10, t11, t12, t13, t14, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, t8, t9, t10, t11, t12, t13, t14, t15, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    #endregion

    #region Curry Action Last 11 args
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast> action,
            T1 t1) => (t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast> action,
        T1 t1, T2 t2) => (t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast> action,
        T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    #endregion

    #region Curry Action Last 12 args
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast> action,
        T1 t1) => (t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast> action,
        T1 t1, T2 t2) => (t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast> action,
        T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    #endregion

    #region Curry Action Last 13 args
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast> action,
            T1 t1) => (t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast> action,
        T1 t1, T2 t2) => (t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast> action,
        T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    #endregion

    #region Curry Action Last 14 args
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast> action,
        T1 t1) => (t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast> action,
        T1 t1, T2 t2) => (t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    #endregion

    #region Curry Action Last 15 args
    /// <summary>
    /// Makes a given <paramref name="action"/> delegate 'curried'.
    /// </summary>
    /// <param name="action">Action delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast> action,
        T1 t1) => (t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last) => action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    #endregion

    #region Curry Func Last arg

    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<TResult> Curry<TLast, TResult>(this Func<TLast, TResult> func, TLast last) => () => func(last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<TLast, TResult> Curry<T1, TLast, TResult>(this Func<T1, TLast, TResult> func,
        T1 t1) => last => func(t1, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<TLast, TResult> Curry<T1, T2, TLast, TResult>(this Func<T1, T2, TLast, TResult> func,
        T1 t1, T2 t2) => last => func(t1, t2, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<TLast, TResult> Curry<T1, T2, T3, TLast, TResult>(this Func<T1, T2, T3, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3) => last => func(t1, t2, t3, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<TLast, TResult> Curry<T1, T2, T3, T4, TLast, TResult>(this Func<T1, T2, T3, T4, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4) => last => func(t1, t2, t3, t4, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<TLast, TResult> Curry<T1, T2, T3, T4, T5, TLast, TResult>(this Func<T1, T2, T3, T4, T5, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => last => func(t1, t2, t3, t4, t5, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => last => func(t1, t2, t3, t4, t5, t6, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => last => func(t1, t2, t3, t4, t5, t6, t7, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => last => func(t1, t2, t3, t4, t5, t6, t7, t8, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) => last => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) => last => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) => last => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) => last => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) => last => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) => last => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) => last => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);

    #endregion Curry

    #region Curry Func Last 2 args

    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T1, TLast, TResult> Curry<T1, TLast, TResult>(this Func<T1, TLast, TResult> func) => (t1, last) => func(t1, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T2, TLast, TResult> Curry<T1, T2, TLast, TResult>(this Func<T1, T2, TLast, TResult> func,
        T1 t1) => (t2, last) => func(t1, t2, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T3, TLast, TResult> Curry<T1, T2, T3, TLast, TResult>(this Func<T1, T2, T3, TLast, TResult> func,
        T1 t1, T2 t2) => (t3, last) => func(t1, t2, t3, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T4, TLast, TResult> Curry<T1, T2, T3, T4, TLast, TResult>(this Func<T1, T2, T3, T4, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3) => (t4, last) => func(t1, t2, t3, t4, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T5, TLast, TResult> Curry<T1, T2, T3, T4, T5, TLast, TResult>(this Func<T1, T2, T3, T4, T5, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4) => (t5, last) => func(t1, t2, t3, t4, t5, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T6, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, last) => func(t1, t2, t3, t4, t5, t6, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T7, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, last) => func(t1, t2, t3, t4, t5, t6, t7, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T8, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => (t8, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T9, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => (t9, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T10, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) => (t10, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T11, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) => (t11, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T12, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) => (t12, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T13, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) => (t13, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T14, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) => (t14, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T15, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) => (t15, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);

    #endregion Curry Func

    #region Curry Func Last 3 args
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T2, T3, TLast, TResult> Curry<T1, T2, T3, TLast, TResult>(this Func<T1, T2, T3, TLast, TResult> func,
        T1 t1) => (t2, t3, last) => func(t1, t2, t3, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T3, T4, TLast, TResult> Curry<T1, T2, T3, T4, TLast, TResult>(this Func<T1, T2, T3, T4, TLast, TResult> func,
        T1 t1, T2 t2) => (t3, t4, last) => func(t1, t2, t3, t4, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T4, T5, TLast, TResult> Curry<T1, T2, T3, T4, T5, TLast, TResult>(this Func<T1, T2, T3, T4, T5, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3) => (t4, t5, last) => func(t1, t2, t3, t4, t5, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T5, T6, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, last) => func(t1, t2, t3, t4, t5, t6, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T6, T7, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, last) => func(t1, t2, t3, t4, t5, t6, t7, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T7, T8, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, t8, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T8, T9, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => (t8, t9, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T9, T10, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => (t9, t10, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T10, T11, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) => (t10, t11, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T11, T12, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) => (t11, t12, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T12, T13, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) => (t12, t13, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T13, T14, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) => (t13, t14, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T14, T15, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) => (t14, t15, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    #endregion

    #region Curry Func Last 4 args
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T2, T3, T4, TLast, TResult> Curry<T1, T2, T3, T4, TLast, TResult>(this Func<T1, T2, T3, T4, TLast, TResult> func,
        T1 t1) => (t2, t3, t4, last) => func(t1, t2, t3, t4, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T3, T4, T5, TLast, TResult> Curry<T1, T2, T3, T4, T5, TLast, TResult>(this Func<T1, T2, T3, T4, T5, TLast, TResult> func,
        T1 t1, T2 t2) => (t3, t4, t5, last) => func(t1, t2, t3, t4, t5, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T4, T5, T6, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3) => (t4, t5, t6, last) => func(t1, t2, t3, t4, t5, t6, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T5, T6, T7, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, last) => func(t1, t2, t3, t4, t5, t6, t7, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T6, T7, T8, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, t8, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T7, T8, T9, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, t8, t9, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T8, T9, T10, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => (t8, t9, t10, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T9, T10, T11, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => (t9, t10, t11, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T10, T11, T12, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) => (t10, t11, t12, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T11, T12, T13, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) => (t11, t12, t13, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T12, T13, T14, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) => (t12, t13, t14, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T13, T14, T15, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) => (t13, t14, t15, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    #endregion

    #region Curry Func Last 5 args
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T2, T3, T4, T5, TLast, TResult> Curry<T1, T2, T3, T4, T5, TLast, TResult>(this Func<T1, T2, T3, T4, T5, TLast, TResult> func,
        T1 t1) => (t2, t3, t4, t5, last) => func(t1, t2, t3, t4, t5, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T3, T4, T5, T6, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, TLast, TResult> func,
        T1 t1, T2 t2) => (t3, t4, t5, t6, last) => func(t1, t2, t3, t4, t5, t6, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T4, T5, T6, T7, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, last) => func(t1, t2, t3, t4, t5, t6, t7, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T5, T6, T7, T8, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, t8, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T6, T7, T8, T9, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, t8, t9, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T7, T8, T9, T10, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, t8, t9, t10, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T8, T9, T10, T11, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => (t8, t9, t10, t11, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T9, T10, T11, T12, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => (t9, t10, t11, t12, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T10, T11, T12, T13, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) => (t10, t11, t12, t13, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T11, T12, T13, T14, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) => (t11, t12, t13, t14, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T12, T13, T14, T15, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) => (t12, t13, t14, t15, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    #endregion

    #region Curry Func Last 6 args
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T2, T3, T4, T5, T6, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, TLast, TResult> func,
        T1 t1) => (t2, t3, t4, t5, t6, last) => func(t1, t2, t3, t4, t5, t6, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T3, T4, T5, T6, T7, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TLast, TResult> func,
        T1 t1, T2 t2) => (t3, t4, t5, t6, t7, last) => func(t1, t2, t3, t4, t5, t6, t7, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T4, T5, T6, T7, T8, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, t8, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T5, T6, T7, T8, T9, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, t8, t9, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T6, T7, T8, T9, T10, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, t8, t9, t10, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T7, T8, T9, T10, T11, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, t8, t9, t10, t11, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T8, T9, T10, T11, T12, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => (t8, t9, t10, t11, t12, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T9, T10, T11, T12, T13, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => (t9, t10, t11, t12, t13, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T10, T11, T12, T13, T14, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) => (t10, t11, t12, t13, t14, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T11, T12, T13, T14, T15, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) => (t11, t12, t13, t14, t15, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    #endregion

    #region Curry Func Last 7 args
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T2, T3, T4, T5, T6, T7, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TLast, TResult> func,
        T1 t1) => (t2, t3, t4, t5, t6, t7, last) => func(t1, t2, t3, t4, t5, t6, t7, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T3, T4, T5, T6, T7, T8, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TLast, TResult> func,
        T1 t1, T2 t2) => (t3, t4, t5, t6, t7, t8, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T4, T5, T6, T7, T8, T9, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, t8, t9, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T5, T6, T7, T8, T9, T10, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, t8, t9, t10, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T6, T7, T8, T9, T10, T11, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, t8, t9, t10, t11, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T7, T8, T9, T10, T11, T12, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, t8, t9, t10, t11, t12, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T8, T9, T10, T11, T12, T13, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => (t8, t9, t10, t11, t12, t13, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T9, T10, T11, T12, T13, T14, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => (t9, t10, t11, t12, t13, t14, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T10, T11, T12, T13, T14, T15, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) => (t10, t11, t12, t13, t14, t15, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    #endregion

    #region Curry Func Last 8 args
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T2, T3, T4, T5, T6, T7, T8, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TLast, TResult> func,
        T1 t1) => (t2, t3, t4, t5, t6, t7, t8, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T3, T4, T5, T6, T7, T8, T9, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult> func,
        T1 t1, T2 t2) => (t3, t4, t5, t6, t7, t8, t9, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T4, T5, T6, T7, T8, T9, T10, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, t8, t9, t10, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T5, T6, T7, T8, T9, T10, T11, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, t8, t9, t10, t11, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T6, T7, T8, T9, T10, T11, T12, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, t8, t9, t10, t11, t12, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T7, T8, T9, T10, T11, T12, T13, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, t8, t9, t10, t11, t12, t13, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T8, T9, T10, T11, T12, T13, T14, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => (t8, t9, t10, t11, t12, t13, t14, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T9, T10, T11, T12, T13, T14, T15, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => (t9, t10, t11, t12, t13, t14, t15, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    #endregion

    #region Curry Func Last 9 args
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult> func,
        T1 t1) => (t2, t3, t4, t5, t6, t7, t8, t9, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult> func,
        T1 t1, T2 t2) => (t3, t4, t5, t6, t7, t8, t9, t10, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, t8, t9, t10, t11, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, t8, t9, t10, t11, t12, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, t8, t9, t10, t11, t12, t13, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, t8, t9, t10, t11, t12, t13, t14, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => (t8, t9, t10, t11, t12, t13, t14, t15, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    #endregion

    #region Curry Func Last 10 args
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult> func,
        T1 t1) => (t2, t3, t4, t5, t6, t7, t8, t9, t10, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult> func,
        T1 t1, T2 t2) => (t3, t4, t5, t6, t7, t8, t9, t10, t11, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, t8, t9, t10, t11, t12, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, t8, t9, t10, t11, t12, t13, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, t8, t9, t10, t11, t12, t13, t14, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => (t7, t8, t9, t10, t11, t12, t13, t14, t15, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    #endregion

    #region Curry Func Last 11 args
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult> func,
            T1 t1) => (t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult> func,
        T1 t1, T2 t2) => (t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => (t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    #endregion

    #region Curry Func Last 12 args
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult> func,
        T1 t1) => (t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult> func,
        T1 t1, T2 t2) => (t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4) => (t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    #endregion

    #region Curry Func Last 13 args
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult> func,
            T1 t1) => (t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult> func,
        T1 t1, T2 t2) => (t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3) => (t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    #endregion

    #region Curry Func Last 14 args
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult> func,
        T1 t1) => (t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult> func,
        T1 t1, T2 t2) => (t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    #endregion

    #region Curry Func Last 15 args
    /// <summary>
    /// Makes a given <paramref name="func"/> delegate 'curried'.
    /// </summary>
    /// <param name="func">Func delegate to be 'curried'/</param>
    /// <returns>Returns 'curried' delegate.</returns>
    public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult> func,
        T1 t1) => (t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last) => func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    #endregion

}
