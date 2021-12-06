using CardGame.Cards;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Test
{
    public class CardTest_StaticFunction
    {
        [TestCase(true)]
        [TestCase(true, 0, 12)]
        [TestCase(false, 0, 10, 20, 30)]
        [TestCase(true, 0, 1, 2, 3)]
        [TestCase(true, 14, 15, 16, 17)]
        [TestCase(true, 30, 31, 32, 33)]
        public void Test_IsSameSuit(bool result, params int[] cardIds)
        {
            List<Card> cards = new();
            foreach (var item in cardIds)
            {
                cards.Add(new Card(item));
            }

            Assert.AreEqual(result, Card.IsSameSuit(cards.ToArray()));
        }

        [TestCase(true, 0, 13)]
        [TestCase(false, 0, 10, 20, 30)]
        [TestCase(true, 0, 13, 26, 39)]
        public void Test_IsSameNumber(bool result, params int[] cardIds)
        {
            List<Card> cards = new();
            foreach (var item in cardIds)
            {
                cards.Add(new Card(item));
            }

            Assert.AreEqual(result, Card.IsSameNumber(cards.ToArray()));
        }

        [TestCase(true)]
        [TestCase(true, 1, 2, 3, 4)]
        [TestCase(true, 1, 2, 4, 3)]
        [TestCase(true, 39, 27, 15, 3)]
        [TestCase(false, 0, 1, 2, 4)]
        public void Test_IsConsecutive(bool result, params int[] cardIds)
        {
            List<Card> cards = new();
            foreach (var item in cardIds)
            {
                cards.Add(new Card(item));
            }

            Assert.AreEqual(result, Card.IsConsecutive(cards.ToArray()));
        }

        [Test]
        public void TestNullCheck()
        {
            Assert.IsFalse(Card.IsSameSuit(null));
            Assert.IsFalse(Card.IsSameNumber(null));
            Assert.IsFalse(Card.IsConsecutive(null));
        }
    }
}
