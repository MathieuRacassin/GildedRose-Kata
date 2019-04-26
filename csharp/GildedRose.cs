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
                if (Items[i].Name == SULFURAS)
                {
                    continue;
                }

                DecreaseSellIn(Items[i]);

                if (Items[i].Name == AGED_BRIE || Items[i].Name == BACKSTAGE_PASSES_CONCERT)
                {
                    IncreaseQuality(Items[i]);

                    if (Items[i].Name == BACKSTAGE_PASSES_CONCERT)
                    {
                        if (Items[i].SellIn < 10)
                        {
                            IncreaseQuality(Items[i]);
                        }

                        if (Items[i].SellIn < 5)
                        {
                            IncreaseQuality(Items[i]);
                        }
                        if (Items[i].SellIn < 0)
                        {
                            Items[i].Quality = 0;
                        }
                    }

                    if (Items[i].Name == AGED_BRIE)
                    {
                        if (Items[i].SellIn < 0)
                        {
                            IncreaseQuality(Items[i]);
                        }
                    }
                }
                else
                {
                    DecreaseQuality(Items[i]);

                    if (Items[i].SellIn < 0)
                    {
                        DecreaseQuality(Items[i]);
                    }
                }
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

        private void IncreaseQuality(int itemIndex)
        {
            Items[itemIndex].Quality = Math.Min(MAX_QUALITY, Items[itemIndex].Quality + 1);
        }
        private void IncreaseQuality(Item item)
        {
            item.Quality = Math.Min(MAX_QUALITY, item.Quality + 1);
        }
    }
}
