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
            Console.WriteLine();
            Console.WriteLine("1 Household customer");
            Console.WriteLine("2 Administrative agency, public services");
            Console.WriteLine("3 Production units");
            Console.WriteLine("4 Business services");
            Console.WriteLine();

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
            int Amount = thiswater - lastwater ;

            if (type == 1)
            {
                double[] prices = { 5973, 7052, 8699, 15929 };
                int index = Math.Min((int)Math.Floor((double)Amount / 10), 3);

                double price = prices[index];
                double fee = price * Amount;
                totalBill = (fee + (0.1 * Amount * price) + (fee * 0.1));

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
            
            
                
            
            Console.WriteLine();
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Type: {type}");
            Console.WriteLine($"Amount: {Amount}");
            Console.WriteLine($"Total Bill: {totalBill}");
            Console.WriteLine();
            
        }


        
            
        
    }
}
