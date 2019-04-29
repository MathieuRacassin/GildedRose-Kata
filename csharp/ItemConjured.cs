using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class ItemConjured : NewItem
    {
        public ItemConjured() : base()
        {
        }

        public override void UpdateItem()
        {
            DecreaseQuality();
            DecreaseSellIn();

            if (this.SellIn < 0)
            {
                DecreaseQuality();
            }
        }
    }
}
