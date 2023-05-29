using System.Numerics;

namespace UnitsOfMeasure;

public struct SquareMeter<TNumber> : IBaseUnit<Meter<TNumber>, TNumber>
    where TNumber : IMultiplicativeIdentity<TNumber, TNumber>
{
    public string Postfix => "m²";

    public TNumber Base => TNumber.MultiplicativeIdentity;

    public override string ToString() {
        return Postfix;
    }
}

public struct SquareMillimeter<TNumber> : IBaseUnit<Meter<TNumber>, TNumber>
    where TNumber : IMultiplicativeIdentity<TNumber, TNumber>, IParsable<TNumber>
{
    public string Postfix => "mm²";

    public TNumber Base => Constants<TNumber>.Number10Em6;
}

public struct SquareCentimeter<TNumber> : IBaseUnit<Meter<TNumber>, TNumber>
    where TNumber : IMultiplicativeIdentity<TNumber, TNumber>, IParsable<TNumber>
{
    public string Postfix => "cm²";

    public TNumber Base => Constants<TNumber>.Number10Em4;
}

public struct SquareDecimeter<TNumber> : IBaseUnit<Meter<TNumber>, TNumber>
    where TNumber : IMultiplicativeIdentity<TNumber, TNumber>, IParsable<TNumber>
{
    public string Postfix => "dm²";

    public TNumber Base => Constants<TNumber>.Number10Em2;
}

public struct SquareKilometer<TNumber> : IBaseUnit<Meter<TNumber>, TNumber>
    where TNumber : IMultiplicativeIdentity<TNumber, TNumber>, IParsable<TNumber>
{
    public string Postfix => "km²";

    public TNumber Base => Constants<TNumber>.Number10E6;
}

public struct Hectare<TNumber> : IBaseUnit<Meter<TNumber>, TNumber>
    where TNumber : IMultiplicativeIdentity<TNumber, TNumber>, IParsable<TNumber> {
    public string Postfix => "ha";

    public TNumber Base => Constants<TNumber>.Number10E4;
}

public struct SquareMile<TNumber> : IBaseUnit<Meter<TNumber>, TNumber>
    where TNumber : IMultiplicativeIdentity<TNumber, TNumber>, IParsable<TNumber>
{
    public string Postfix => "mile²";

    public TNumber Base => Constants<TNumber>.Dummy;
}

