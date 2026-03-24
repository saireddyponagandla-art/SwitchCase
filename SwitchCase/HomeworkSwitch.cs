//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SwitchCase
//{
//   internal class HomeworkSwitch
//   {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the Number :");
//            int N = int.Parse(Console.ReadLine());
//            switch (N > 0)
//            {
//                case true:
//                    Console.WriteLine(" Outer Switch block  are Executed");
//                    Console.WriteLine(N + " is a Postive Number ");
//                    switch (N % 2 == 0)
//                    {
//                        case true:
//                            Console.WriteLine(" Inner Switch Block are Executed");
//                            Console.WriteLine(N + " is an Even Number");
//                            break;
//                        case false:
//                            Console.WriteLine("Inner Switch Block are Executed");
//                            Console.WriteLine(N + " is an odd Number");
//                            break;
//                    }
//                    break;
//                case false:
//                    Console.WriteLine("Outer switch Block Are Executed");
//                    Console.WriteLine(N + "  is a Negative Number");
//                    switch (N % 2 == 0)
//                    {
//                        case true:
//                            Console.WriteLine("Inner switch Block are Executed");
//                            Console.WriteLine(N + " is an even Number");
//                            break;
//                        case false:
//                            Console.WriteLine("Inner Switch Block are Executed");
//                            Console.WriteLine(N + "  is an Odd Number");
//                            break;
//                    }
//                    break;

//            }
//        }

//    }
//}
