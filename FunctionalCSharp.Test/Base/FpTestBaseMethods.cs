namespace FunctionalCSharp.Test;

internal abstract partial class FpTestBase
{
    #region Action methods to make delegates from

    public void ActionMethod() => AssertActionMethod();
    public void ActionMethod<T1>(T1 t1) => AssertActionMethod(t1);
    public void ActionMethod<T1, T2>(T1 t1, T2 t2) => AssertActionMethod(t1, t2);
    public void ActionMethod<T1, T2, T3>(T1 t1, T2 t2, T3 t3) => AssertActionMethod(t1, t2, t3);
    public void ActionMethod<T1, T2, T3, T4>(T1 t1, T2 t2, T3 t3, T4 t4) => AssertActionMethod(t1, t2, t3, t4);
    public void ActionMethod<T1, T2, T3, T4, T5>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => AssertActionMethod(t1, t2, t3, t4, t5);
    public void ActionMethod<T1, T2, T3, T4, T5, T6>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6) => AssertActionMethod(t1, t2, t3, t4, t5, t6);
    public void ActionMethod<T1, T2, T3, T4, T5, T6, T7>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7) => AssertActionMethod(t1, t2, t3, t4, t5, t6, t7);
    public void ActionMethod<T1, T2, T3, T4, T5, T6, T7, T8>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8) => AssertActionMethod(t1, t2, t3, t4, t5, t6, t7, t8);
    public void ActionMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9) => AssertActionMethod(t1, t2, t3, t4, t5, t6, t7, t8, t9);
    public void ActionMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10) => AssertActionMethod(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
    public void ActionMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11) => AssertActionMethod(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
    public void ActionMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12) => AssertActionMethod(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
    public void ActionMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13) => AssertActionMethod(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
    public void ActionMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14) => AssertActionMethod(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
    public void ActionMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15) => AssertActionMethod(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
    public void ActionMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16) => AssertActionMethod(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);

    #endregion

    #region Func methods to make delegates from

    public R FuncMethod<T1, R>(T1 t1) => AssertFuncMethod<R>(t1);
    public R FuncMethod<T1, T2, R>(
        T1 t1, T2 t2)
        => AssertFuncMethod<R>(t1, t2);
    public R FuncMethod<T1, T2, T3, R>(
        T1 t1, T2 t2, T3 t3)
        => AssertFuncMethod<R>(t1, t2, t3);
    public R FuncMethod<T1, T2, T3, T4, R>(
        T1 t1, T2 t2, T3 t3, T4 t4)
        => AssertFuncMethod<R>(t1, t2, t3, t4);
    public R FuncMethod<T1, T2, T3, T4, T5, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        => AssertFuncMethod<R>(t1, t2, t3, t4, t5);
    public R FuncMethod<T1, T2, T3, T4, T5, T6, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6)
        => AssertFuncMethod<R>(t1, t2, t3, t4, t5, t6);
    public R FuncMethod<T1, T2, T3, T4, T5, T6, T7, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7)
        => AssertFuncMethod<R>(t1, t2, t3, t4, t5, t6, t7);
    public R FuncMethod<T1, T2, T3, T4, T5, T6, T7, T8, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8)
        => AssertFuncMethod<R>(t1, t2, t3, t4, t5, t6, t7, t8);
    public R FuncMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9)
        => AssertFuncMethod<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9);
    public R FuncMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10)
        => AssertFuncMethod<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
    public R FuncMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11)
        => AssertFuncMethod<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
    public R FuncMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12)
        => AssertFuncMethod<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
    public R FuncMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13)
        => AssertFuncMethod<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
    public R FuncMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14)
        => AssertFuncMethod<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
    public R FuncMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15)
        => AssertFuncMethod<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
    public R FuncMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16)
        => AssertFuncMethod<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);

    public R FuncMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18)
        => AssertFuncMethod<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18);

    public R FuncMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20)
        => AssertFuncMethod<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20);

    public R FuncMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22)
        => AssertFuncMethod<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22);

    public R FuncMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24)
        => AssertFuncMethod<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24);

    public R FuncMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26)
        => AssertFuncMethod<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26);

    public R FuncMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28)
        => AssertFuncMethod<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28);

    public R FuncMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30)
        => AssertFuncMethod<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30);

    public R FuncMethod<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31, T32, R>(
        T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16,
        T17 t17, T18 t18, T19 t19, T20 t20, T21 t21, T22 t22, T23 t23, T24 t24, T25 t25, T26 t26, T27 t27, T28 t28, T29 t29, T30 t30, T31 t31, T32 t32)
        => AssertFuncMethod<R>(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24, t25, t26, t27, t28, t29, t30, t31, t32);

    #endregion

}
