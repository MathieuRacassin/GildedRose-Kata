using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class ItemBackStagePass : NewItem
    {
        private Item item;

        public ItemBackStagePass() : base()
        {
        }

        public ItemBackStagePass(Item item)
        {
            this.item = item;
        }

        public override void UpdateItem()
        {
            DecreaseSellIn();
            IncreaseQuality();

            if (this.SellIn < 10)
            {
                IncreaseQuality();
            }

            if (this.SellIn < 5)
            {
                IncreaseQuality();
            }
            if (this.SellIn < 0)
            {
                this.Quality = 0;
            }
        }
    }
}
