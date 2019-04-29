using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class ItemConjured : NewItem
    {
        private Item item;

        public ItemConjured() : base()
        {
        }

        public ItemConjured(Item item)
        {
            this.item = item;
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
