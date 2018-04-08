using System;

namespace WyCash {
    public class Sum : Expression {

        public Expression Augend { get; }
        public Expression Addend { get; }

        public Sum(Expression augend, Expression addend) {
            Augend = augend;
            Addend = addend;
        }

        public override Money reduce(Bank bank, string to) {
            int amount =
                Augend.reduce(bank, to).Amount + Addend.reduce(bank, to).Amount;
            return new Money(amount, to);
        }

        public override Expression times(int multiplier) {
            return new Sum(Augend.times(multiplier), Addend.times(multiplier));
        }
    }
}
