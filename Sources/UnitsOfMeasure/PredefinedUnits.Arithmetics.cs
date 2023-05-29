using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UnitsOfMeasure;

public struct Squared<T, TBase, TNumber>
    : IBaseUnit<Squared<TBase, TBase, TNumber>, TNumber>
    where T : struct, IBaseUnit<TBase, TNumber>
    where TBase : struct, IBaseUnit<TBase, TNumber>
    where TNumber : IMultiplyOperators<TNumber, TNumber, TNumber>
{
    public TNumber Base => new T().Base * new T().Base;

    public string Postfix => $"({new T().Postfix})^2";
}

public struct Div<T1, T2, T1Base, T2Base, TNumber>
    : IBaseUnit<Div<T1Base, T2Base, T1Base, T2Base, TNumber>, TNumber>
    where T1Base : struct, IBaseUnit<T1Base, TNumber>
    where T2Base : struct, IBaseUnit<T2Base, TNumber>
    where T1 : struct, IBaseUnit<T1Base, TNumber>
    where T2 : struct, IBaseUnit<T2Base, TNumber>
    where TNumber : IDivisionOperators<TNumber, TNumber, TNumber> {
    public TNumber Base => new T1().Base / new T2().Base;
    public string Postfix => $"({new T1().Postfix} / {new T2().Postfix})";
    //public string Postfix => HelperStruct<T1, T2, T1Base, T2Base, TNumber>.ModifyPostfix(new T1(), new T2());
}

public struct Multi<T1, T2, T1Base, T2Base, TNumber>
    : IBaseUnit<Multi<T1Base, T2Base, T1Base, T2Base, TNumber>, TNumber>
    where T1Base : struct, IBaseUnit<T1Base, TNumber>
    where T2Base : struct, IBaseUnit<T2Base, TNumber>
    where T1 : struct, IBaseUnit<T1Base, TNumber>
    where T2 : struct, IBaseUnit<T2Base, TNumber>
    where TNumber : IMultiplyOperators<TNumber, TNumber, TNumber> {
    public TNumber Base => new T1().Base * new T2().Base;
    public string Postfix => $"({new T1().Postfix} * {new T2().Postfix})";
    //public string Postfix => HelperStruct<T1, T2, T1Base, T2Base, TNumber>.ModifyPostfix(new T1(), new T2());
}










internal struct HelperStruct<T1, T2, T1Base, T2Base, TNumber> {
    public static string ModifyPostfix(IBaseUnit<T1Base, TNumber> unit1, IBaseUnit<T2Base, TNumber> unit2) {
        // Get the base and exponent of unit1
        TNumber base1 = unit1.Base;
        string postfix1 = unit1.Postfix;
        Dictionary<string, double> exponents1 = GetExponent(unit1.Postfix);

        // Get the base and exponent of unit2
        TNumber base2 = unit2.Base;
        string postfix2 = unit2.Postfix;
        Dictionary<string, double> exponents2 = GetExponent(unit2.Postfix);

        // Check if both units have the same base
        if (Equals(postfix1, postfix2)) {
            // Calculate the new exponent based on the sum of the exponents
            int newExponent=1;// = exponent1 + exponent2;

            // Reconstruct the postfix with the correct exponent
            string postfix = ReconstructPostfix(postfix1, newExponent);

            return postfix;
        }

        // Default case: multiply the postifixes
        return $"({unit1.Postfix} * {unit2.Postfix})";
    }

    private static Dictionary<string, double> GetExponent(string postfix) {
        Dictionary<string, double> exponents = new Dictionary<string, double>();

        // Split the postfix string by whitespace to get individual unit expressions
        string[] unitExpressions = postfix.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string unitExpression in unitExpressions) {
            // Split each unit expression by the caret symbol (^)
            string[] parts = unitExpression.Split('^');

            if (parts.Length == 2) {
                string baseUnit = parts[0];
                string exponentString = parts[1];

                if (double.TryParse(exponentString, out double exponent)) {
                    exponents[baseUnit] = exponent;
                }
            } else if (parts.Length == 1) {
                // If there's no exponent specified, assume it's 1
                exponents[unitExpression] = 1;
            } else {
                // Invalid format, handle accordingly (e.g., throw an exception)
            }
        }

        return exponents;
    }


    private static string ReconstructPostfix(string postfix, int exponent) {
        // Reconstruct the postfix with the correct exponent
        // Assuming the exponent is represented using ^ symbol

        if (exponent > 1) {
            return $"{postfix}^{exponent}";
        } else {
            return postfix;
        }
    }
}
