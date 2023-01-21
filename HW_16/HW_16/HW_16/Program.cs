namespace HW_16
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первый запрос: Покупатели до 25 лет!");
            var customersByAge = DapperMethods.GetCustomersLessThenAge(25);
            foreach (var customer in customersByAge)
                Console.WriteLine($"{customer.FirstName} - {customer.Age}");
            Console.WriteLine();
            Console.WriteLine("Второй запрос: Количество покупателей!");
            Console.WriteLine($"Количество покупателей - {DapperMethods.GetCountCustomers()}");
            Console.WriteLine();
            Console.WriteLine("Третий запрос: Товары стоимостью до 1000!");
            var product1000 = DapperMethods.GetProductsLessPrice(1000);
            foreach (var item in product1000)
                Console.WriteLine($"{item.Name} - {item.StockQuantity} шт. Стоимость: {item.Price} ");
            Console.WriteLine();
            Console.WriteLine("Четвертый запрос: Id делится на 3");
            var productIdDiviseble = DapperMethods.GetProductsIdDivisibleBy(3);
            foreach (var item in productIdDiviseble)
                Console.WriteLine($"{item.Id} - {item.Name};");
            Console.WriteLine();
            Console.WriteLine("Пятый запрос: Есть ли заказы с совпадающим id у товара и покупателя!");
            var orderEquals = DapperMethods.IsEqualsIdInOrder();
            if (orderEquals)
                Console.WriteLine($"Есть совпадения");
            else
                Console.WriteLine($"нет совпадений");
            Console.WriteLine();
            Console.WriteLine("Шестой запрос: Общее количество товаров во всех заказах!");
            var CountProducts = DapperMethods.GetCountItemsInOrders();
            Console.WriteLine($"Общее количество товаров - {CountProducts}");
            Console.WriteLine();
        }
    }
}