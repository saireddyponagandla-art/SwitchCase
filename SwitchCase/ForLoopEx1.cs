using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class ForLoopEx1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Bigging Number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter the Endding Number:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(" Generating the Numbers ");
            for(int i = a; i<= b; i++)
            {
                Console.WriteLine(i);
            }
        
            
        }
    }
}
