using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void negativeQuality()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "CherryCake", SellIn = 10, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(0, Items[0].Quality);
        }

        [Test]
        public void sameQuality()
        {
            IList<Item> Items = new List<Item> { new Sulfuras { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 15 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(15, Items[0].Quality);
        }

        [Test]
        public void expiredQuality()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Camembert", SellIn = -3, Quality = 10 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(8, Items[0].Quality);
        }

        [Test]
        public void improveQuality()
        {
            IList<Item> Items = new List<Item> { new AgedBrie { Name = "Aged Brie", SellIn = 9, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(21, Items[0].Quality);
        }

        [Test]
        public void doubleQuality()
        {
            IList<Item> Items = new List<Item> { new Backstage { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(22, Items[0].Quality);
        }

        [Test]
        public void tripleQuality()
        {
            IList<Item> Items = new List<Item> { new Backstage { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(23, Items[0].Quality);
        }

        [Test]
        public void negativeSellIn()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Bananas", SellIn =0, Quality = 3 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(-1, Items[0].SellIn);
        }
        [Test]
        public void nullQuality()
        {
            IList<Item> Items = new List<Item> { new Backstage { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 30 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(0, Items[0].Quality);
        }

        [Test]
        public void maxQuality()
        {
            IList<Item> Items = new List<Item> { new AgedBrie { Name = "Aged Brie", SellIn = 15, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(50, Items[0].Quality);
        }

        [Test]
        public void legendQuality()
        {
            IList<Item> Items = new List<Item> { new Sulfuras { Name = "Sulfuras, Hand of Ragnaros", SellIn = 17, Quality = 80 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(80, Items[0].Quality);
        }
    }

}
