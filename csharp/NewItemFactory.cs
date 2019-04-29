using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public static class NewItemFactory
    {
        public static NewItem Create(Item item)
        {
            switch (item.Name)
            {
                case ItemType.AGED_BRIE:
                    return new ItemAgedBrie() { Name = item.Name, Quality = item.Quality, SellIn = item.SellIn };
                case ItemType.BACKSTAGE_PASSES_CONCERT:
                    return new ItemBackStagePass() { Name = item.Name, Quality = item.Quality, SellIn = item.SellIn };
                case ItemType.SULFURAS:
                    return new ItemSulfura() { Name = item.Name, Quality = item.Quality, SellIn = item.SellIn };
                default:
                    return new ItemDefault() { Name = item.Name, Quality = item.Quality, SellIn = item.SellIn };
            }
        }
    }
}
