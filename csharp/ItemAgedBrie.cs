using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class ItemAgedBrie : NewItem
    {
        public ItemAgedBrie(Item item): base(item)
        {
        }

        public override void UpdateItem()
        {
            DecreaseSellIn();
            IncreaseQuality();

            if (Item.SellIn < 0)
            {
                IncreaseQuality();
            }
        }
    }
}
