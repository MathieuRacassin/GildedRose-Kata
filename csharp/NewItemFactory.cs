namespace csharp
{
    public static class NewItemFactory
    {
        public static NewItem Create(Item item)
        {
            switch (item.Name)
            {
                case ItemType.AGED_BRIE:
                    return new ItemAgedBrie(item);
                case ItemType.BACKSTAGE_PASSES_CONCERT:
                    return new ItemBackStagePass(item);
                case ItemType.SULFURAS:
                    return new ItemSulfura(item);
                case ItemType.CONJURED:
                    return new ItemConjured(item);
                default:
                    return new ItemDefault(item);
            }
        }
    }
}
