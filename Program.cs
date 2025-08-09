using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORY_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
            List<string> productNames = new List<string>();
            List<int> stockCounts = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Product Name {i + 1}: ");
                string name = Console.ReadLine();

                Console.Write($"Stock Count for {name}: ");
                int stock = int.Parse(Console.ReadLine());

                productNames.Add(name);
                stockCounts.Add(stock);
            }
            Console.WriteLine("\nRestocked Items:");
            for (int i = 0; i < stockCounts.Count; i++)
            {
                if (stockCounts[i] < 10)
                {
                    stockCounts[i] += 20;
                    Console.WriteLine($"{productNames[i]} restocked to {stockCounts[i]} units.");
                }
            }
            Console.WriteLine("\nFinal Stock Levels:");
            for (int i = 0; i < productNames.Count; i++)
            {
                Console.WriteLine($"{productNames[i]}: {stockCounts[i]} units");
            }
        }
    }
}
        
