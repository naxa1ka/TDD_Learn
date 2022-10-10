using NUnit.Framework;

namespace Chapter5
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            Assert.AreEqual(new Dollar(10), five.Times(2));
            Assert.AreEqual(new Dollar(15), five.Times(3));
        }

        [Test]
        public void TestFrankMultiplication()
        {
            Frank five = new Frank(5);
            Assert.AreEqual(new Frank(10), five.Times(2));
            Assert.AreEqual(new Frank(15), five.Times(3));
        }
        
        [Test]
        public void testEquality()
        {
            Assert.True(new Dollar(5).Equals(new Dollar(5)));
            Assert.False(new Dollar(5).Equals(new Dollar(6)));
        }
    }

    public class Dollar
    {
        private readonly int _amount;

        public Dollar(int amount)
        {
            _amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(_amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            Dollar dollar = (Dollar)obj;
            return _amount == dollar._amount;
        }
    }
    
    public class Frank
    {
        private readonly int _amount;

        public Frank(int amount)
        {
            _amount = amount;
        }

        public Frank Times(int multiplier)
        {
            return new Frank(_amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            Frank dollar = (Frank)obj;
            return _amount == dollar._amount;
        }
    }
}