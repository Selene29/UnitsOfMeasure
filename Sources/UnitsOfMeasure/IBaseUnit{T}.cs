namespace UnitsOfMeasure;

/// <summary>
/// Represents a base unit of measurement with a specific type of quantity.
/// </summary>
/// <typeparam name="T">The type of quantity.</typeparam>
/// <typeparam name="TNumber">The type of the quantity value.</typeparam>
public interface IBaseUnit<T, TNumber> {
    /// <summary>
    /// Gets the base value of the quantity.
    /// </summary>
    TNumber Base { get; }

    /// <summary>
    /// Gets the postfix used to represent the unit of measurement.
    /// </summary>
    string Postfix { get; }
}