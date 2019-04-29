using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public abstract class NewItem
    {
        private readonly int MAX_QUALITY = 50;
        private readonly int MIN_QUALITY = 0;

        public Item Item { get; protected set; }

        protected NewItem(Item item)
        {
            Item = item;
        }

        public abstract void UpdateItem();

        protected void DecreaseSellIn()
        {
            Item.SellIn--;
        }

        protected void DecreaseQuality()
        {
            Item.Quality = Math.Max(MIN_QUALITY, Item.Quality - 1);
        }
        protected void IncreaseQuality()
        {
            Item.Quality = Math.Min(MAX_QUALITY, Item.Quality + 1);
        }
    }
}
