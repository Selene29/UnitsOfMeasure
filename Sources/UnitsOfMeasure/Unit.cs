using System.Numerics;

namespace UnitsOfMeasure;

/// <summary>
/// Represents a unit of measurement with a floating-point value.
/// </summary>
/// <typeparam name="T">The base unit type.</typeparam>
/// <typeparam name="TBase">The base unit type implementing the `IBaseUnit<TBase, TNumber>` interface.</typeparam>
/// <typeparam name="TNumber">The type of the number.</typeparam>
public readonly record struct Unit<T, TBase, TNumber>(TNumber Float)
    where TBase : struct, IBaseUnit<TBase, TNumber>
    where T : struct, IBaseUnit<TBase, TNumber>
    where TNumber : IMultiplyOperators<TNumber, TNumber, TNumber>, IDivisionOperators<TNumber, TNumber, TNumber>
{
    /// <summary>
    /// Returns a string representation of the unit and its value.
    /// </summary>
    /// <returns>A string containing the floating-point value and the unit's postfix.</returns>
    public override string ToString() => $"{Float:0.00} {new T().Postfix}";

    /// <summary>
    /// Converts the unit to a new unit type.
    /// </summary>
    /// <typeparam name="TNew">The target unit type.</typeparam>
    /// <returns>A new `Unit<TNew, TBase, TNumber>` with the converted value.</returns>
    public Unit<TNew, TBase, TNumber> To<TNew>()
        where TNew : struct, IBaseUnit<TBase, TNumber>
        => new(Float * new T().Base / new TNew().Base);

}