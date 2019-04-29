using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class ItemAgedBrie : NewItem
    {
        private Item item;

        public ItemAgedBrie(): base()
        {
        }

        public ItemAgedBrie(Item item)
        {
            this.item = item;
        }

        public override void UpdateItem()
        {
            DecreaseSellIn();
            IncreaseQuality();

            if (this.SellIn < 0)
            {
                IncreaseQuality();
            }
        }
    }
}
