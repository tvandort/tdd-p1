namespace WyCash {
    public interface IExpression {
        Money reduce(Bank bank, string to);
        IExpression plus(IExpression addend);
        IExpression times(int multiplier);
    }
}
