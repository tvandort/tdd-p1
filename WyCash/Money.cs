namespace WyCash {
    public abstract class Money {
        protected int amount = 10;

        public override bool Equals(object obj) {
            Money dollar = (Money)obj;
            return amount == dollar.amount && this.GetType().Equals(obj.GetType());
        }

        public static Money dollar(int amount) {
            return new Dollar(amount);
        }

        public static Money franc(int amount) {
            return new Franc(amount);
        }

        public abstract Money times(int multiplier);
    }
}
