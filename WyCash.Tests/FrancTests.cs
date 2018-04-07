using WyCash;
using Xunit;

namespace WyCash.Tests {
    public class FrancTests {
        [Fact]
        public void testMultiplication() {
            Money five = Money.franc(5);
            Assert.Equal(Money.franc(10), five.times(2));
            Assert.Equal(Money.franc(15), five.times(3));
        }

        [Fact]
        public void testEquality() {
            Assert.True(Money.franc(5).Equals(Money.franc(5)));
            Assert.False(Money.franc(5).Equals(Money.franc(6)));
        }
    }
}
