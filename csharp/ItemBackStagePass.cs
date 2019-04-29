using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class ItemBackStagePass : NewItem
    {
        public ItemBackStagePass() : base()
        {
        }

        public override void UpdateQuality()
        {
            DecreaseSellIn();
            IncreaseQuality();

            if (this.SellIn < 10)
            {
                IncreaseQuality();
            }

            if (this.SellIn < 5)
            {
                IncreaseQuality();
            }
            if (this.SellIn < 0)
            {
                this.Quality = 0;
            }
        }
    }
}
