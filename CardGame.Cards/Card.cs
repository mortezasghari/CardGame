using CardGame.Cards.Details;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Cards
{
    public class Card : IEquatable<Card>, IComparable<Card>
    {
        public CardNumber Number { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(int cardId)
        {
            if (cardId < 0 || cardId > 53)
            {
                throw new ArgumentOutOfRangeException("CardId is out of range");
            }

            Suit = CardSuit.FromValue(cardId / 13);
            Number = CardNumber.FromValue(cardId % 13);
        }

        public Card(CardSuit suit, CardNumber number)
        {
            if (suit is null || number is null)
            {
                throw new ArgumentOutOfRangeException("Suit or Number is out of range");
            }

            Suit = suit;
            Number = number;
        }

        public override string ToString() => $"{Number}{Suit}";

        public bool Equals(Card? other)
        {
            if (other is null)
            {
                return false;
            }

            return other.Suit == this.Suit && other.Number == this.Number;
        }

        public int CompareTo(Card? other)
        {
            return this.Number.CompareTo(other?.Number);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Card other)
            {
                return this.Equals(other);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Suit, this.Number);
        }

        public static bool operator ==(Card left, Card right)
        {
            if (left is null)
            {
                return right is null;
            }

            return left.Equals(right);
        }

        public static bool operator !=(Card left, Card right)
        {
            return !(left == right);
        }

        public static bool operator <(Card left, Card right)
        {
            return left is null ? right is not null : left.CompareTo(right) < 0;
        }

        public static bool operator <=(Card left, Card right)
        {
            return left is null || left.CompareTo(right) <= 0;
        }

        public static bool operator >(Card left, Card right)
        {
            return left is not null && left.CompareTo(right) > 0;
        }

        public static bool operator >=(Card left, Card right)
        {
            return left is null ? right is null : left.CompareTo(right) >= 0;
        }

        public static Card Parse(string input)
        {
            return new Card(CardSuit.FromName(input[^1..]), CardNumber.FromName(input[..^1]));
        }

        public static bool TryParse(string input, out Card? card)
        {
            if (CardSuit.TryFromName(input[^1..], out CardSuit suit) && CardNumber.TryFromName(input[..^1], out CardNumber number))
            {
                card = new(suit, number);
                return true;
            }

            card = null;
            return false;
        }

        public static bool IsSameSuit(params Card[] cards)
        {
            if (cards is null)
            {
                return false;
            }

            if (cards.Length == 0)
            {
                return true;
            }

            return cards.All(c => c.Suit == cards[0].Suit);
        }

        public static bool IsSameNumber(params Card[] cards)
        {
            if (cards is null)
            {
                return false;
            }

            if (cards.Length == 0)
            {
                return true;
            }

            return cards.All(c => c.Number == cards[0].Number);
        }

        public static bool IsConsecutive(params Card[] cards)
        {
            if (cards is null)
            {
                return false;
            }

            if (cards.Length == 0)
            {
                return true;
            }

            Array.Sort(cards);
            return !cards.Select(c => c.Number.Value).Select((i, j) => i - j).Distinct().Skip(1).Any();
        }
    }
}
