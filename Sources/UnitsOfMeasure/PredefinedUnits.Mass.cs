using System.Numerics;

namespace UnitsOfMeasure;

public struct Kilogram<TNumber> : IBaseUnit<Kilogram<TNumber>, TNumber>
    where TNumber : IMultiplicativeIdentity<TNumber, TNumber>
{
    public string Postfix => "kg";

    public TNumber Base => TNumber.MultiplicativeIdentity;
}

public struct Tonn<TNumber> : IBaseUnit<Kilogram<TNumber>, TNumber>
    where TNumber : IMultiplicativeIdentity<TNumber, TNumber>, IParsable<TNumber>
{
    public string Postfix => "t";

    public TNumber Base => Constants<TNumber>.Number10E3;
}

public struct Gram<TNumber> : IBaseUnit<Kilogram<TNumber>, TNumber>
    where TNumber : IMultiplicativeIdentity<TNumber, TNumber>, IParsable<TNumber>
{
    public string Postfix => "g";

    public TNumber Base => Constants<TNumber>.Number10Em3;
}

public struct Milligram<TNumber> : IBaseUnit<Kilogram<TNumber>, TNumber>
    where TNumber : IMultiplicativeIdentity<TNumber, TNumber>, IParsable<TNumber>
{
    public string Postfix => "mg";

    public TNumber Base => Constants<TNumber>.Number10Em6;
}