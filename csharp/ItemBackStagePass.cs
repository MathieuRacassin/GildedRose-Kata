using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class ItemBackStagePass : NewItem
    {
        public ItemBackStagePass(Item item) : base(item)
        {
        }

        public override void UpdateQuality()
        {
            DecreaseSellIn(this);
            IncreaseQuality(this);

            if (this.SellIn < 10)
            {
                IncreaseQuality(this);
            }

            if (this.SellIn < 5)
            {
                IncreaseQuality(this);
            }
            if (this.SellIn < 0)
            {
                this.Quality = 0;
            }
        }
    }
}
