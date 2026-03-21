using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
   internal class InnerSwitch
   {
       static void Main(string[] args)
       {
           Console.WriteLine("Enter a category (Fruit/Vehicle):");
           string category = Console.ReadLine();

           switch (category)
           {
               case "Fruit":
                   Console.WriteLine("Enter a fruit (Apple/Mango):");
                   string fruit = Console.ReadLine();

                   switch (fruit)
                   {
                       case "Apple":
                           Console.WriteLine("You chose Apple. It's red and sweet!");
                           break;

                       case "Mango":
                           Console.WriteLine("You chose Mango. It's yellow and juicy!");
                           break;

                       default:
                           Console.WriteLine("Unknown fruit.");
                           break;
                   }
                   break;
               case "Vehicle":
                   Console.WriteLine("Enter a vehicle (Car/Bike):");
                   string vehicle = Console.ReadLine();

                   switch (vehicle)
                   {
                       case "Car":
                           Console.WriteLine("You chose Car. It has 4 wheels!");
                           break;

                       case "Bike":
                           Console.WriteLine("You chose Bike. It has 2 wheels!");
                           break;


                       default:
                           Console.WriteLine("Unknown vehicle.");
                           break;
                   }
                   break;

               default:
                   Console.WriteLine("Invalid category.");
                   break;
           }
       }
   }
}
