using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amount = 0;
            Console.WriteLine("Enter the amount : ");
            amount = Convert.ToDouble(Console.ReadLine());
            int input = 0;
            Console.WriteLine("Enter the card type : ");
            Console.WriteLine("1 for Membership card , 2 for Employee card and 3 for no card . ");
            input = Convert.ToInt32(Console.ReadLine());
            if (input < 1 || input > 3)
            {
                Console.WriteLine("Invalid input");
                Console.ReadKey();
            }
            else
            {
                CardInterface card = CardFactory.getCard(input);
                Console.WriteLine("Card type is : " + card.CardType());
                int discount = card.Discount();
                Console.WriteLine("Discount is : " + discount +" %");
                double total_amount = amount - (amount * discount) / 100;
                Console.WriteLine("Total amount to be paid after discount : " + total_amount);
                Console.ReadKey();
            }
        }
    }
}
