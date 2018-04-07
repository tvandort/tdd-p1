using WyCash;
using Xunit;

namespace WyCash.Tests {
    public class MoneyTests {
        [Fact]
        public void testCurrency() {
            Assert.Equal("USD", Money.dollar(1).Currency);
            Assert.Equal("CHF", Money.franc(1).Currency);
        }

        [Fact]
        public void testDifferentClassEquality() {
            Assert.True(new Money(10, "CHF").Equals(Money.franc(10)));
        }

        [Fact]
        public void testMultiplication() {
            Money five = Money.dollar(5);
            Assert.Equal(Money.dollar(10), five.times(2));
            Assert.Equal(Money.dollar(15), five.times(3));
        }

        [Fact]
        public void testEquality() {
            Assert.True(Money.dollar(5).Equals(Money.dollar(5)));
            Assert.False(Money.dollar(5).Equals(Money.dollar(6)));
            Assert.False(Money.franc(5).Equals(Money.dollar(5)));
        }
    }
}
