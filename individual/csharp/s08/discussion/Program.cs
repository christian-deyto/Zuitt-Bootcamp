namespace discussion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nested Types
            Car myCar = new Car("Ferrari", "Ferrari SF90 Straddle");
            Car.Engine myEngine = new Car.Engine("V-12", 769, 8);
            Car.Tires myTires = new Car.Tires(32, 9, "Pirelli");

            Console.WriteLine("Result of Nested Types:");
            myEngine.StartEngine();
            myEngine.StopEngine();
            myTires.CheckPressure();

            Console.WriteLine("Result of Inheriting Nested Types:");
            Honda myOtherCar = new Honda(1500000, "Honda", "Honda Civic 2023");
            Honda.Engine myOtherEngine = new Honda.Engine("V-Tech", 158, 4);
            Honda.Tires myOtherTires = new Honda.Tires(30, 10, "Honda");

            myOtherEngine.StartEngine();
            myOtherEngine.StopEngine();
            myOtherTires.CheckPressure();

            // Partial Classes
            Laptop myLaptop = new Laptop("Up to GeForce RTX 3080 Ti Laptop GPU", "16GB or 32GB RAM (DDR5 4800MHz)");
            Console.WriteLine("Result of Partial Classes:");
            Console.WriteLine(myLaptop.GraphicsCard);
            Console.WriteLine(myLaptop.Memory);
        }

        
    }
}