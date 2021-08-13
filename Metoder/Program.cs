using System;
using System.Collections.Generic;
using System.Linq;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {

                Console.WriteLine("Hello!");
                Console.WriteLine("1-11 for assignments");
                Console.WriteLine("12 for assignment info");
                Console.WriteLine("0 to exit");
                double Choice = double.Parse(Console.ReadLine());
            

                switch (Choice)
                {
                    case 1:
                        opgave1();
                        break;

                    case 2:
                        opgave2();
                        break;

                    case 3:
                        opgave3();
                        break;

                    case 4:
                        opgave4();
                        break;

                    case 5:
                        opgave5();
                        break;

                    case 6:
                        opgave6();
                        break;

                    case 7:
                        opgave7();
                        break;

                    case 8:
                        opgave8();
                        break;

                    case 9:
                        opgave9();
                        break;

                    case 10:
                        opgave10();
                        break;

                    case 11:
                        opgave11();
                        break;

                    case 12:
                        opgaveinfo();
                        break;

                    case 0:
                        running = false;
                        break;
                }
                Console.Clear();
            }


        }
        static void opgave1()
        {
            Console.WriteLine("here we + two nummbers");

            Console.WriteLine("put in a nummber");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("put in a nummber");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(a + b);
            Console.ReadLine();
        }
        static void opgave2()
        {
            Console.WriteLine("Hey time to use Pythagoras a²+b²=c²");
            Console.WriteLine("you should have an a value and an b value");

            Console.WriteLine("put in your a value");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("now put in your b value");
            double b = double.Parse(Console.ReadLine());

            double c = a * a + b * b;
            Console.WriteLine($"nice job your {a}²+{b}²={c}²");
            Console.WriteLine($"than we takes the square root of {c} so the answer for c is {Math.Sqrt(c)}");

            if (a > b)
            {
                Console.WriteLine($"the value a {a} is bigger than the value b {b}");
            }

            else
            {
                Console.WriteLine($"the value b {b} is bigger than value a {a}");
            }


            Console.ReadLine();
        }

        static void opgave3()
        {
            Console.WriteLine("Hello pls put in a name");

            string n = Console.ReadLine();

            Console.WriteLine($"Hello {n} nice to meet you, now how old are you");
            double age = double.Parse(Console.ReadLine());

            if (age < 3)
            {
                Console.WriteLine($"{n} how are you even using this");
            }
            else if (age <= 15)
            {
                Console.WriteLine($"{n} you can't do anything and your mom and dad sucks");
            }
            else if (age < 18)
            {
                Console.WriteLine($"ay {n} you can drink now");
            }
            else if (age >= 18)
            {
                Console.WriteLine($"you're not a kid {n} you can drive now");
            }
            Console.ReadLine();
        }
        static void opgave4()
        {
            for (int i = 1; i <= 10; i++) 
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
        static void opgave5()
        {
            for (int i = 10; i >=1; i--) 
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();

        }
        static void opgave6() 
        {
            Console.WriteLine("put in a nummber");
            int tal = int.Parse(Console.ReadLine());

            for (int i = 1; i < 33; i++)
            {
                tal++;
                Console.Write(tal + " ");

            }
            Console.WriteLine();

            for (int j = 16; j > 0; j--)
            {
                tal--;
                Console.Write(tal + " ");
            }
            Console.ReadLine();

        }
        static void opgave7()
        {
            int[] MyArray = new int[9];
            int i = 0;
            int j = 0;

            foreach (int item in MyArray)
            {
                MyArray[i] = i + 1;
                i++;
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"index 4 and 5 is at this moment {MyArray[4]} and {MyArray[5]}");
            MyArray[5] = 10;
            Console.WriteLine($"now it should have changed 6 to 10");

            foreach (int item in MyArray)
            {
                Console.Write(MyArray[j] + " ");
                j++;
            }


            Console.ReadLine();

        }
        static void opgave8()
        {
            Console.WriteLine("");
            int j = 2;
            List<int> listeB = new List<int>();

            for (int i = 2; i <= 20; i += 2)// this starts on 2 and adds 2+ and stops when it hits 20
            {
                listeB.Add(j);
                j += 2;
            }
            foreach(int item in listeB)
            {
                Console.Write(item + " ");
            }
            int k = 0;
            while(true)// denne ville remove all tal der går op i 3
            {
                if(listeB[k] %3 == 0)
                {
                    listeB.RemoveAt(k);
                }
                else
                {
                    k++;
                }
                if(listeB.Count <= k)
                {
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"there are now {k} items");
            listeB.Insert(2, 17);

            foreach(int item in listeB)
            {
                Console.Write(item + " ");
            }
            listeB.Reverse();
            Console.WriteLine("the list is now reverset");

            Console.ReadLine();
        }
        static void opgave9()
        {
            Console.WriteLine("feeling lucky, time to play some lotto");
            int[] Lottoarray = new int[7];
            int[] Player = new int[7];

            Random r = new Random();

            int test;

            for (int i = 0; i < Lottoarray.Length; i++)
            {
                test = r.Next(1, 21);

                while (Lottoarray.Contains(test))
                {
                    test = r.Next(1, 21);
                }
                Lottoarray[1] = test;
            }
            Array.Sort(Lottoarray);

            foreach (int i in Lottoarray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            foreach(int i in Player)
            {
                Console.Write(i + " ");
            }
            int correct = 0 ;

            double price = Math.Pow(15, correct);

            for (int k = 0; k < Lottoarray.Length; k++)
            {
                if (Lottoarray.Contains(Player[k]))
                {
                    correct++;
                }
            }
            switch (correct)
            {

                case 3:
                    Console.WriteLine($"congratulations! you have {correct} right! you have won {price}kr! (Nice)");
                    break;
                case 4:
                    Console.WriteLine($"congratulations! you have {correct} right! you have won {price}kr! (Nice)");
                    break;
                case 5:
                    Console.WriteLine($"congratulations! you have {correct} right! you have won {price}kr! (Nice)");
                    break;
                case 6:
                    Console.WriteLine($"congratulations! you have {correct} right! you have won {price}kr! (Nice)");
                    break;
                case 7:
                    Console.WriteLine($"congratulations! you have {correct} right! you have won {price}kr! (Nice)");
                    break;

                default:
                    Console.WriteLine("Sorry. no money for you.");
                    break;
            }


            Console.ReadLine();


        }
        static void opgave10()
        {
        Console.WriteLine();
        }
        static void opgave11()
        {
        Console.WriteLine();
    }
        static void opgave12()
        {
        Console.WriteLine();
    }
        static void opgaveinfo()
        {
        Console.WriteLine();
    }
    }
}

























