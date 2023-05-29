using System.Numerics;

namespace UnitsOfMeasure;

/// <summary>
/// This class contains extension methods for converting units of measurement.
/// </summary>
public static class UoM
{
    /// <summary>
    /// Converts the input value to meters.
    /// </summary>
    /// <typeparam name="T">The type of the input value.</typeparam>
    /// <param name="a">The input value.</param>
    /// <returns>A new <see cref="Unit{T, Meter<T>, T}"/> representing the input value in meters.</returns>
    public static Unit<Meter<T>, Meter<T>, T> Meters<T>(this T a)
        where T : IMultiplicativeIdentity<T, T>, IDivisionOperators<T, T, T>, IMultiplyOperators<T, T, T>
        => new(a);

    /// <summary>
    /// Converts the input value to kilometers.
    /// </summary>
    /// <typeparam name="T">The type of the input value.</typeparam>
    /// <param name="a">The input value.</param>
    /// <returns>A new <see cref="Unit{T, Kilometer<T>, T}"/> representing the input value in kilometers.</returns>
    public static Unit<Kilometer<T>, Meter<T>, T> Kilometers<T>(this T a)
        where T : IMultiplicativeIdentity<T, T>, IParsable<T>, IDivisionOperators<T, T, T>, IMultiplyOperators<T, T, T>
        => new(a);

    public static Unit<Decimeter<T>, Meter<T>, T> Decimeters<T>(this T a)
        where T : IMultiplicativeIdentity<T, T>, IParsable<T>, IDivisionOperators<T, T, T>, IMultiplyOperators<T, T, T>
        => new(a);

    public static Unit<Centimeter<T>, Meter<T>, T> Centimeters<T>(this T a)
        where T : IMultiplicativeIdentity<T, T>, IParsable<T>, IDivisionOperators<T, T, T>, IMultiplyOperators<T, T, T>
        => new(a);

    public static Unit<Millimeter<T>, Meter<T>, T> Millimeters<T>(this T a)
        where T : IMultiplicativeIdentity<T, T>, IParsable<T>, IDivisionOperators<T, T, T>, IMultiplyOperators<T, T, T>
        => new(a);

    public static Unit<Mile<T>, Meter<T>, T> Miles<T>(this T a)
        where T : IMultiplicativeIdentity<T, T>, IParsable<T>, IDivisionOperators<T, T, T>, IMultiplyOperators<T, T, T>
        => new(a);

    public static Unit<Second<T>, Second<T>, T> Seconds<T>(this T a)
        where T : IMultiplicativeIdentity<T, T>, IDivisionOperators<T, T, T>, IMultiplyOperators<T, T, T>
        => new(a);

    public static Unit<Millisecond<T>, Second<T>, T> Milliseconds<T>(this T a)
        where T : IMultiplicativeIdentity<T, T>, IParsable<T>, IDivisionOperators<T, T, T>, IMultiplyOperators<T, T, T>
        => new(a);

    /// <summary>
    /// Converts the input value to minutes.
    /// </summary>
    /// <typeparam name="T">The type of the input value.</typeparam>
    /// <param name="a">The input value.</param>
    /// <returns>A new <see cref="Unit{T, Minute<T>, Second<T>, T}"/> representing the input value in minutes.</returns>
    public static Unit<Minute<T>, Second<T>, T> Minutes<T>(this T a)
        where T : IMultiplicativeIdentity<T, T>, IParsable<T>, IDivisionOperators<T, T, T>, IMultiplyOperators<T, T, T>
        => new(a);

    public static Unit<Hour<T>, Second<T>, T> Hours<T>(this T a)
        where T : IMultiplicativeIdentity<T, T>, IParsable<T>, IDivisionOperators<T, T, T>, IMultiplyOperators<T, T, T>
        => new(a);

    public static Unit<Degree<T>, Radian<T>, T> Degrees<T>(this T a)
        where T : IMultiplicativeIdentity<T, T>, IParsable<T>, IDivisionOperators<T, T, T>, IMultiplyOperators<T, T, T>
        => new(a);

    public static Unit<Radian<T>, Radian<T>, T> Radians<T>(this T a)
        where T : IMultiplicativeIdentity<T, T>, IParsable<T>, IDivisionOperators<T, T, T>, IMultiplyOperators<T, T, T>
        => new(a);

    public static Unit<Kilogram<T>, Kilogram<T>, T> Kilograms<T>(this T a)
        where T : IMultiplicativeIdentity<T, T>, IParsable<T>, IDivisionOperators<T, T, T>, IMultiplyOperators<T, T, T>
        => new(a);

    public static Unit<Gram<T>, Kilogram<T>, T> Grams<T>(this T a)
        where T : IMultiplicativeIdentity<T, T>, IParsable<T>, IDivisionOperators<T, T, T>, IMultiplyOperators<T, T, T>
        => new(a);

    public static Unit<Milligram<T>, Kilogram<T>, T> Milligrams<T>(this T a)
        where T : IMultiplicativeIdentity<T, T>, IParsable<T>, IDivisionOperators<T, T, T>, IMultiplyOperators<T, T, T>
        => new(a);

    public static Unit<Tonn<T>, Kilogram<T>, T> Tonns<T>(this T a)
        where T : IMultiplicativeIdentity<T, T>, IParsable<T>, IDivisionOperators<T, T, T>, IMultiplyOperators<T, T, T>
        => new(a);
}