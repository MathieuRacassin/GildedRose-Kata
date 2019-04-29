using System;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                NewItem newItem = NewItemFactory.Create(Items[i]);
                newItem.UpdateItem();
                Items[i] = newItem.Item;
            }
        }
    }
}
