namespace WyCash {
    public interface IExpression {
        Money reduce(Bank bank, string to);
    }
}
