using System;

namespace WyCash {
    public class Sum : IExpression {

        public IExpression Augend { get; }
        public IExpression Addend { get; }

        public Sum(IExpression augend, IExpression addend) {
            Augend = augend;
            Addend = addend;
        }

        public Money reduce(Bank bank, string to) {
            int amount =
                Augend.reduce(bank, to).Amount + Addend.reduce(bank, to).Amount;
            return new Money(amount, to);
        }

        public IExpression plus(IExpression addend) {
            return new Sum(this, addend);
        }

        public IExpression times(int multiplier) {
            return new Sum(Augend.times(multiplier), Addend.times(multiplier));
        }
    }
}
