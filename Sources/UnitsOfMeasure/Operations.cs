using System.Numerics;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UnitsOfMeasure;

/// <summary>
/// Provides extension methods for performing arithmetic operations like addition, subtraction, and square root on units of measurement.
/// </summary>
public static class Ops {
    /// <summary>
    /// Performs addition between two units of measurement.
    /// </summary>
    /// <typeparam name="T1">The type of the first unit.</typeparam>
    /// <typeparam name="T2">The type of the second unit.</typeparam>
    /// <typeparam name="TBase">The base type of both units.</typeparam>
    /// <typeparam name="TNumber">The type of the numeric value associated with the units.</typeparam>
    /// <param name="a">The first unit of measurement.</param>
    /// <param name="b">The second unit of measurement.</param>
    /// <returns>A new unit representing the addition result.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Unit<T1, TBase, TNumber>
        Add<T1, T2, TBase, TNumber>(this Unit<T1, TBase, TNumber> a, Unit<T2, TBase, TNumber> b)
        where TBase : struct, IBaseUnit<TBase, TNumber>
        where T1 : struct, IBaseUnit<TBase, TNumber>
        where T2 : struct, IBaseUnit<TBase, TNumber>
        where TNumber : IDivisionOperators<TNumber, TNumber, TNumber>,
            IAdditionOperators<TNumber, TNumber, TNumber>,
            IMultiplyOperators<TNumber, TNumber, TNumber>
        =>
            typeof(T1) == typeof(T2)
            ? new(a.Float + b.Float)
            : new((a.Float * new T1().Base + b.Float * new T2().Base) / new T1().Base);

    /// <summary>
    /// Subtracts two units of measurement represented by the given units.
    /// </summary>
    /// <typeparam name="T1">The type of the first unit of measurement.</typeparam>
    /// <typeparam name="T2">The type of the second unit of measurement.</typeparam>
    /// <typeparam name="TBase">The base unit type for both units of measurement.</typeparam>
    /// <typeparam name="TNumber">The numeric type used for the values of the units of measurement.</typeparam>
    /// <param name="a">The first unit of measurement to subtract from.</param>
    /// <param name="b">The second unit of measurement to subtract.</param>
    /// <returns>A new unit of measurement representing the result of the subtraction.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Unit<T1, TBase, TNumber>
        Subtract<T1, T2, TBase, TNumber>(this Unit<T1, TBase, TNumber> a, Unit<T2, TBase, TNumber> b)
        where TBase : struct, IBaseUnit<TBase, TNumber>
        where T1 : struct, IBaseUnit<TBase, TNumber>
        where T2 : struct, IBaseUnit<TBase, TNumber>
        where TNumber : IDivisionOperators<TNumber, TNumber, TNumber>,
            ISubtractionOperators<TNumber, TNumber, TNumber>,
            IMultiplyOperators<TNumber, TNumber, TNumber>
        =>
            typeof(T1) == typeof(T2)
            ? new(a.Float - b.Float)
            : new((a.Float * new T1().Base - b.Float * new T2().Base) / new T1().Base);

    /// <summary>
    /// Multiplies two units of measurement by multiplying their respective float values.
    /// </summary>
    /// <typeparam name="T1">The first unit of measurement.</typeparam>
    /// <typeparam name="T2">The second unit of measurement.</typeparam>
    /// <typeparam name="T1Base">The base unit type for the first unit.</typeparam>
    /// <typeparam name="T2Base">The base unit type for the second unit.</typeparam>
    /// <typeparam name="TNumber">The type of number used for the units.</typeparam>
    /// <param name="a">The first unit of measurement.</param>
    /// <param name="b">The second unit of measurement.</param>
    /// <returns>A new unit representing the product of the two input units.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Unit<Multi<T1, T2, T1Base, T2Base, TNumber>, Multi<T1Base, T2Base, T1Base, T2Base, TNumber>, TNumber>
        Multiply<T1, T2, T1Base, T2Base, TNumber>(this Unit<T1, T1Base, TNumber> a, Unit<T2, T2Base, TNumber> b)
        where T1Base : struct, IBaseUnit<T1Base, TNumber>
        where T2Base : struct, IBaseUnit<T2Base, TNumber>
        where T1 : struct, IBaseUnit<T1Base, TNumber>
        where T2 : struct, IBaseUnit<T2Base, TNumber>
        where TNumber : IMultiplyOperators<TNumber, TNumber, TNumber>,
            IDivisionOperators<TNumber, TNumber, TNumber>
        => new(a.Float * b.Float);

    /// <summary>
    /// Performs division between two units of measurement.
    /// </summary>
    /// <typeparam name="T1">The type of the first unit.</typeparam>
    /// <typeparam name="T2">The type of the second unit.</typeparam>
    /// <typeparam name="T1Base">The base type of the first unit.</typeparam>
    /// <typeparam name="T2Base">The base type of the second unit.</typeparam>
    /// <typeparam name="TNumber">The type of the numeric value associated with the units.</typeparam>
    /// <param name="a">The first unit of measurement.</param>
    /// <param name="b">The second unit of measurement.</param>
    /// <returns>A new unit representing the division result.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Unit<Div<T1, T2, T1Base, T2Base, TNumber>, Div<T1Base, T2Base, T1Base, T2Base, TNumber>, TNumber>
         Divide<T1, T2, T1Base, T2Base, TNumber>(this Unit<T1, T1Base, TNumber> a, Unit<T2, T2Base, TNumber> b)
         where T1Base : struct, IBaseUnit<T1Base, TNumber>
         where T2Base : struct, IBaseUnit<T2Base, TNumber>
         where T1 : struct, IBaseUnit<T1Base, TNumber>
         where T2 : struct, IBaseUnit<T2Base, TNumber>
         where TNumber : IDivisionOperators<TNumber, TNumber, TNumber>,
            IMultiplyOperators<TNumber, TNumber, TNumber>
        => new(a.Float / b.Float);

    /// <summary>
    /// Performs a square root operation on a unit of measurement.. set to its base value.
    /// </summary>
    /// <typeparam name="T">The type of the unit.</typeparam>
    /// <typeparam name="TBase">The base type of the unit.</typeparam>
    /// <typeparam name="TNumber">The type of the numeric value associated with the unit.</typeparam>
    /// <param name="a">The unit of measurement to perform the square root operation on.</param>
    /// <returns>A new unit representing the square root result.</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Unit<Squared<T, TBase, TNumber>, Squared<TBase, TBase, TNumber>, TNumber>
        Square<T, TBase, TNumber>(this Unit<T, TBase, TNumber> a)
        where TBase : struct, IBaseUnit<TBase, TNumber>
        where T : struct, IBaseUnit<TBase, TNumber>
        where TNumber : IMultiplyOperators<TNumber, TNumber, TNumber>,
            IDivisionOperators<TNumber, TNumber, TNumber>
    => new(a.Float * a.Float);




}