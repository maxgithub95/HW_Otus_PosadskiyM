using System.Collections.ObjectModel;

namespace HW_12_Shop
{
    public class Shop
    {
        public string Name { get; set; }
        public readonly ObservableCollection<Item> Catalog = new ObservableCollection<Item>();
        static private int IdCounter = 0;

        public Shop(string name)
        {
            Name = name;
        }

        public class Item
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Item(string name)
            {
                IdCounter++;
                Name = name;
                Id = IdCounter;
               
            }

        }

        public void Add(string _item)
        {
            Item newItem = new Item(_item);
            Catalog.Add(newItem);
        }

        public void Remove(int idToRemove)
        {
            Item? itemToRemove = Catalog.SingleOrDefault(item => item.Id == idToRemove);

            if (itemToRemove == null)
            {
                Console.WriteLine($"Товара с ID {idToRemove} не существует");
            }
            else
            {
                Catalog.Remove(itemToRemove);
            }


        }

        public void ShowCatalog()
        {
            int i = 1;
            foreach (Item item in Catalog)
            {
                Console.WriteLine($"{i}) ID: {item.Id}, Name: {item.Name}");
                i++;
            }
        }
    }
}