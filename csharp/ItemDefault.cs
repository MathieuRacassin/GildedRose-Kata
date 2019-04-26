using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class ItemDefault : NewItem
    {
        public ItemDefault(Item item) : base(item)
        {
        }

        public override void UpdateQuality()
        {
            DecreaseQuality(this);
            DecreaseSellIn(this);

            if (this.SellIn < 0)
            {
                DecreaseQuality(this);
            }
        }
    }
}
