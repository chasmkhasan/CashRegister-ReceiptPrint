using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsFair
{
    internal class TicketSeller
    {
        private string? name;
        private double price = 99;
        //private decimal price = 99.0M;
        //private decimal discountPercentage = 75.0M;
        //private int price = 99;
        private int numOfAdults;
        private int numOfChildren;

        private double totalPriceOfAdults;
        private double totalPriceOfChildren;
        private double totalPriceOfChildrenAfterDiscount;
        private double totalPriceNeedToPay;

        private double amountToPay;

        public void TicketSellerStart()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***************************");
            Console.WriteLine("Welcome To Kid's Fair!");
            Console.WriteLine("***************************");
            ReadAndSavePetData();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            ReadAmountToPay();
            DisplayDataOfTicketSeller();
            ReadDateTime();
        }

        private void ReadAndSavePetData()
        {
            ReadName();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            ReadNumberOfAdults();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            ReadNumberOfChildren();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
        }

        private void ReadName()
        {
            Console.WriteLine();
            Console.WriteLine("What is your Name? Please!");
            name = Console.ReadLine().ToUpper();
        }

        private void ReadNumberOfAdults()
        {
            Console.WriteLine();
            Console.WriteLine("How many are ABOVE 12 Years Old?");
            numOfAdults = int.Parse(Console.ReadLine());
        }

        private void ReadNumberOfChildren()
        {
            Console.WriteLine();
            Console.WriteLine("How many are BELOW 12 years Old?");
            numOfChildren = int.Parse(Console.ReadLine());
        }

        private void ReadAmountToPay()
        {
            Console.WriteLine();
            totalPriceOfAdults = price * numOfAdults;
            totalPriceOfChildren = price * numOfChildren;
            totalPriceOfChildrenAfterDiscount = (totalPriceOfChildren / 100) * 25;
            amountToPay = totalPriceOfAdults + totalPriceOfChildrenAfterDiscount;
            //Console.WriteLine("++++ Amount to Pay = " + amountToPay);
            Console.WriteLine();
        }

        private void DisplayDataOfTicketSeller()
        {
            Console.WriteLine();
            Console.WriteLine("++++ Your Receipt ++++");
            //Console.WriteLine("++++ Amount to Pay = "); ReadAmountToPay();
            Console.WriteLine("++++ Amount to Pay = " + amountToPay);
            Console.WriteLine("++++ Thank you " + name + " and please come back! ++++");
            Console.WriteLine();
        }
        private void ReadDateTime()
        {
            Console.WriteLine();
            DateTime now = DateTime.Now;
            Console.WriteLine("Receipt has been print on: " + now);
        }
    }
}
