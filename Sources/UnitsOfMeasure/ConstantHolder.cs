using System.Globalization;

namespace UnitsOfMeasure;

/// <summary>
/// A class that defines a set of constant values for different physical units and provides methods for converting and parsing numbers.
/// </summary>
/// <typeparam name="TNumber">The type of the number to be used as a unit of measurement.</typeparam>
internal static class Constants<TNumber>
    where TNumber : IParsable<TNumber>
{

    #region Number10E24
    /// <summary>
    /// A constant value representing 10^24 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10E24;
    /// <summary>
    /// A constant value representing 10^23 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10E23;
    /// <summary>
    /// A constant value representing 10^22 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10E22;
    /// <summary>
    /// A constant value representing 10^21 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10E21;
    /// <summary>
    /// A constant value representing 10^20 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10E20;
    /// <summary>
    /// A constant value representing 10^19 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10E19;
    /// <summary>
    /// A constant value representing 10^18 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10E18;
    /// <summary>
    /// A constant value representing 10^17 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10E17;
    /// <summary>
    /// A constant value representing 10^16 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10E16;
    /// <summary>
    /// A constant value representing 10^15 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10E15;
    /// <summary>
    /// A constant value representing 10^14 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10E14;
    /// <summary>
    /// A constant value representing 10^13 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10E13;
    /// <summary>
    /// A constant value representing 10^12 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10E12;
    /// <summary>
    /// A constant value representing 10^11 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10E11;
    /// <summary>
    /// A constant value representing 10^10 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10E10;
    /// <summary>
    /// A constant value representing 10^9 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10E9;
    /// <summary>
    /// A constant value representing 10^8 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10E8;
    /// <summary>
    /// A constant value representing 10^7 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10E7;
    /// <summary>
    /// A constant value representing 10^6 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10E6;
    /// <summary>
    /// A constant value representing 10^5 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10E5;
    /// <summary>
    /// A constant value representing 10^4 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10E4;
    /// <summary>
    /// A constant value representing 10^3 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10E3;
    /// <summary>
    /// A constant value representing 10^2 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10E2;
    /// <summary>
    /// A constant value representing 10^1 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10E1;
    #endregion Number10E24

    /// <summary>
    /// A constant value representing 1 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10E0;

    #region Number10Minus24
    /// <summary>
    /// A constant value representing 10^-1 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10Em1;
    /// <summary>
    /// A constant value representing 10^-2 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10Em2;
    /// <summary>
    /// A constant value representing 10^-3 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10Em3;
    /// <summary>
    /// A constant value representing 10^-4 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10Em4;
    /// <summary>
    /// A constant value representing 10^-5 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10Em5;
    /// <summary>
    /// A constant value representing 10^-6 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10Em6;
    /// <summary>
    /// A constant value representing 10^-7 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10Em7;
    /// <summary>
    /// A constant value representing 10^-8 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10Em8;
    /// <summary>
    /// A constant value representing 10^-9 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10Em9;
    /// <summary>
    /// A constant value representing 10^-10 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10Em10;
    /// <summary>
    /// A constant value representing 10^-11 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10Em11;
    /// <summary>
    /// A constant value representing 10^-12 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10Em12;
    /// <summary>
    /// A constant value representing 10^-13 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10Em13;
    /// <summary>
    /// A constant value representing 10^-14 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10Em14;
    /// <summary>
    /// A constant value representing 10^-15 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10Em15;
    /// <summary>
    /// A constant value representing 10^-16 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10Em16;
    /// <summary>
    /// A constant value representing 10^-17 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10Em17;
    /// <summary>
    /// A constant value representing 10^-18 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10Em18;
    /// <summary>
    /// A constant value representing 10^-19 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10Em19;
    /// <summary>
    /// A constant value representing 10^-20 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10Em20;
    /// <summary>
    /// A constant value representing 10^-21 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10Em21;
    /// <summary>
    /// A constant value representing 10^-22 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10Em22;
    /// <summary>
    /// A constant value representing 10^-23 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10Em23;
    /// <summary>
    /// A constant value representing 10^-24 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number10Em24;
    #endregion Number10Minus24

    /// <summary>
    /// A constant value representing 1609.34 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number1609_34;
    /// <summary>
    /// A constant value representing 60 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number60;
    /// <summary>
    /// A constant value representing 3600 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number3600;
    /// <summary>
    /// A constant value representing 0.0174 of the unit type TNumber.
    /// </summary>
    internal static readonly TNumber Number0_0174;

    internal static readonly TNumber Dummy;

    /// <summary>
    /// A method that converts a float or an integer string to the appropriate unit type. FLOAT or INTEGER, respectively.
    /// </summary>
    /// <param name="forFloat">A string representing the float value to be parsed.</param>
    /// <param name="forInt">A string representing the integer value to be parsed.</param>
    /// <returns>A TNumber value representing the parsed float or integer.</returns>
    static TNumber FromString(string forFloat, string forInt)
    {
        var isFloating = typeof(TNumber) == typeof(float) || typeof(TNumber) == typeof(double) || typeof(TNumber) == typeof(System.Numerics.Complex);
        return isFloating
                ? TNumber.Parse(forFloat, CultureInfo.InvariantCulture)
                : TNumber.Parse(forInt, null);
    }

    /// <summary>
    /// Initializes the constants used by the Constants class. class. IUnit<TNumber> instances.
    /// </summary>
    static Constants()
    {
        Number1609_34 = FromString("1609.34", "1609");
        Number60 = TNumber.Parse("60", null);
        Number3600 = TNumber.Parse("3600", null);
        Number0_0174 = FromString("0.0174", "0");



        Number10E0 = FromString("1.0", "0");
        Number10E1 = FromString("10.0", "0");
        Number10E2 = FromString("100.0", "0");
        Number10E3 = FromString("1000.0", "0");
        Number10E4 = FromString("10000.0", "0");
        Number10E5 = FromString("100000.0", "0");
        Number10E6 = FromString("1000000.0", "0");
        Number10E7 = FromString("10000000.0", "0");
        Number10E8 = FromString("100000000.0", "0");
        Number10E9 = FromString("1000000000.0", "0");
        Number10E10 = FromString("10000000000.0", "0");
        Number10E11 = FromString("100000000000.0", "0");
        Number10E12 = FromString("1000000000000.0", "0");
        Number10E13 = FromString("10000000000000.0", "0");
        Number10E14 = FromString("100000000000000.0", "0");
        Number10E15 = FromString("1000000000000000.0", "0");
        Number10E16 = FromString("10000000000000000.0", "0");
        Number10E17 = FromString("100000000000000000.0", "0");
        Number10E18 = FromString("1000000000000000000.0", "0");
        Number10E19 = FromString("10000000000000000000.0", "0");
        Number10E20 = FromString("100000000000000000000.0", "0");
        Number10E21 = FromString("1000000000000000000000.0", "0");
        Number10E22 = FromString("10000000000000000000000.0", "0");
        Number10E23 = FromString("100000000000000000000000.0", "0");
        Number10E24 = FromString("1000000000000000000000000.0", "0");

        Number10Em1 = FromString("0.1", "0");
        Number10Em2 = FromString("0.01", "0");
        Number10Em3 = FromString("0.001", "0");
        Number10Em4 = FromString("0.0001", "0");
        Number10Em5 = FromString("0.00001", "0");
        Number10Em6 = FromString("0.000001", "0");
        Number10Em7 = FromString("0.0000001", "0");
        Number10Em8 = FromString("0.00000001", "0");
        Number10Em9 = FromString("0.000000001", "0");
        Number10Em10 = FromString("0.0000000001", "0");
        Number10Em11 = FromString("0.00000000001", "0");
        Number10Em12 = FromString("0.000000000001", "0");
        Number10Em13 = FromString("0.0000000000001", "0");
        Number10Em14 = FromString("0.00000000000001", "0");
        Number10Em15 = FromString("0.000000000000001", "0");
        Number10Em16 = FromString("0.0000000000000001", "0");
        Number10Em17 = FromString("0.00000000000000001", "0");
        Number10Em18 = FromString("0.000000000000000001", "0");
        Number10Em19 = FromString("0.0000000000000000001", "0");
        Number10Em20 = FromString("0.00000000000000000001", "0");
        Number10Em21 = FromString("0.000000000000000000001", "0");
        Number10Em22 = FromString("0.0000000000000000000001", "0");
        Number10Em23 = FromString("0.00000000000000000000001", "0");
        Number10Em24 = FromString("0.000000000000000000000001", "0");
    }
}