using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class ItemDefault : NewItem
    {
        private Item item;

        public ItemDefault( ) : base()
        {
        }

        public ItemDefault(Item item)
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
