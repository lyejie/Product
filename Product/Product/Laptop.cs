using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    class Laptop : Product
    {
        int quantity;
        int stock = 20;
        int newstock;
        double price = 2359.00;

        public Laptop()
        {
            int stock = newstock;
        }
        public void laptop()
        {
            try
            {
                Console.WriteLine("The item you chose is Laptop");
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

