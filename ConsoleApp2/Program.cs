using System;
using System.Linq;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
using System.Reflection;
using static System.Convert;
using Microsoft.VisualBasic;


namespace ConsoleApp1

{
    class Program

    {
        static void ex1()
        {
            /*
             * Type code for a switch statement. You should note that the 
             * penultimate statement is a label that can be
            jumped to, and the first statement generates a random number between 1 and 6
            (the number 7 in the code is an
            exclusive upper bound). The switch statement branches are 
            based on the value of this random number, as
            shown in the following code
            */

            int numb = Random.Shared.Next(1, 8);
            Console.WriteLine($"The random number is {numb}");
            switch (numb)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    goto case 1;
                case 3:
                    Console.WriteLine("3");
                    goto case 2;
                case 4:
                    Console.WriteLine("4");
                    goto case 3;
                default:
                    Console.WriteLine("Default");
                    break;
            }
            Console.WriteLine("Finally got the end");

        }
        static void EachFunc()
        {
            // foreach function

            int[] list = { 1, 2, 4, 5, 6, 7 };
            foreach (int numbers in list)
            {
                Console.WriteLine($"{numbers} \n");
            }
        }

        static void TestDoWhile()
        {
            //do while 
            string? password = "\0";

            for (int i = 0; i <= 2; i++)
            {
                do
                {
                    Console.WriteLine($"{i} password:");
                    password = Console.ReadLine();

                    if (password == "passw0rd")
                    {
                        Console.WriteLine("Finally !");
                        break;
                    }
                    i++;

                } while (i != 2);
            }
        }

        static void ex2And3()
        {
            // Type a for statement to output the numbers 1 to 10, as shown in the following code:
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            //Type statements to create an array of string
            //variables and then output the length of each one, as shown in the
            //following code:

            string[] cakes = { "cacau", "orange", "strawberry" };
            foreach (string cake in cakes)
            {
                Console.WriteLine(cake);
            }
        }

        static void arrayTest()
        {
            string[] books;
            books = new string[3]; //allocate 5 index positions 
            books[0] = "humble pi";
            books[1] = "grimm brothers";
            books[2] = "lotr";

            for (int j = 0; j < books.Length; j++)
            {
                Console.WriteLine($"\n{books[j]}");
            }
        }

        static void ConvTest()
        {
            double g = 9.23;
            int h = Convert.ToInt32(g);
            Console.WriteLine(h);
        }

        static void ex3()
        {
            /*Type statements to declare and assign an array of
             * double values, convert each of them to an integer, and then
            write the result to the console, as shown in the following code:
            */

            double[] values = { 9.2, 43.3, 45.1, 21.2, 12.5, 32.1, 4.1, 4.74, 6.212, 45.1 };

            foreach (double value in values)
            {
                Console.WriteLine(Convert.ToInt32(value));
            }

        }
        static void ex4()
        {
            //Type statements to declare some variables,
            //convert them to their string representation, and write them to
            //the console, as shown in the following code:

            double g = 2.3;
            int beta = 21;
            float H = 12.4F;
            DateTime now = DateTime.Now;

            Console.WriteLine(Convert.ToString(g));
            Console.WriteLine(Convert.ToString(beta));
            Console.WriteLine(Convert.ToString(H));
            Console.WriteLine(Convert.ToString(now));


        }

        static void ex5()
        {
            /*. Type statements to create an array 
             * of bytes randomly populated with byte values, write each byte nicely
            formatted to the console, and then write the same bytes
            converted to Base64 to the console, as shown in the
            following code:*/

            byte[] BinaryObj = new byte[128]; // put 128 bytes 
            Random.Shared.NextBytes(BinaryObj);
            Console.WriteLine("Binary objects:");

            for (int i = 0; i < BinaryObj.Length; i++)
            {
                Console.WriteLine(BinaryObj[i]);

            }
            string converted = Convert.ToBase64String(BinaryObj);
            Console.WriteLine(converted);
        }

        static void ex6()
        {
            /*Type statements to parse an integer and a date and time
             * value from strings and then write the result to the
            console, as shown in the following code:*/

            int age = int.Parse("23");
            DateTime now = DateTime.Parse("9 may 1932");
            Console.WriteLine(age);
            Console.WriteLine(now);
        }

        static void ex7()
        {
            /*Replace the int count declaration with statements
             * to use the TryParse method and ask the user to input a
             count for a number of eggs, as shown in the following code:*/

            Console.WriteLine("Type the number of eggs:");
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int count))
            {
                Console.WriteLine(count);

            }
            else
            {
                Console.WriteLine("error");
            }


        }

        static void ex8()
        {
            /*Type statements to prompt the user to enter their age
             * and then write their age to the console*/

            Console.WriteLine("Type your name:");
            string? name = Console.ReadLine();
            Console.WriteLine("Type your age:");
            string? age = Console.ReadLine();

            try
            {
                int tryt = int.Parse(age);
                Console.WriteLine(tryt);
            }
            catch (FormatException)
            {
                Console.WriteLine("The number has another value type ! ");
            }
            catch (Exception ex) //captures all the clausules and all the errors commit by the user
            {
                Console.WriteLine($"{ex.GetType()} says {ex.Message}");
            }


            Console.WriteLine("Came to end");
        }

        static void FilterWithTry()
        {
            Console.WriteLine("Enter an amount: ");
            string amount = Console.ReadLine()!;
            if (string.IsNullOrEmpty(amount)) return;
            try
            {
                decimal amountValue = decimal.Parse(amount);
                Console.WriteLine($"Amount formatted as currency: {amountValue:C}");
            }
            catch (FormatException) when (amount.Contains("$"))
            {
                Console.WriteLine("Amounts cannot use the dollar sign!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Amounts must only contain digits!");
            }
        }

        static void Checked()
        {
            try
            {


                int x = int.MaxValue - 1;
                Console.WriteLine($"Initial Value {x}");
                x++;
                Console.WriteLine($"Value incremented by one {x}");
                x++;
                Console.WriteLine($"Value incremented by one {x}");
                x++;
                Console.WriteLine($"Value incremented by one  {x}");
                Console.WriteLine("after");
                x++;
                Console.WriteLine(x);
            }
            catch (Exception ex) //captures all the clausules and all the errors commit by the user
            {
                Console.WriteLine($"{ex.GetType()} says {ex.Message}");
            }
        }

        static void MaybeLoop()
        {
            int max = 500;
            for (byte i = 0; i < max; i++)
            {
                Console.WriteLine(i);
            }

        }

        static void ex3e4()
        {
            Console.WriteLine("Enter a number between 0_255:");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number");
            var b = Convert.ToInt32(Console.ReadLine());
            try
            {
                var newA = Convert.ToInt32(a);
                Console.WriteLine(newA);
                var newB = Convert.ToInt32(b);
                Console.WriteLine(newB);

            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception: Input string was not in a correct format");
            }
        }
        static void TimesTable(int number, byte size)
        {
            Console.WriteLine($"The number {number} and the {size}");
            for (int i = 1; i <= size; i++)
            {
                Console.WriteLine($" number {number} x {i} is equal to {number * i}");
            }
        }

        //Functions exercises 

        static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
        {
            decimal rate = 0.0M;
            switch (twoLetterRegionCode)
            {
                case "BR":
                    rate = 0.88M;
                    break;
                case "US":
                    rate = 0.67M;
                    break;
                case "FR":
                    rate = 0.23M;
                    break;
                case "HU":
                    rate = 0.45M;
                    break;
                default:
                    break;
                
            }
            return rate * amount;
        }

        static string CardinalToOrdinal(int number)
        {
            switch (number)
            {
                case 11: // special cases for 11th to 13th
                case 12:
                case 13:
                    return $"{number}th";
                default:
                    int lastDigit = number % 10;
                    string suffix = lastDigit switch
                    {
                        1 => "st",
                        2 => "nd",
                        3 => "rd",
                        _ => "th"
                    };
                    return $"{number}{suffix}";
            }
        }

        static int factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else if (number is < 0)
            {
                int erro = 0;
                return erro;
            }
            else
            {
                return number * factorial(number - 1);
            }
        }

        static void ShowFactorial()
        {

            int beta = factorial(5);
            Console.WriteLine(beta);

        }

        static int Fibo(int numb)
        {
            if(numb == 1)
            {
                return 1;
            }
            else if(numb == 2)
            {
                return 1;
            }
            else
            {
                return Fibo(numb - 1) + Fibo(numb - 2);
            }
        }

        static int DeclairFib(int numb) => //Declarative Style
            numb switch
            {
                1 => 0,
                2 => 1,
                _ => DeclairFib(numb - 1), DeclairFib(numb - 2)
            };
       

        static void ShowFib()
        {
            Console.WriteLine(Fibo(10));
        }

        

        static void Main(string[] args)
        {
            decimal Tax = CalculateTax(290, "BR");
            Console.WriteLine($"{ Tax:C}"); // <:C> local value

            string inp = CardinalToOrdinal(6);
            Console.WriteLine(inp);

            ShowFactorial();
            ShowFib();
            
        }



    }

}



