namespace LanguagesTask;

public struct ComplexNum
{
    public int Real { get; private set; }
    public int Imaginary { get; private set; }

    public override string ToString() => $"Real: {Real} Imaginary: {Imaginary}";

    public ComplexNum(int real, int imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public static ComplexNum operator +(ComplexNum a, ComplexNum b)
    {
        return new ComplexNum(a.Real + b.Real, a.Imaginary + b.Imaginary);
    }

    public static ComplexNum operator -(ComplexNum a, ComplexNum b)
    {
        return new ComplexNum(a.Real - b.Real, a.Imaginary - b.Imaginary);
    }

    public static bool operator ==(ComplexNum a, ComplexNum b)
    {
        return a.Real.Equals(b.Real) && a.Imaginary.Equals(b.Imaginary);
    }

    public static bool operator !=(ComplexNum a, ComplexNum b)
    {
        return !(a == b);
    }

    public override bool Equals(object? obj)
    {
        return obj is ComplexNum other && this == other;
    }

    public override int GetHashCode() => HashCode.Combine(Real, Imaginary);
}
