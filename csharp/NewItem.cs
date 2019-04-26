using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public abstract class NewItem :Item
    {
        readonly int MAX_QUALITY = 50;
        readonly int MIN_QUALITY = 0;

        private Item item;

        public NewItem(Item item)
        {
            this.item = item;
        }

        public static NewItem CreateItem(Item item)
        {
            
            switch (item.Name)
            {
                case ItemType.AGED_BRIE:
                    return new ItemAgedBrie(item);
                case ItemType.BACKSTAGE_PASSES_CONCERT:
                    return new ItemBackStagePass(item) ;
                case ItemType.SULFURAS:
                    return new ItemSulfura(item);
                  default:
                    return new ItemDefault(item);
            }
        }

        public abstract void UpdateQuality();

        protected void DecreaseSellIn(Item item)
        {
            item.SellIn--;
        }

        protected void DecreaseQuality(Item item)
        {
            item.Quality = Math.Max(MIN_QUALITY, item.Quality - 1);
        }
        protected void IncreaseQuality(Item item)
        {
            item.Quality = Math.Min(MAX_QUALITY, item.Quality + 1);
        }
    }
}
