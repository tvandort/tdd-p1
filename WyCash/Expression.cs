namespace WyCash {
    public abstract class Expression {
        public abstract Expression times(int multiplier);
        public abstract Money reduce(Bank bank, string to);

        public Expression plus(Expression addend) {
            return new Sum(this, addend);
        }
    }
}
