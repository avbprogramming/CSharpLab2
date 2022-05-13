using System;
using CSharpLab2;
using NUnit.Framework;

namespace TestLab2
{
    [TestFixture]
    public class TestsInch
    
    {
        [Test]
        public void TestInch()
        {
           var a = new Inch(1);
            var b = new Inch(2);
            Assert.True(new Inch(3) == a+b);
            var inch = new Inch(1);
            Assert.True(new Inch(2) == inch + new Inch(1));
            Assert.True(new Inch(2) == new Inch(1) + 1);
            Assert.True(new Inch(2) == 1 + new Inch(1));
            Assert.True(new Inch(2) == new Inch(1) + (inch));
            
            Assert.True(new Inch(1) == +a);
            
            Assert.True(new Inch(-1) == a-b);
            Assert.True(new Inch(0) == inch - new Inch(1));
            Assert.True(new Inch(0) == new Inch(1) - 1);
            Assert.True(new Inch(0) == 1 - new Inch(1));
            Assert.True(new Inch(0) == new Inch(1) - (inch));
            Assert.True(new Inch(-1) == -a);
            
            Assert.True(new Inch(2) == a*b);
            Assert.True(new Inch(2) == inch * new Inch(2));
            Assert.True(new Inch(4) == new Inch(2) * 2);
            Assert.True(new Inch(4) == 2 * new Inch(2));
            Assert.True(new Inch(2) == new Inch(2) * (inch));
            
            
            Assert.True(new Inch(0.5f) == a/b);
            Assert.True(new Inch(1) == inch / new Inch(1));
            Assert.True(new Inch(1) == new Inch(2) / 2);
            Assert.True(new Inch(1) == 2 / new Inch(2));
            Assert.True(new Inch(1) == new Inch(1) / (inch));
            
            Assert.True(a == new Inch(1));
            Assert.True(new Inch(1) == inch );
            Assert.True(inch == new Inch(1));
            Assert.True(new Inch(1) == 1);
            Assert.True(2 == new Inch(2));
            
            Assert.True(a != b);
            Assert.True(new Inch(2) != inch );
            Assert.True(inch != new Inch(2));
            Assert.True(new Inch(2) != 1);
            Assert.True(1 != new Inch(2));
            
            //Assert.True(a != null);
            Assert.False(a > b);
            Assert.True(new Inch(2) > inch );
            Assert.True(inch > new Inch(0.5f));
            Assert.False(new Inch(1) > 1);
            Assert.True(2 > new Inch(1));
            
            Assert.True(a < b);
            Assert.False(new Inch(1) < inch );
            Assert.False(inch < new Inch(1));
            Assert.False(new Inch(1) < 1);
            Assert.False(2 < new Inch(2));
        }

        [Test]
        public void TestToString()
        {
            Assert.True("1inch(es)" == new Inch(1).ToString());
        }

        [Test]
        public void TestEquals()
        {
            Assert.True(new Inch(1).Equals(new Inch(1)));
            Assert.False(new Inch(1).Equals(null));

        }
        
        [Test]
        public void TestGetHashCode()
        {
            Assert.True(1.0f.GetHashCode() == new Inch(1).GetHashCode());

        }
        [Test]
        public void TestConvert()
        {
            Assert.True(new Meter(1) == (Meter) new Inch(Meter.InchesPerMeter));
        }
    }
}