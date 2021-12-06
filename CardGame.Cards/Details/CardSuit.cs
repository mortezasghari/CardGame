using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Cards.Details
{
    public sealed class CardSuit : SmartEnum<CardSuit>
    {
        public static readonly CardSuit Spades = new("♠", 0);
        public static readonly CardSuit Hearts = new("♥", 1);
        public static readonly CardSuit Clubs = new("♣", 2);
        public static readonly CardSuit Diamonds = new("♦", 3);

        private CardSuit(string name, int value) : base(name, value)
        {

        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
