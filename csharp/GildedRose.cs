using System;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        readonly string AGED_BRIE = "Aged Brie";
        readonly string BACKSTAGE_PASSES_CONCERT = "Backstage passes to a TAFKAL80ETC concert";
        readonly string SULFURAS = "Sulfuras, Hand of Ragnaros";
        readonly int MAX_QUALITY = 50;
        readonly int MIN_QUALITY = 0;

        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                NewItem newItem = NewItemFactory.Create(Items[i]);
                newItem.UpdateItem();
                Items[i] = (Item)newItem;
            }
        }

        private void DecreaseSellIn(Item item)
        {
            item.SellIn--;
        }

        private void DecreaseQuality(Item item)
        {
            item.Quality = Math.Max(MIN_QUALITY, item.Quality - 1);
        }

        private void IncreaseQuality(Item item)
        {
            item.Quality = Math.Min(MAX_QUALITY, item.Quality + 1);
        }
    }
}
