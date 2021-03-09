using System;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            var laptop = new Laptop();
            var mobilephone = new Mobilephone();
            var mouse = new Mouse();
            var keyboard = new Keyboard();
            var printer = new Printer();

            Console.WriteLine(" - WELCOME TO LJ SDN BHD - ");
            Console.WriteLine("\nPlease choose the product number to order. ( 1 - 5 )");
            Console.WriteLine("1. Laptop (RM 2,359.00)");
            Console.WriteLine("2. Mobile phone (RM 1,899.00)");
            Console.WriteLine("3. Mouse (RM69.90)");
            Console.WriteLine("4. Keyboard (RM119.90)");
            Console.WriteLine("5. Printer (RM 239.90)\n");

            int product = Convert.ToInt32(Console.ReadLine());

            switch (product)
            {
                case 1:
                    laptop.laptop();
                    break;
                case 2:
                    mobilephone.mobilephone();
                    break;
                case 3:
                    mouse.mouse();
                    break;
                case 4:
                    keyboard.keyboard();
                    break;
                case 5:
                    printer.printer();
                    break;
            }
            Console.ReadLine();
        }
    }
}
