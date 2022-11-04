namespace DZ6_1
{
    static class Program
    {
        public class Planet
        {
            public string Title { get; set; }
            public byte NumberFromTheSun { get; set; }
            public int Equator { get; set; }
            Planet PreviousPlanet;

            public Planet(string T, byte N, int E, Planet P)
            {
                Title = T;
                NumberFromTheSun = N;
                Equator = E;
                PreviousPlanet = P;
            }
        }
        static Planet Planet1 = new Planet("Венера", 2, 38025, null);
        static Planet Planet2 = new Planet("Земля", 3, 40075, Planet1);
        static Planet Planet3 = new Planet("Марс", 4, 21344, Planet2);
        public class CatalogOfPlanet
        {
            List<Planet> planets = new List<Planet>();
            public void Add(Planet AddPlanet)
            {
                planets.Add(AddPlanet);
            }
            public CatalogOfPlanet()
            {
                Add(Planet1);
                Add(Planet2);
                Add(Planet3);
            }
           public byte Counter = 0;
           
            public (byte? FoundNumber, int? FoundEquator, string? Error) GetPlanet(string FindTitle, Func<string, string?> PlanetValidator)
            {
                Counter++;
                string? check = PlanetValidator(FindTitle);
                if (check != null) return (FoundNumber: null, FoundEquator: null, Error: check);
                foreach (Planet P in planets)
                {
                    if (P.Title == FindTitle) return (FoundNumber: P.NumberFromTheSun, FoundEquator: P.Equator, Error: null);
                }
                return (FoundNumber: null, FoundEquator: null, Error: "Не удалось найти планету");

            }
        }
        static void Main()
        {
            CatalogOfPlanet catalogOfPlanet = new CatalogOfPlanet();
            string[] Planets = { "Земля", "Лимония", "Марс" };
            //byte Counter = 0;
            foreach (string P in Planets)
            {
                var getP = catalogOfPlanet.GetPlanet(P, P => {
                    
                    if (catalogOfPlanet.Counter == 3)
                    {
                        catalogOfPlanet.Counter = 0;
                        return "Вы спрашиваете слишком часто";
                    }
                    return null;});                
                if (getP.Error == null)
                {
                    Console.WriteLine("Название: " + P);
                    Console.WriteLine("Порядковый номер: " + getP.FoundNumber);
                    Console.WriteLine("Длина экватора: " + getP.FoundEquator);
                    Console.WriteLine("---");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(getP.Error);
                    Console.WriteLine("---");
                    Console.WriteLine();
                }
            }
            foreach (string P in Planets)
            {
                var getP = catalogOfPlanet.GetPlanet(P, P => {

                    if (P == "Лимония") return "Это запретная планета";
                    return null;
                });
                if (getP.Error == null)
                {
                    Console.WriteLine("Название: " + P);
                    Console.WriteLine("Порядковый номер: " + getP.FoundNumber);
                    Console.WriteLine("Длина экватора: " + getP.FoundEquator);
                    Console.WriteLine("---");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(getP.Error);
                    Console.WriteLine("---");
                    Console.WriteLine();
                }
            }


        }
    }
}