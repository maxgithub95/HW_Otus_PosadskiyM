using Dapper;
using Npgsql;

namespace HW_16
{
    internal class DapperMethods
    {
        public static List<Customers> GetCustomersLessThenAge(int age)
        {
            using (var connection = new NpgsqlConnection(Config.SqlConnectionString))
            {
                var query = $"select firstname, age from customers where age <{age}";

                var list = connection.Query<Customers>(query);
                return list.ToList();

            }
        }
        public static int GetCountCustomers()
        {
            using (var connection = new NpgsqlConnection(Config.SqlConnectionString))
            {
                var query = $"select id from customers";

                var list = connection.Query<Customers>(query);
                return list.Count();

            }
        }
        public static List<Products> GetProductsLessPrice(decimal price)
        {
            using (var connection = new NpgsqlConnection(Config.SqlConnectionString))
            {
                var query = $"select name, stockquantity, price from Products where price::numeric <{price}";

                var list = connection.Query<Products>(query);
                return list.ToList();

            }
        }
        public static List<Products> GetProductsIdDivisibleBy(int number)
        {
            using (var connection = new NpgsqlConnection(Config.SqlConnectionString))
            {
                var query = $"select id, name from Products where id%{number}=0";

                var list = connection.Query<Products>(query);
                return list.ToList();
            }
        }
        public static bool IsEqualsIdInOrder()
        {
            using (var connection = new NpgsqlConnection(Config.SqlConnectionString))
            {
                var query = $"select customerid, productid from Orders";

                var list = connection.Query<Orders>(query);
                foreach (var item in list)
                {
                    if (item.CustomerId == item.ProductId) return true;
                }
                return false;
            }
        }
        public static int GetCountItemsInOrders()
        {
            using (var connection = new NpgsqlConnection(Config.SqlConnectionString))
            {
                var query = $"select quantity from Orders";

                var list = connection.Query<Orders>(query);
                int count = 0;
                foreach (var item in list)
                {
                    count += item.Quantity;
                }
                return count;
            }
        }
        public static List<ForJoin> GetResultHW14(int age, int id)
        {
            using (var connection = new NpgsqlConnection(Config.SqlConnectionString))
            {
                var query = $"SELECT cust.id, FirstName, LastName, prod.id, price, quantity FROM customers cust inner join orders ord on cust.ID=ord.customerid inner join products prod on prod.ID=ord.productid where age>{age} and prod.id={id}";

                var list = connection.Query<Customers, Products, Orders, ForJoin>(query, (customer, product, order) =>
                {
                    ForJoin forJoin = new ForJoin();
                    forJoin.CustomerID = customer.Id;
                    forJoin.FirstName = customer.FirstName;
                    forJoin.LastName = customer.LastName;
                    forJoin.ProductID = product.Id;
                    forJoin.ProductPrice = product.Price;
                    forJoin.ProductQuantity = order.Quantity;
                    return forJoin;
                },
                splitOn: "id, id, quantity");
                return list.ToList();
            }
        }
    }
}
