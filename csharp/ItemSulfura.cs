using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class ItemSulfura : NewItem
    {

        public ItemSulfura(Item item):base(item)
        {
            this.item = item;
        }

        public override void UpdateItem()
        {
        } 
    }
}
