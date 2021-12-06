using CardGame.Cards;
using CardGame.Cards.Details;
using NUnit.Framework;

namespace CardGame.Test
{
    public class CardTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0, "2♠")]
        [TestCase(1, "3♠")]
        [TestCase(2, "4♠")]
        [TestCase(3, "5♠")]
        [TestCase(4, "6♠")]
        [TestCase(5, "7♠")]
        [TestCase(6, "8♠")]
        [TestCase(7, "9♠")]
        [TestCase(8, "10♠")]
        [TestCase(9, "J♠")]
        [TestCase(10, "Q♠")]
        [TestCase(11, "K♠")]
        [TestCase(12, "A♠")]
        [TestCase(13, "2♥")]
        [TestCase(14, "3♥")]
        [TestCase(15, "4♥")]
        [TestCase(16, "5♥")]
        [TestCase(17, "6♥")]
        [TestCase(18, "7♥")]
        [TestCase(19, "8♥")]
        [TestCase(20, "9♥")]
        [TestCase(21, "10♥")]
        [TestCase(22, "J♥")]
        [TestCase(23, "Q♥")]
        [TestCase(24, "K♥")]
        [TestCase(25, "A♥")]
        [TestCase(26, "2♣")]
        [TestCase(27, "3♣")]
        [TestCase(28, "4♣")]
        [TestCase(29, "5♣")]
        [TestCase(30, "6♣")]
        [TestCase(31, "7♣")]
        [TestCase(32, "8♣")]
        [TestCase(33, "9♣")]
        [TestCase(34, "10♣")]
        [TestCase(35, "J♣")]
        [TestCase(36, "Q♣")]
        [TestCase(37, "K♣")]
        [TestCase(38, "A♣")]
        [TestCase(39, "2♦")]
        [TestCase(40, "3♦")]
        [TestCase(41, "4♦")]
        [TestCase(42, "5♦")]
        [TestCase(43, "6♦")]
        [TestCase(44, "7♦")]
        [TestCase(45, "8♦")]
        [TestCase(46, "9♦")]
        [TestCase(47, "10♦")]
        [TestCase(48, "J♦")]
        [TestCase(49, "Q♦")]
        [TestCase(50, "K♦")]
        [TestCase(51, "A♦")]
        public void Test_Id(int id, string text)
        {
            Card card = new(id);

            Assert.AreEqual(card.ToString(), text);
        }

        [TestCase(0, "2♠")]
        [TestCase(1, "3♠")]
        [TestCase(2, "4♠")]
        [TestCase(3, "5♠")]
        [TestCase(4, "6♠")]
        [TestCase(5, "7♠")]
        [TestCase(6, "8♠")]
        [TestCase(7, "9♠")]
        [TestCase(8, "10♠")]
        [TestCase(9, "J♠")]
        [TestCase(10, "Q♠")]
        [TestCase(11, "K♠")]
        [TestCase(12, "A♠")]
        [TestCase(13, "2♥")]
        [TestCase(14, "3♥")]
        [TestCase(15, "4♥")]
        [TestCase(16, "5♥")]
        [TestCase(17, "6♥")]
        [TestCase(18, "7♥")]
        [TestCase(19, "8♥")]
        [TestCase(20, "9♥")]
        [TestCase(21, "10♥")]
        [TestCase(22, "J♥")]
        [TestCase(23, "Q♥")]
        [TestCase(24, "K♥")]
        [TestCase(25, "A♥")]
        [TestCase(26, "2♣")]
        [TestCase(27, "3♣")]
        [TestCase(28, "4♣")]
        [TestCase(29, "5♣")]
        [TestCase(30, "6♣")]
        [TestCase(31, "7♣")]
        [TestCase(32, "8♣")]
        [TestCase(33, "9♣")]
        [TestCase(34, "10♣")]
        [TestCase(35, "J♣")]
        [TestCase(36, "Q♣")]
        [TestCase(37, "K♣")]
        [TestCase(38, "A♣")]
        [TestCase(39, "2♦")]
        [TestCase(40, "3♦")]
        [TestCase(41, "4♦")]
        [TestCase(42, "5♦")]
        [TestCase(43, "6♦")]
        [TestCase(44, "7♦")]
        [TestCase(45, "8♦")]
        [TestCase(46, "9♦")]
        [TestCase(47, "10♦")]
        [TestCase(48, "J♦")]
        [TestCase(49, "Q♦")]
        [TestCase(50, "K♦")]
        [TestCase(51, "A♦")]
        public void Test_Parse(int id, string text)
        {
            Card card = Card.Parse(text);
            Card card1 = new(id);

            Assert.AreEqual(card.Suit, card1.Suit);
            Assert.AreEqual(card.Number, card1.Number);
        }

        [TestCase(0, "2♠")]
        [TestCase(1, "3♠")]
        [TestCase(2, "4♠")]
        [TestCase(3, "5♠")]
        [TestCase(4, "6♠")]
        [TestCase(5, "7♠")]
        [TestCase(6, "8♠")]
        [TestCase(7, "9♠")]
        [TestCase(8, "10♠")]
        [TestCase(9, "J♠")]
        [TestCase(10, "Q♠")]
        [TestCase(11, "K♠")]
        [TestCase(12, "A♠")]
        [TestCase(13, "2♥")]
        [TestCase(14, "3♥")]
        [TestCase(15, "4♥")]
        [TestCase(16, "5♥")]
        [TestCase(17, "6♥")]
        [TestCase(18, "7♥")]
        [TestCase(19, "8♥")]
        [TestCase(20, "9♥")]
        [TestCase(21, "10♥")]
        [TestCase(22, "J♥")]
        [TestCase(23, "Q♥")]
        [TestCase(24, "K♥")]
        [TestCase(25, "A♥")]
        [TestCase(26, "2♣")]
        [TestCase(27, "3♣")]
        [TestCase(28, "4♣")]
        [TestCase(29, "5♣")]
        [TestCase(30, "6♣")]
        [TestCase(31, "7♣")]
        [TestCase(32, "8♣")]
        [TestCase(33, "9♣")]
        [TestCase(34, "10♣")]
        [TestCase(35, "J♣")]
        [TestCase(36, "Q♣")]
        [TestCase(37, "K♣")]
        [TestCase(38, "A♣")]
        [TestCase(39, "2♦")]
        [TestCase(40, "3♦")]
        [TestCase(41, "4♦")]
        [TestCase(42, "5♦")]
        [TestCase(43, "6♦")]
        [TestCase(44, "7♦")]
        [TestCase(45, "8♦")]
        [TestCase(46, "9♦")]
        [TestCase(47, "10♦")]
        [TestCase(48, "J♦")]
        [TestCase(49, "Q♦")]
        [TestCase(50, "K♦")]
        [TestCase(51, "A♦")]
        public void Test_TryParse(int id, string text)
        {
            Card card1 = new(id);
            if (Card.TryParse(text, out Card card))
            {
                Assert.AreEqual(card.Suit, card1.Suit);
                Assert.AreEqual(card.Number, card1.Number);
                return;
            }

            Assert.Fail();
        }
    }
}