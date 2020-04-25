using System;

namespace Section8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hardwood Store.");

            string woodType;
            double price;
            int qty;

            qty = GetDrawerQty();
            woodType = GetWoodType();
            price = GetPrice(qty, woodType);
            DisplayResult(qty, woodType, price);
        }

        static int GetDrawerQty()
        {
            Console.Write("Enter number of drawers >> ");
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }

        static string GetWoodType()
        {
            Console.Write("Enter the type of wood - e, o, m, p >> ");
            char input = Convert.ToChar(Console.ReadLine());
            string wood;

            switch (char.ToUpper(input))
            {
                case 'O':
                    wood = "Oak";
                    break;
                case 'P':
                    wood = "Pine";
                    break;
                case 'M':
                    wood = "Mahagony";
                    break;
                case 'E':
                    wood = "Elm";
                    break;
                default:
                    wood = "Misc";
                    break;

            }
            return wood;

        }

      

        static double GetPrice(int qty, string woodtype)
        {
            double basePrice;
            if (woodtype =="Pine")
                basePrice = 100.00;
            else if (woodtype == "Oak")
                basePrice = 140.00;
            else if (woodtype == "Elm")
                basePrice = 200.00;
            else
                basePrice = 180.00;

            double totalPrice = basePrice + (qty * 30);
            return totalPrice;
        }

        private static void DisplayResult(int qty, string wood, double Tprice)
        {
            Console.WriteLine("You have ordered a {0} type of desk with {1} amount of drawers\nTotal price is {2}",wood, qty, Tprice.ToString("c"));
        }
    }
}
