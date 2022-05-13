using System;
using System.ComponentModel;

namespace CSharpLab2
{
    public readonly struct Meter
    {
        private readonly float _value;
        public static float InchesPerMeter = 39.3701f;
        public Meter(float value)
        {
            this._value = value;
        }

        public static Meter operator +(Meter a, Meter b)
        {
            return new Meter(a._value + b._value);
        }
        public static Meter operator +(Meter a, Inch b)
        {
            return a + (Meter) b;
        }
        public static Meter operator +(Inch a, Meter b)
        {
            return (Meter) a + b;
        }
        public static Meter operator +(Meter a, float b)
        {
            return a + new Meter(b);
        }
        public static Meter operator +(float a, Meter b)
        {
            return new Meter(a) + b;
        }
        public static Meter operator +(Meter a)
        {
            return new Meter(+a._value);
        }

        public static Meter operator -(Meter a, Meter b)
        {
            return new Meter(a._value - b._value);
        }
        public static Meter operator -(Meter a, Inch b)
        {
            return a - (Meter) b;
        }
        public static Meter operator -(Inch a, Meter b)
        {
            return (Meter) a - b;
        }
        public static Meter operator -(Meter a, float b)
        {
            return a - new Meter(b);
        }
        public static Meter operator -(float a, Meter b)
        {
            return new Meter(a) - b;
        }
        public static Meter operator -(Meter a)
        {
            return new Meter(-a._value);
        }

        public static Meter operator *(Meter a, Meter b)
        {
            return new Meter(a._value * b._value);
        }
        public static Meter operator *(Meter a, Inch b)
        {
            return a * (Meter) b;
        }
        public static Meter operator *(Inch a, Meter b)
        {
            return (Meter) a * b;
        }
        public static Meter operator *(Meter a, float b)
        {
            return a * new Meter(b);
        }
        public static Meter operator *(float a, Meter b)
        {
            return new Meter(a) * b;
        }

        public static Meter operator /(Meter a, Meter b)
        {
            return new Meter(a._value / b._value);
        }
        public static Meter operator /(Meter a, Inch b)
        {
            return a / (Meter) b;
        }
        public static Meter operator /(Inch a, Meter b)
        {
            return (Meter) a / b;
        }
        public static Meter operator /(float a, Meter b)
        {
            return new Meter(a) / b;
        }
        public static Meter operator /(Meter a, float b)
        {
            return a / new Meter(b);
        }

        public static bool operator ==(Meter a, Meter b)
        {
            // if (a is null && b is null)
            // {
            //     return true;
            // }
            // if (a is null || b is null)
            // {
            //     return false;
            // }
            return Math.Abs(a._value - b._value) < float.Epsilon;
        }
        public static bool operator ==(Meter a, Inch b)
        {
            var c = (Meter) b;
            return Math.Abs(a._value - c._value) < float.Epsilon;
        }
        public static bool operator ==(Inch a, Meter b)
        {
            var c = (Meter) a;
            return Math.Abs(c._value - b._value) < float.Epsilon;
        }
        public static bool operator ==(float a, Meter b)
        {
            return Math.Abs(a - b._value) < float.Epsilon;
        }
        public static bool operator ==(Meter a, float b)
        {
            return Math.Abs(a._value - b) < float.Epsilon;
        }

        public static bool operator !=(Meter a, Meter b)
        {
            return !(a == b);
        }
        public static bool operator !=(Meter a, Inch b)
        {
            var c = (Meter) b;
            return !(a == c);
        }
        public static bool operator !=(Inch a, Meter b)
        {
            var c = (Meter) a;
            return !(b == c);
        }
        public static bool operator !=(float a, Meter b)
        {
            return !(a == b);
        }
        public static bool operator !=(Meter a, float b)
        {
            return !(a == b);
        }

        public static bool operator >(Meter a, Meter b)
        {
            return (a._value > b._value);
        }
        public static bool operator >(Meter a, Inch b)
        {
            var c = (Meter) b;
            return (a._value > c._value);
        }
        public static bool operator >(Inch a, Meter b)
        {
            var c = (Meter) a;
            return (c._value > b._value);
        }
        public static bool operator >(float a, Meter b)
        {
            return (a > b._value);
        }
        public static bool operator >(Meter a, float b)
        {
            return (a._value > b);
        }

        public static bool operator <(Meter a, Meter b)
        {
            // if (a is null && b is null)
            // {
            //     return false;
            // }
            // //уточнить, если одно из значений == null,
            // //то либо null это 0, 
            // //либо кидать исключение 
            // if (a is null || b is null)
            // {
            //     return false;
            // }
            return (a._value < b._value);
        }
        public static bool operator <(Meter a, Inch b)
        {
            var c = (Meter) b;
            return (a._value < c._value);
        }
        public static bool operator <(Inch a, Meter b)
        {
            var c = (Meter) a;
            return (c._value < b._value);
        }
        public static bool operator <(float a, Meter b)
        {
            return (a < b._value);
        }
        public static bool operator <(Meter a, float b)
        {
            return (a._value < b);
        }

        public static implicit operator Inch(Meter meter)
        {
            return new Inch(InchesPerMeter * meter._value);
        }
        public override string ToString()
        {
            return _value + "m";
        }
        public bool Equals(Meter other)
        {
            return _value.Equals(other._value);
        }
        public override bool Equals(object obj)
        {
            return obj is Meter other && Equals(other);
        }
        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }
    }
}