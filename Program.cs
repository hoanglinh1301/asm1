using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_toan_tính_đien_nước
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            String Name = Console.ReadLine();
            double totalBill = 0;

            Console.WriteLine("1 Household customer");
            Console.WriteLine("2 Administrative agency, public services");
            Console.WriteLine("3 Production units");
            Console.WriteLine("4 Business services");

            Console.Write("Customer type: ");
            int type = int.Parse(Console.ReadLine());
            if (type >= 1 && type <= 4)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Invalid type");
                return;
            }
            Console.WriteLine("last month water use");
            int lastwater = int.Parse(Console.ReadLine());
            Console.Write("this month water use");
            int thiswater = int.Parse(Console.ReadLine());
            int Amount = thiswater - lastwater;

            if (type == 1)
            {
                double price;
                if (Amount > 0 && Amount <= 10)
                {
                    price = (Amount * 5.973);
                    Console.WriteLine($"Water price for {Name} is: {price} VND/m3");
                    double fee = price * Amount;
                    totalBill = fee + (0.1 * Amount * price) + (fee * 0.1);
                }
                else if (Amount > 10 && Amount <= 20)
                {
                    price = (Amount * 7.052);
                    Console.WriteLine($"Water price for {Name} is: {price} VND/m3");
                    double fee = price * Amount;
                    totalBill = fee + (0.1 * Amount * price) + (fee * 0.1);
                }
                else if (Amount > 20 && Amount <= 30)
                {
                    price = (Amount * 8.699);
                    Console.WriteLine($"Water price for {Name} is: {price} VND/m3");
                    double fee = price * Amount;
                    totalBill = fee + (0.1 * Amount * price) + (fee * 0.1);
                }
                else
                {
                    price = (Amount * 15.929);
                    Console.WriteLine($"Water price for {Name} is: {price} VND/m3");
                    double fee = price * Amount;
                    totalBill = fee + (0.1 * Amount * price) + (fee * 0.1);
                }

            }

            else if (type == 2)
            {
                double price = 9955;
                double fee = price * Amount;
                totalBill = fee + (0.1 * Amount * price) + (fee * 0.1);
            }
            else if (type == 3)
            {
                double price = 11615;
                double fee = price * Amount;
                totalBill = fee + (0.1 * Amount * price) + (fee * 0.1);
            }
            else if (type == 4)
            {
                double price = 22068;
                double fee = price * Amount;
                totalBill = fee + (0.1 * Amount * price) + (fee * 0.1);
            }
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Type: {type}");
                Console.WriteLine($"Amount: {Amount}");
                Console.WriteLine($"Total Bill: {totalBill}");
                Console.ReadLine();
            }
        }
}
