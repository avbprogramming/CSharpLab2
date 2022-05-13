using System;

namespace CSharpLab2
{
    public readonly struct Inch
    {
       private readonly float _value;
        public Inch(float value)
        {
            this._value = value;
        }

        public static Inch operator +(Inch a, Inch b)
        {
            return new Inch(a._value + b._value);
        }
        // public static Inch operator +(Meter a, Inch b)
        // {
        //     return (Inch) a + b;
        // }
        //  public static Inch operator +(Inch a, Meter b)
        // {
        //     return  a + (Inch) b;
        // }
        public static Inch operator +(Inch a, float b)
        {
            return a + new Inch(b);
        }
        public static Inch operator +(float a, Inch b)
        {
            return new Inch(a) + b;
        }
        public static Inch operator +(Inch a)
        {
            return new Inch(+a._value);
        }
        
        public static Inch operator -(Inch a, Inch b)
        {
            return new Inch(a._value - b._value);
        }
        // public static Inch operator -(Meter a, Inch b)
        // {
        //     return (Inch) a - b;
        // }
        // public static Inch operator -(Inch a, Meter b)
        // {
        //     return  a - (Inch) b;
        // }
        public static Inch operator -(Inch a, float b)
        {
            return a - new Inch(b);
        }
        public static Inch operator -(float a, Inch b)
        {
            return new Inch(a) - b;
        }
        public static Inch operator -(Inch a)
        {
            return new Inch(-a._value);
        }
        
        public static Inch operator *(Inch a, Inch b)
        {
            return new Inch(a._value * b._value);
        }
        // public static Inch operator *(Meter a, Inch b)
        // {
        //     return (Inch) a * b;
        // }
        // public static Inch operator *(Inch a, Meter b)
        // {
        //     return  a * (Inch) b;
        // }
        public static Inch operator *(Inch a, float b)
        {
            return a * new Inch(b);
        }
        public static Inch operator *(float a, Inch b)
        {
            return new Inch(a) * b;
        }

        public static Inch operator /(Inch a, Inch b)
        {
            return new Inch(a._value / b._value);
        }
        // public static Inch operator /(Meter a, Inch b)
        // {
        //     return (Inch) a / b;
        // }
        // public static Inch operator /(Inch a, Meter b)
        // {
        //     return  a / (Inch) b;
        // }
        public static Inch operator /(Inch a, float b)
        {
            return a / new Inch(b);
        }
        public static Inch operator /(float a, Inch b)
        {
            return new Inch(a) / b;
        }

        public static bool operator ==(Inch a, Inch b)
        {
            return Math.Abs(a._value - b._value) < float.Epsilon;
        }
        // public static bool operator ==(Meter a, Inch b)
        // {
        //     var c = (Inch) a;
        //     return Math.Abs(c._value - b._value) < float.Epsilon;
        // }
        // public static bool operator ==(Inch a, Meter b)
        // {
        //     var c = (Inch) b;
        //     return Math.Abs(a._value - c._value) < float.Epsilon;
        // }
        public static bool operator ==(float a, Inch b)
        {
            return Math.Abs(a - b._value) < float.Epsilon;
        }
        public static bool operator ==(Inch a, float b)
        {
            return Math.Abs(a._value - b) < float.Epsilon;
        }
        
        public static bool operator !=(Inch a, Inch b)
        {
            return !(a == b);
        }
        // public static bool operator !=(Meter a, Inch b)
        // {
        //     var c = (Inch) a;
        //     return !(c == b);
        // }
        // public static bool operator !=(Inch a, Meter b)
        // {
        //     var c = (Inch) b;
        //     return Math.Abs(a._value - c._value) < float.Epsilon;
        // }
        public static bool operator !=(float a, Inch b)
        {
            return !(a == b);
        }
        public static bool operator !=(Inch a, float b)
        {
            return !(a == b);
        }
        
        public static bool operator >(Inch a, Inch b)
        {
            return (a._value > b._value);
        }
        // public static bool operator >(Meter a, Inch b)
        // {
        //     var c = (Inch) a;
        //     return (c._value > b._value);
        // }
        // public static bool operator >(Inch a, Meter b)
        // {
        //     var c = (Inch) b;
        //     return (a._value > c._value);
        // }
        public static bool operator >(float a, Inch b)
        {
            return (a > b._value);
        }
        public static bool operator >(Inch a, float b)
        {
            return (a._value > b);
        }
        
        public static bool operator <(Inch a, Inch b)
        {
            return (a._value < b._value);
        }
        // public static bool operator <(Meter a, Inch b)
        // {
        //     var c = (Inch) a;
        //     return (c._value < b._value);
        // }
        // public static bool operator <(Inch a, Meter b)
        // {
        //     var c = (Inch) b;
        //     return (a._value < c._value);
        // }
        public static bool operator <(float a, Inch b)
        {
            return (a < b._value);
        }
        public static bool operator <(Inch a, float b)
        {
            return (a._value < b);
        }
  
        public override string ToString()
        {
            return _value + "inch(es)";
        }
        public bool Equals(Inch other)
        {
            return _value.Equals(other._value);
        }
        public override bool Equals(object obj)
        {
            return obj is Inch other && Equals(other);
        }
        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }
        public static explicit operator Meter(Inch inch)
        {
            return new Meter(inch._value/Meter.InchesPerMeter);
        }
    }
}