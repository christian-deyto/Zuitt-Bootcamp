namespace activity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Result from Nokia Phone:");

            Nokia nokia = new Nokia();
            nokiaSendText(nokia);
            nokiaPlayMusic(nokia);

            Console.WriteLine("Result from Samsung Phone:");
            Samsung samsung = new Samsung();
            samsungSendText(samsung);
            samsungPlayMusic(samsung);

            pictureCamera(samsung);
            videoCamera(samsung);

        }

        public static void nokiaSendText(ICellphone cellphone)
        {
            cellphone.SendText("Hello from the 90's", "John");
        }

        public static void nokiaPlayMusic(ICellphone cellphone)
        {
            cellphone.PlayMusic("Backstreet Boys - Shape of My Heart");
        }

        public static void samsungSendText(ICellphone cellphone)
        {
            cellphone.SendText("How r u doing today?", "Jane <3 :D");
        }

        public static void samsungPlayMusic(ICellphone cellphone)
        {
            cellphone.PlayMusic("Taylor Swift - Love Story");
        }

        public static void pictureCamera(ICamera camera)
        {
            camera.TakePicture();
        }

        public static void videoCamera(ICamera camera)
        {
            camera.TakeVideo();
        }
    }
}