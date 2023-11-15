using static activity.House;

namespace activity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House myHouse = new House("Palace", "England");
            Bedroom myBedroom = new Bedroom("Queen Sized Bed");

            Console.WriteLine("Result from Nested Types:");
            myHouse.DisplayHouse();

            myBedroom.DisplayBed();
            myBedroom.AddFurniture("Study Table");
            myBedroom.AddFurniture("Night Stand");
            myBedroom.DisplayFurniture();
            
            House.Bathroom myBathroom = new House.Bathroom(true,true);
            Console.WriteLine(myBathroom.HasShower);
            Console.WriteLine(myBathroom.HasBathTub);
            myBathroom.isOpenShower();

            Factory myFactory = new Factory("Fries", 1, true);
            Console.WriteLine("Result from Partial Classes:");
            Console.WriteLine(myFactory.Product);
            Console.WriteLine(myFactory.QuantityPerPackaging);
            Console.WriteLine(myFactory.IsInspected);
        }
    }
}