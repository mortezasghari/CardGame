using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Cards.Details
{
    public sealed class CardNumber : SmartEnum<CardNumber>
    {
        public static readonly CardNumber Two = new("2", 0);
        public static readonly CardNumber Three = new("3", 1);
        public static readonly CardNumber Four = new("4", 2);
        public static readonly CardNumber Five = new("5", 3);
        public static readonly CardNumber Six = new("6", 4);
        public static readonly CardNumber Seven = new("7", 5);
        public static readonly CardNumber Eight = new("8", 6);
        public static readonly CardNumber Nine = new("9", 7);
        public static readonly CardNumber Ten = new("10", 8);
        public static readonly CardNumber Jack = new("J", 9);
        public static readonly CardNumber Queen = new("Q", 10);
        public static readonly CardNumber King = new("K", 11);
        public static readonly CardNumber Ace = new("A", 12);

        private CardNumber(string name, int value) : base(name, value)
        {
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
