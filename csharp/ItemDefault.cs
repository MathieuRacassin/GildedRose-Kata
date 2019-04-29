using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class ItemDefault : NewItem
    {
        public ItemDefault(Item item): base(item)
        {
        }

        public override void UpdateItem()
        {
            DecreaseQuality();
            DecreaseSellIn();

            if (this.item.SellIn < 0)
            {
                DecreaseQuality();
            }
        }
    }
}
