namespace DZ6_1
{
    static class Program
    {
        static void Main()
        {
            var Planet1 = new
            {
                Title = "Венера",
                NumberFromTheSun = 2,
                Equator = 38025,
                PreviousPlanet = (object)null
            };

            var Planet2 = new
            {
                Title = "Земля",
                NumberFromTheSun = 3,
                Equator = 40075,
                PreviousPlanet = Planet1.Title //создал ссылку на название предыдущей планеты, а не на весь объект, т.к. вывод в консоль при ссылке на весь объект получается не очень удобным для чтения.
            };

            var Planet3 = new
            {
                Title = "Марс",
                NumberFromTheSun = 4,
                Equator = 21344,
                PreviousPlanet = Planet2.Title//аналогично
            };

            var Planet4 = new
            {
                Title = "Венера",
                NumberFromTheSun = 2,
                Equator = 38025,
                PreviousPlanet = (object)null
            };
            List<object> Planets = new List<object> { Planet1, Planet2, Planet3, Planet4};
            foreach (var Planet in Planets)
            {
                Console.Write(Planet);
                if (Planet.Equals(Planet1)) Console.WriteLine(" - эквивалентен Венере");
                else Console.WriteLine(" - не эквивалентен Венере");
            }
            
        }
    }
}