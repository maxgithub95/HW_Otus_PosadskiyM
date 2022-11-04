namespace DZ5
{
    public interface IRobot
    {
        string GetInfo();
        List<string> GetComponents();
        string GetRobotType()
        {
            return "I am a simple robot.";
        }
    }
    public interface IChargeable
    {
        void Charge();
        string GetInfo();
    }
    public interface IFlyingRobot : IRobot
    {
        new string GetRobotType()
        {
            return "I am a flying robot.";
        }
    }
    public class Quadcopter : IFlyingRobot, IChargeable
    {
        private List<string> _components = new List<string> { "rotor1", "rotor2", "rotor3", "rotor4" };

        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }

        public string GetInfo()
        {
            return "Я умею заряжаться";
        }
        

        public List<string> GetComponents()
        {
            return _components;
        }
        string IRobot.GetInfo()
        {
            return "Я робот";
        }
        public string GetRobotType()
        {
            return "Я робот-Квадрокоптер";
        }

    }
    static class Program
    {
        static void Main()
        {
            Quadcopter quadcopter = new Quadcopter();
            quadcopter.Charge();
            List<string> s = quadcopter.GetComponents();
            foreach (string component in s) Console.WriteLine(component);
            Console.WriteLine(quadcopter.GetRobotType());
            Console.WriteLine(quadcopter.GetInfo());
            IRobot robot = new Quadcopter();
            Console.WriteLine(robot.GetInfo());
            IChargeable ChargeRobot = new Quadcopter();
            Console.WriteLine(ChargeRobot.GetInfo());
        }
    }
}