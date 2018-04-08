using System.Collections.Generic;

namespace WyCash {
    public class Bank {
        private Dictionary<Pair, int> rates = new Dictionary<Pair, int>();

        public Money reduce(Expression source, string to) {
            return source.reduce(this, to);
        }

        public int rate(string from, string to) {
            if (from.Equals(to)) return 1;
            return rates[new Pair(from, to)];
        }

        public void addRate(string from, string to, int rate) {
            rates.Add(new Pair(from, to), rate);
        }

        private class Pair {
            private string From { get; }
            private string To { get; }

            public Pair(string from, string to) {
                From = from;
                To = to;
            }

            public override bool Equals(object obj) {
                Pair pair = (Pair) obj;
                return From.Equals(pair.From) && To.Equals(pair.To);
            }

            public override int GetHashCode() {
                return 0;
            }
        }
    }

}
