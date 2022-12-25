using System.Collections.ObjectModel;

namespace HW_12_Shop
{
    internal class Shop
    {
        public readonly ObservableCollection<Item> Catalog = new ObservableCollection<Item>();
        public Shop()
        {
        }


        public class Item
        {
            internal int Id { get; set; }
            internal string Name { get; set; }
            public Item(string name)
            {
                Name = name;

            }

        }
    }
}