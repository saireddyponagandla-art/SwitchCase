//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SwitchCase
//{
//    internal class FileName
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter The Number:");
//            sbyte N = sbyte.Parse(Console.ReadLine());
//            switch (N > 0)
//            {
//                case true:
//                    Console.WriteLine(" Outer Switch Block is Executed");
//                    Console.WriteLine(N + " is a positive Number ");
//                    switch (N % 2 == 0)
//                    {
//                        case true:
//                            Console.WriteLine("Inner Switch Block is Executed");
//                            Console.WriteLine(N + " is an Even Number");
//                            break;
//                        case false:
//                            Console.WriteLine(" Inner Switch Block Is Executed");
//                            Console.WriteLine(N + " is  an odd Number");
//                            break;
//                    }
//                    break;
//                case false:
//                    Console.WriteLine(" Outer Switch Block is Executed ");
//                    Console.WriteLine(N + " is negative Number");
//                    switch (N % 2 == 0)
//                    {
//                        case true:
//                            Console.WriteLine("Inner Switch Block Is Executed");
//                            Console.WriteLine(N + " is an even Number");
//                            break;
//                        case false:
//                            Console.WriteLine("Inner Switch Block Is Executed");
//                            Console.WriteLine(N + "is an Odd Number");
//                            break;
//                    }
//                    break;
//            }

//        }
//    }
//}
