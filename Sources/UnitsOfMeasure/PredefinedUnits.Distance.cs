using System.Numerics;

namespace UnitsOfMeasure;

public struct Meter<TNumber> : IBaseUnit<Meter<TNumber>, TNumber>
    where TNumber : IMultiplicativeIdentity<TNumber, TNumber>
{
    public string Postfix => "m";

    public TNumber Base => TNumber.MultiplicativeIdentity;
}

public struct Millimeter<TNumber> : IBaseUnit<Meter<TNumber>, TNumber>
    where TNumber : IMultiplicativeIdentity<TNumber, TNumber>, IParsable<TNumber>
{
    public string Postfix => "mm";

    public TNumber Base => Constants<TNumber>.Number10Em3;
}

public struct Centimeter<TNumber> : IBaseUnit<Meter<TNumber>, TNumber>
    where TNumber : IMultiplicativeIdentity<TNumber, TNumber>, IParsable<TNumber>
{
    public string Postfix => "cm";

    public TNumber Base => Constants<TNumber>.Number10Em2;
}

public struct Decimeter<TNumber> : IBaseUnit<Meter<TNumber>, TNumber>
    where TNumber : IMultiplicativeIdentity<TNumber, TNumber>, IParsable<TNumber>
{
    public string Postfix => "dm";

    public TNumber Base => Constants<TNumber>.Number10Em1;
}

public struct Kilometer<TNumber> : IBaseUnit<Meter<TNumber>, TNumber>
    where TNumber : IMultiplicativeIdentity<TNumber, TNumber>, IParsable<TNumber>
{
    public string Postfix => "km";

    public TNumber Base => Constants<TNumber>.Number10E3;
}

public struct Mile<TNumber> : IBaseUnit<Meter<TNumber>, TNumber>
    where TNumber : IMultiplicativeIdentity<TNumber, TNumber>, IParsable<TNumber>
{
    public string Postfix => "mile";

    public TNumber Base => Constants<TNumber>.Number1609_34;
}

