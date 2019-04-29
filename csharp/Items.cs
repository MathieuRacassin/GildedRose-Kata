using System;
using System.Collections.Generic;

namespace csharp
{
    public class Items
    {
        private readonly IList<Item> items;

        public Items(IList<Item> itemsList)
        {
            items = itemsList;
        }

        public int GetCount()
        {
            return items.Count;
        }
    }
}