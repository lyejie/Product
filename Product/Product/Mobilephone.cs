using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    class Mobilephone : Product
    {
        int quantity;
        int stock = 30;
        int newstock;
        double price = 1899.00;

        public Mobilephone()
        {
            int stock = newstock;
        }
        public void mobilephone()
        {
            try
            {
                Console.WriteLine("Mobile Phone is chosen.");
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


