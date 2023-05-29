using System.Numerics;

namespace UnitsOfMeasure;

public struct Radian<TNumber> : IBaseUnit<Radian<TNumber>, TNumber>
    where TNumber : IMultiplicativeIdentity<TNumber, TNumber>
{
    public string Postfix => "rad";

    public TNumber Base => TNumber.MultiplicativeIdentity;
}

public struct Degree<TNumber> : IBaseUnit<Radian<TNumber>, TNumber>
    where TNumber : IMultiplicativeIdentity<TNumber, TNumber>, IParsable<TNumber>
{
    public string Postfix => "deg";

    public TNumber Base => Constants<TNumber>.Number0_0174;
}