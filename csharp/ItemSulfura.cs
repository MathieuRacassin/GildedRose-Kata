using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class ItemSulfura : NewItem
    {
        private Item item;

        public ItemSulfura() : base()
        {
        }

        public ItemSulfura(Item item)
        {
            this.item = item;
        }

        public override void UpdateItem()
        {
        } 
    }
}
