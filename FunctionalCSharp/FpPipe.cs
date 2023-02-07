﻿namespace FunctionalCSharp;

public static partial class Fp
{

    #region Into (PipeForward) Action

    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="action">Delegate which receives pipe'd value.</param>
    public static void Into<TLast>(this TLast last, 
        Action<TLast> action)
    {
        action(last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="action">Delegate which receives pipe'd value.</param>
    public static void Into<T1, TLast>(this TLast last, 
        Action<T1, TLast> action,
        T1 t1)
    {
        action(t1, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="action">Delegate which receives pipe'd value.</param>
    public static void Into<T1, T2, TLast>(this TLast last, 
        Action<T1, T2, TLast> action,
        T1 t1, T2 t2)
    {
        action(t1, t2, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="action">Delegate which receives pipe'd value.</param>
    public static void Into<T1, T2, T3, TLast>(this TLast last, 
        Action<T1, T2, T3, TLast> action,
        T1 t1, T2 t2, T3 t3)
    {
        action(t1, t2, t3, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="action">Delegate which receives pipe'd value.</param>
    public static void Into<T1, T2, T3, T4, TLast>(this TLast last, 
        Action<T1, T2, T3, T4, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4)
    {
        action(t1, t2, t3, t4, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="action">Delegate which receives pipe'd value.</param>
    public static void Into<T1, T2, T3, T4, T5, TLast>(this TLast last, 
        Action<T1, T2, T3, T4, T5, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
    {
        action(t1, t2, t3, t4, t5, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="action">Delegate which receives pipe'd value.</param>
    public static void Into<T1, T2, T3, T4, T5, T6, TLast>(this TLast last, 
        Action<T1, T2, T3, T4, T5, T6, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
    {
        action(t1, t2, t3, t4, t5, t6, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="action">Delegate which receives pipe'd value.</param>
    public static void Into<T1, T2, T3, T4, T5, T6, T7, TLast>(this TLast last, 
        Action<T1, T2, T3, T4, T5, T6, T7, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
    {
        action(t1, t2, t3, t4, t5, t6, t7, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="action">Delegate which receives pipe'd value.</param>
    public static void Into<T1, T2, T3, T4, T5, T6, T7, T8, TLast>(this TLast last, 
        Action<T1, T2, T3, T4, T5, T6, T7, T8, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
    {
        action(t1, t2, t3, t4, t5, t6, t7, t8, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="action">Delegate which receives pipe'd value.</param>
    public static void Into<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast>(this TLast last, 
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
    {
        action(t1, t2, t3, t4, t5, t6, t7, t8, t9, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="action">Delegate which receives pipe'd value.</param>
    public static void Into<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast>(this TLast last, 
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
    {
        action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="action">Delegate which receives pipe'd value.</param>
    public static void Into<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast>(this TLast last, 
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
    {
        action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="action">Delegate which receives pipe'd value.</param>
    public static void Into<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast>(this TLast last, 
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
    {
        action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="action">Delegate which receives pipe'd value.</param>
    public static void Into<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast>(this TLast last, 
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
    {
        action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="action">Delegate which receives pipe'd value.</param>
    public static void Into<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast>(this TLast last, 
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
    {
        action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="action">Delegate which receives pipe'd value.</param>
    public static void Into<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast>(this TLast last, 
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast> action,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
    {
        action(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    }
    #endregion Into Action

    #region Into (PipeForward) Func

    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into<TLast, TResult>(this TLast last,
        Func<TLast, TResult> func)
    {
        return func(last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into<T1, TLast, TResult>(this TLast last, 
        Func<T1, TLast, TResult> func,
        T1 t1)
    {
        return func(t1, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into<T1, T2, TLast, TResult>(this TLast last, 
        Func<T1, T2, TLast, TResult> func,
        T1 t1, T2 t2)
    {
        return func(t1, t2, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into<T1, T2, T3, TLast, TResult>(this TLast last, 
        Func<T1, T2, T3, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3)
    {
        return func(t1, t2, t3, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into<T1, T2, T3, T4, TLast, TResult>(this TLast last, 
        Func<T1, T2, T3, T4, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4)
    {
        return func(t1, t2, t3, t4, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into<T1, T2, T3, T4, T5, TLast, TResult>(this TLast last, 
        Func<T1, T2, T3, T4, T5, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
    {
        return func(t1, t2, t3, t4, t5, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into<T1, T2, T3, T4, T5, T6, TLast, TResult>(this TLast last, 
        Func<T1, T2, T3, T4, T5, T6, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
    {
        return func(t1, t2, t3, t4, t5, t6, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into<T1, T2, T3, T4, T5, T6, T7, TLast, TResult>(this TLast last,
        Func<T1, T2, T3, T4, T5, T6, T7, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
    {
        return func(t1, t2, t3, t4, t5, t6, t7, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into<T1, T2, T3, T4, T5, T6, T7, T8, TLast, TResult>(this TLast last, 
        Func<T1, T2, T3, T4, T5, T6, T7, T8, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
    {
        return func(t1, t2, t3, t4, t5, t6, t7, t8, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult>(this TLast last,
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
    {
        return func(t1, t2, t3, t4, t5, t6, t7, t8, t9, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult>(this TLast last, 
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
    {
        return func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult>(this TLast last, 
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
    {
        return func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult>(this TLast last, 
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
    {
        return func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult>(this TLast last, 
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
    {
        return func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult>(this TLast last, 
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
    {
        return func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, last);
    }
    /// <summary>
    /// F#-like (|>) pipe function.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult>(this TLast last, 
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TLast, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
    {
        return func(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, last);
    }
    #endregion Into

    #region Into1 (PipeForward) Func

    /// <summary>
    /// F#-like (|>) pipe function which pipes provided value to the first argument.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into1<TFirst, T1, TResult>(this TFirst first, 
        Func<TFirst, T1, TResult> func,
        T1 t1)
    {
        return func(first, t1);
    }
    /// <summary>
    /// F#-like (|>) pipe function which pipes provided value to the first argument.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into1<TFirst, T1, T2, TResult>(this TFirst first, 
        Func<TFirst, T1, T2, TResult> func,
        T1 t1, T2 t2)
    {
        return func(first, t1, t2);
    }
    /// <summary>
    /// F#-like (|>) pipe function which pipes provided value to the first argument.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into1<TFirst, T1, T2, T3, TResult>(this TFirst first, 
        Func<TFirst, T1, T2, T3, TResult> func,
        T1 t1, T2 t2, T3 t3)
    {
        return func(first, t1, t2, t3);
    }
    /// <summary>
    /// F#-like (|>) pipe function which pipes provided value to the first argument.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into1<TFirst, T1, T2, T3, T4, TResult>(this TFirst first, 
        Func<TFirst, T1, T2, T3, T4, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4)
    {
        return func(first, t1, t2, t3, t4);
    }
    /// <summary>
    /// F#-like (|>) pipe function which pipes provided value to the first argument.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into1<TFirst, T1, T2, T3, T4, T5, TResult>(this TFirst first, 
        Func<TFirst, T1, T2, T3, T4, T5, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
    {
        return func(first, t1, t2, t3, t4, t5);
    }
    /// <summary>
    /// F#-like (|>) pipe function which pipes provided value to the first argument.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into1<TFirst, T1, T2, T3, T4, T5, T6, TResult>(this TFirst first, 
        Func<TFirst, T1, T2, T3, T4, T5, T6, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
    {
        return func(first, t1, t2, t3, t4, t5, t6);
    }
    /// <summary>
    /// F#-like (|>) pipe function which pipes provided value to the first argument.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into1<TFirst, T1, T2, T3, T4, T5, T6, T7, TResult>(this TFirst first, 
        Func<TFirst, T1, T2, T3, T4, T5, T6, T7, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
    {
        return func(first, t1, t2, t3, t4, t5, t6, t7);
    }
    /// <summary>
    /// F#-like (|>) pipe function which pipes provided value to the first argument.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into1<TFirst, T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this TFirst first, 
        Func<TFirst, T1, T2, T3, T4, T5, T6, T7, T8, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
    {
        return func(first, t1, t2, t3, t4, t5, t6, t7, t8);
    }
    /// <summary>
    /// F#-like (|>) pipe function which pipes provided value to the first argument.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into1<TFirst, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this TFirst first, 
        Func<TFirst, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
    {
        return func(first, t1, t2, t3, t4, t5, t6, t7, t8, t9);
    }
    /// <summary>
    /// F#-like (|>) pipe function which pipes provided value to the first argument.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into1<TFirst, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this TFirst first, 
        Func<TFirst, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
    {
        return func(first, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
    }
    /// <summary>
    /// F#-like (|>) pipe function which pipes provided value to the first argument.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into1<TFirst, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this TFirst first, 
        Func<TFirst, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
    {
        return func(first, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
    }
    /// <summary>
    /// F#-like (|>) pipe function which pipes provided value to the first argument.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into1<TFirst, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this TFirst first, 
        Func<TFirst, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
    {
        return func(first, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
    }
    /// <summary>
    /// F#-like (|>) pipe function which pipes provided value to the first argument.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into1<TFirst, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this TFirst first, 
        Func<TFirst, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
    {
        return func(first, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
    }
    /// <summary>
    /// F#-like (|>) pipe function which pipes provided value to the first argument.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into1<TFirst, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this TFirst first, 
        Func<TFirst, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
    {
        return func(first, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
    }
    /// <summary>
    /// F#-like (|>) pipe function which pipes provided value to the first argument.
    /// </summary>
    /// <param name="func">Delegate which receives pipe'd value.</param>
    public static TResult Into1<TFirst, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this TFirst first, 
        Func<TFirst, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func,
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
    {
        return func(first, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
    }
    #endregion Into1

}