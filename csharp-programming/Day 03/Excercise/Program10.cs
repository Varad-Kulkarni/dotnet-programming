namespace Excercise {
    enum CardSuite {
        Hearts,
        Diamonds,
        Clubs,
        Spade
    }

    enum CardRank {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    class Card {
        private CardSuite suit;
        private CardRank rank;

        public CardSuite Suit {
            get { return this.suit; }
            set { this.suit = value; }
        }
        public CardRank Rank {
            get { return this.rank; }
            set { this.rank = value; }
        }

        public int GetValue() {
            return (int)this.rank + 1;
        }
    }

    class Program {
        public static void Main(string[] args) {
            Card card = new Card();
            card.Suit = CardSuite.Diamonds;
            card.Rank = CardRank.Three;
            Console.WriteLine(card.GetValue());
        }
    }
}
