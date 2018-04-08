using System;

namespace WyCash {
    public class Money : Expression {
        public string Currency { get; }
        public int Amount { get; }

        public Money(int amount, string currency) {
            Amount = amount;
            Currency = currency;
        }

        public override Expression times(int multiplier) {
            return new Money(Amount * multiplier, Currency);
        }

        public override Money reduce(Bank bank, String to) {
            int rate = bank.rate(Currency, to);
            return new Money(Amount / rate, to);
        }

        public override bool Equals(object obj) {
            Money money = (Money) obj;
            return Amount == money.Amount && Currency.Equals(money.Currency);
        }

        public override string ToString() {
            return $"{Amount} {Currency}";
        }

        public static Money dollar(int amount) {
            return new Money(amount, "USD");
        }

        public static Money franc(int amount) {
            return new Money(amount, "CHF");
        }
    }
}
