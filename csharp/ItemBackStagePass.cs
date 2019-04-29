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

            if (Item.SellIn < 10)
            {
                IncreaseQuality();
            }
            if (Item.SellIn < 5)
            {
                IncreaseQuality();
            }
            if (Item.SellIn < 0)
            {
                Item.Quality = 0;
            }
        }
    }
}
