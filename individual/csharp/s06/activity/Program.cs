namespace activity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User myUser = new User();
            myUser.Name = "Jane Smith";
            myUser.JoinDate = "October";
            myUser.IsAdmin = true;

            Admin myAdmin = new Admin();
            myAdmin.Name = myUser.Name;

            myAdmin.addProduct();

            Console.WriteLine("Result from a Premium user:");
            Premium myPremium = new Premium();

            myPremium.Login();
            myPremium.Checkout();

            Console.WriteLine("Result from Regular User:");
            Regular myRegular = new Regular();

            myRegular.Login();
            myRegular.Checkout();
        }
    }
}