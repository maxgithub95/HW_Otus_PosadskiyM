using Dapper;
using Npgsql;
using System.Diagnostics;

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
                    if (item.CustomerId==item.ProductId) return true;
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
    }
}
