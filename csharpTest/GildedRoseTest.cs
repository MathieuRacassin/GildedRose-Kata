﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace csharp
{
    [TestClass]
    public class GildedRoseTest
    {
        [TestMethod]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("foo", Items[0].Name);
        }

        [TestMethod]
        public void NormalProductUpdateQualityAndSellInShouldDecreaseOfOneWhenQualityPositive()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "olive", SellIn = 7, Quality = 5 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("olive", Items[0].Name);
            Assert.AreEqual(4, Items[0].Quality);
            Assert.AreEqual(6, Items[0].SellIn);
        }

        [TestMethod]
        public void NormalProductUpdateQualityShouldStayAt0AndSellInShouldDecreaseOfOneWhenQualityEqualsZero()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "yaourt", SellIn = 5, Quality = 0} };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("yaourt", Items[0].Name);
            Assert.AreEqual(4, Items[0].SellIn);
            Assert.AreEqual(0, Items[0].Quality);
        }

        [TestMethod]
        public void AgedBrieUpdateQualityShouldIncreaseWhenSellInDecrease()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 6} };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Aged Brie", Items[0].Name);
            Assert.AreEqual(4, Items[0].SellIn);
            Assert.AreEqual(7, Items[0].Quality);
        }

        [TestMethod]
        public void AgedBrieQualityAt50ValueShouldStayAt50()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 50} };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Aged Brie", Items[0].Name);
            Assert.AreEqual(4, Items[0].SellIn);
            Assert.AreEqual(50, Items[0].Quality);
        }

        [TestMethod]
        public void SulfurasLegendaryProductUpdateQualityShouldNotChangeQuality()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -4, Quality = 80} };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Sulfuras, Hand of Ragnaros", Items[0].Name);
            Assert.AreEqual(-4, Items[0].SellIn);
            Assert.AreEqual(80, Items[0].Quality);
        }

        [TestMethod]
        public void BackStagesPassesProductUpdateQualityShouldIncreaseOfOneWhenSellInGreaterThan10()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 14, Quality = 7 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.AreEqual(13, Items[0].SellIn);
            Assert.AreEqual(8, Items[0].Quality);
        }

        [TestMethod]
        public void BackStagesPassesProductUpdateQualityShouldIncreaseOfOneWhenSellInLowerThan5AndQualityEquals49()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 2, Quality = 49 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.AreEqual(1, Items[0].SellIn);
            Assert.AreEqual(50, Items[0].Quality);
        }

        [TestMethod]
        public void BackStagesPassesProductUpdateQualityShouldIncreaseOfTwoWhenSellInBetween6And10()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 9, Quality = 15 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.AreEqual(8, Items[0].SellIn);
            Assert.AreEqual(17, Items[0].Quality);
        }

        [TestMethod]
        public void BackStagesPassesProductUpdateQualityShouldIncreaseOfThreeWhenSellInLowerThan5()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 3, Quality = 18 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.AreEqual(2, Items[0].SellIn);
            Assert.AreEqual(21, Items[0].Quality);
        }

        [TestMethod]
        public void BackStagesPassesProductUpdateQualityShouldEqualsToZeroWhenSellInLowerThanZero()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -1, Quality = 18 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Backstage passes to a TAFKAL80ETC concert", Items[0].Name);
            Assert.AreEqual(-2, Items[0].SellIn);
            Assert.AreEqual(0, Items[0].Quality);
        }

        [TestMethod]
        public void ConjuredProductUpdateQualityShouldDecreaseOfTwoWhenSellInEqualsZero()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 3 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("Conjured Mana Cake", Items[0].Name);
            Assert.AreEqual(-1, Items[0].SellIn);
            Assert.AreEqual(1, Items[0].Quality);
        }

        [TestMethod]
        public void NormalProductNewConstructorWithItem()
        {
            Item item = new Item { Name = "olive", SellIn = 0, Quality = 3 };
            NewItem newItem = new ItemDefault(item);
            Assert.IsInstanceOfType(newItem, typeof(ItemDefault));
        }

        [TestMethod]
        public void AgedBrieProductNewConstructorWithItem()
        {
            Item item = new Item { Name = "Aged Brie", SellIn = 0, Quality = 3 };
            NewItem newItem = new ItemAgedBrie(item);
            Assert.IsInstanceOfType(newItem, typeof(ItemAgedBrie));
        }

        [TestMethod]
        public void BackStagePassProductNewConstructorWithItem()
        {
            Item item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 3 };
            NewItem newItem = new ItemBackStagePass(item);
            Assert.IsInstanceOfType(newItem, typeof(ItemBackStagePass));
        }

        [TestMethod]
        public void SulfuraProductNewConstructorWithItem()
        {
            Item item = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 3 };
            NewItem newItem = new ItemSulfura(item);
            Assert.IsInstanceOfType(newItem, typeof(ItemSulfura));
        }

        [TestMethod]
        public void ConjuredProductNewConstructorWithItem()
        {
            Item item = new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 3 };
            NewItem newItem = new ItemConjured(item);
            Assert.IsInstanceOfType(newItem, typeof(ItemConjured));
        }

        [TestMethod]
        public void ItemsWithOneElementCountGiveOne()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 50 } };
            Items items = new Items(Items);

            int count = items.GetCount();

            Assert.AreEqual(1, count);
        }


    }
}
