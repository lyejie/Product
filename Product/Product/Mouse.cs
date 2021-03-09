using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    class Mouse : Product
    {
        int quantity;
        int stock = 50;
        int newstock;
        double price = 69.90;

        public Mouse()
        {
            int stock = newstock;
        }
        public void mouse()
        {
            try
            {
                Console.WriteLine("The item you chose is Mouse");
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
