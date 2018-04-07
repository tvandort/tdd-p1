namespace WyCash {
    public class Money {
        private string currency;
        private int amount;

        public Money(int amount, string currency) {
            this.amount = amount;
            this.Currency = currency;
        }

        public int Amount {
            get { return amount; }
            private set { amount = value; }
        }

        public string Currency {
            get { return currency; }
            private set { currency = value; }
        }

        public Money times(int multiplier) {
            return new Money(Amount * multiplier, Currency);
        }

        public override bool Equals(object obj) {
            Money money = (Money)obj;
            return Amount == money.Amount && Currency.Equals(money.Currency);
        }

        public static Money dollar(int amount) {
            return new Money(amount, "USD");
        }

        public static Money franc(int amount) {
            return new Money(amount, "CHF");
        }

        public string toString() {
            return $"{Amount} {Currency}";
        }
    }
}
