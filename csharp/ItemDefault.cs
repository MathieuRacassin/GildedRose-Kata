using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class ItemDefault : NewItem
    {
        public ItemDefault( ) : base()
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
