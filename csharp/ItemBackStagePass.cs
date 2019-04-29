using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class ItemBackStagePass : NewItem
    {
        public ItemBackStagePass(Item item):base(item)
        {
        }

        public override void UpdateItem()
        {
            DecreaseSellIn();
            IncreaseQuality();

            if (this.item.SellIn < 10)
            {
                IncreaseQuality();
            }

            if (this.item.SellIn < 5)
            {
                IncreaseQuality();
            }
            if (this.item.SellIn < 0)
            {
                this.item.Quality = 0;
            }
        }
    }
}
