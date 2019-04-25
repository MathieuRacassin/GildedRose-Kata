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
                if(Items[i].Name == SULFURAS)
                {
                    continue;
                }


                if (Items[i].Name != AGED_BRIE && Items[i].Name != BACKSTAGE_PASSES_CONCERT)
                {
                        DecreaseQuality(i);
                       
                }
                else
                {
                    IncreaseQuality(i);

                    if (Items[i].Name == BACKSTAGE_PASSES_CONCERT)
                    {
                        if (Items[i].SellIn < 11)
                        {
                            IncreaseQuality(i);
                        }

                        if (Items[i].SellIn < 6)
                        {
                            IncreaseQuality(i);
                        }
                    }

                }

                DecreaseSellIn(i);


                if (Items[i].SellIn < 0)
                {
                    if (Items[i].Name != AGED_BRIE)
                    {
                        if (Items[i].Name != BACKSTAGE_PASSES_CONCERT)
                        {
                            DecreaseQuality(i);
                        }
                        else
                        {
                            Items[i].Quality = Items[i].Quality - Items[i].Quality;
                        }
                    }
                    else
                    {
                         IncreaseQuality(i);
                    }
                }
            }
        }

        private void DecreaseSellIn(int i)
        {
            Items[i].SellIn--;
        }

        private void DecreaseQuality(int itemIndex)
        {
            Items[itemIndex].Quality = Math.Max(MIN_QUALITY, Items[itemIndex].Quality - 1);
        }

        private void IncreaseQuality(int itemIndex)
        {
            Items[itemIndex].Quality = Math.Min(MAX_QUALITY, Items[itemIndex].Quality + 1);
        }
    }
}
