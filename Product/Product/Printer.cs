using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    class Printer : Product
    {
        int quantity;
        int stock = 30;
        int newstock;
        double price = 239.90;

        public Printer()
        {
            int stock = newstock;
        }
        public void printer()
        {
            try
            {
                Console.WriteLine("The item you chose is Printer");
                Console.WriteLine("Quantity available: " + stock);
                Console.WriteLine("\nPlease select quantity.");
                quantity = Convert.ToInt32(Console.ReadLine());

                if (quantity > stock)
                {
                    Console.WriteLine("The stock is insufficient!");
                }
                else if (stock > quantity || stock == quantity)
                {
                    newstock = stock - quantity;
                    Console.WriteLine("\nStock left: " + newstock);
                    totalprice();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid, please try again!");
            }
        }

        public override void totalprice()
        {
            double totalprice;
            totalprice = price * quantity;
            Console.WriteLine("Total price: RM" + totalprice.ToString("0.00"));

        }
    }
}
