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
        protected Item item;

        protected NewItem(Item item)
        {
            this.item = item;
        }

        public Item Item => item;

        public abstract void UpdateItem();

        protected void DecreaseSellIn()
        {
            this.item.SellIn--;
        }

        protected void DecreaseQuality()
        {
            this.item.Quality = Math.Max(MIN_QUALITY, this.item.Quality - 1);
        }
        protected void IncreaseQuality()
        {
            this.item.Quality = Math.Min(MAX_QUALITY, this.item.Quality + 1);
        }
    }
}
