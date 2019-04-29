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

        public abstract void UpdateQuality();

        protected void DecreaseSellIn()
        {
            this.SellIn--;
        }

        protected void DecreaseQuality()
        {
            this.Quality = Math.Max(MIN_QUALITY, this.Quality - 1);
        }
        protected void IncreaseQuality()
        {
            this.Quality = Math.Min(MAX_QUALITY, this.Quality + 1);
        }
    }
}
