using System;
using CSharpLab2;
using NUnit.Framework;

namespace TestLab2
{
    [TestFixture]
    public class TestsMeter
    {
        [Test]
        public void TestMeter()
        {
           
            var a = new Meter(1);
            var b = new Meter(2);
            Assert.True(new Meter(3) == a+b);
            var inch = new Inch(Meter.InchesPerMeter);
            Assert.True(new Meter(2) == inch + new Meter(1));
            Assert.True(new Meter(2) == new Meter(1) + 1);
            Assert.True(new Meter(2) == 1 + new Meter(1));
            Assert.True(new Meter(2) == new Meter(1) + (inch));
            
            Assert.True(new Meter(1) == +a);
            
            Assert.True(new Meter(-1) == a-b);
            Assert.True(new Meter(0) == inch - new Meter(1));
            Assert.True(new Meter(0) == new Meter(1) - 1);
            Assert.True(new Meter(0) == 1 - new Meter(1));
            Assert.True(new Meter(0) == new Meter(1) - (inch));
            Assert.True(new Meter(-1) == -a);
            
            Assert.True(new Meter(2) == a*b);
            Assert.True(new Meter(2) == inch * new Meter(2));
            Assert.True(new Meter(4) == new Meter(2) * 2);
            Assert.True(new Meter(4) == 2 * new Meter(2));
            Assert.True(new Meter(2) == new Meter(2) * (inch));
            
            
            Assert.True(new Meter(0.5f) == a/b);
            Assert.True(new Meter(1) == inch / new Meter(1));
            Assert.True(new Meter(1) == new Meter(2) / 2);
            Assert.True(new Meter(1) == 2 / new Meter(2));
            Assert.True(new Meter(1) == new Meter(1) / (inch));
            
         
            Assert.True(a == new Meter(1));
            Assert.True(new Meter(1) == inch );
            Assert.True(inch == new Meter(1));
            Assert.True(new Meter(1) == 1);
            Assert.True(2 == new Meter(2));
            
            Assert.True(a != b);
            Assert.True(new Meter(2) != inch );
            Assert.True(inch != new Meter(2));
            Assert.True(new Meter(2) != 1);
            Assert.True(1 != new Meter(2));
            
            //Assert.True(a != null);
            Assert.False(a > b);
            Assert.True(new Meter(2) > inch );
            Assert.True(inch > new Meter(0.5f));
            Assert.False(new Meter(1) > 1);
            Assert.True(2 > new Meter(1));
            
            Assert.True(a < b);
            Assert.False(new Meter(1) < inch );
            Assert.False(inch < new Meter(1));
            Assert.False(new Meter(1) < 1);
            Assert.False(2 < new Meter(2));
        }

        [Test]
        public void Test3()
        {
            var inch = new Inch(Meter.InchesPerMeter);
            var meter = (Meter) inch;
            Assert.True(new Meter(1) == meter);
            inch = meter;
            Assert.True(new Inch(Meter.InchesPerMeter) == inch);
            inch = new Inch(Meter.InchesPerMeter);
       
          
        }

        [Test]
        public void TestToString()
        {
            Assert.True("1m" == new Meter(1).ToString());
        }

        [Test]
        public void TestEquals()
        {
            Assert.True(new Meter(1).Equals(new Meter(1)));
            Assert.False(new Meter(1).Equals(null));

        }
        
        [Test]
        public void TestGetHashCode()
        {
            Assert.True(1.0f.GetHashCode() == new Meter(1).GetHashCode());

        }
    }
}