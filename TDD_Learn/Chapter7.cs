using NUnit.Framework;

namespace Chapter7
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

            Assert.True(new Frank(5).Equals(new Frank(5)));
            Assert.False(new Frank(5).Equals(new Frank(6)));
            
            Assert.False(new Frank(5).Equals(new Frank(6)));
            Assert.False(new Frank(5).Equals(new Dollar(5)));
        }
    }

    public class Money
    {
        protected int Amount;
        
        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return Amount == money.Amount && GetType() == obj.GetType();
        }
    }
    
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            Amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }
    }
    
    public class Frank : Money
    {
        public Frank(int amount)
        {
            Amount = amount;
        }

        public Frank Times(int multiplier)
        {
            return new Frank(Amount * multiplier);
        }
    }
}