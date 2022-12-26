using System.Collections.Specialized;

namespace HW_12_Shop
{
    public class Customer
    {
        private Shop FavShop;
        private string Name;

        public Customer(string name)
        {
            Name = name;
        }

        public void Subscribe(Shop myShop)
        {
            FavShop = myShop;
            FavShop.Catalog.CollectionChanged += OnItemChanged;
            Console.WriteLine($"{Name} подписался на изменения в каталоге {FavShop.Name}");
        }
        public void UnSubscribe(Shop myShop)
        {
            FavShop.Catalog.CollectionChanged -= OnItemChanged;
            Console.WriteLine($"{Name} отписался от изменений в каталоге {FavShop.Name}");
        }

        private void OnItemChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    //Shop.Item AddItem = (Shop.Item)e.NewItems[e.NewStartingIndex]; - не работает
                    Shop.Item AddItem = (Shop.Item)e.NewItems[0];
                    Console.WriteLine($"Добавлен товар ID: {AddItem.Id}, Name: {AddItem.Name}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    //Shop.Item RemoveItem = (Shop.Item)e.OldItems[e.OldStartingIndex]; - не работает
                    Shop.Item RemoveItem = (Shop.Item)e.OldItems[0];
                    Console.WriteLine($"Удален товар ID: {RemoveItem.Id}, Name: {RemoveItem.Name}");
                    break;
            }
        }
    }
}