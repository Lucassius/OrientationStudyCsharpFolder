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
        
        
        static async void HotReloading()
        {
            while (true)
            {
                Console.WriteLine("Hot Reload!");
                await Task.Delay(1);

            }
        }

        static void Diag()
        {
            Debug.WriteLine("Debug says...");
            Trace.WriteLine("Trace says");
        }

        static void Withdraw(string accountName, decimal amount)
        {
            if (accountName is null)
            {
                Console.WriteLine("First");
                throw new ArgumentNullException(paramName: nameof(accountName));
            }
            if (amount < 0)
            {
                Console.WriteLine("Second");
                throw new ArgumentException(
                message: $"{nameof(amount)} cannot be less than zero.");
            }
            // process parameters
        }
        public class Calculator
        {
            public static void Gamma() // public so it can be called from outside
            {
                Console.WriteLine("In Gamma");
                Delta();
            }
            private static void Delta() // private so it can only be called internally
            {
                Console.WriteLine("In Delta");
                File.OpenText("bad file path");
            }
        }

        class PrimeFactorsNuns
        {
            const int MAX_SIZE = 1000;
            static bool IsPrimeNumber(int num)

            {

                bool bPrime = true;

                int factor = num / 2;



                int i = 0;



                for (i = 2; i <= factor; i++)

                {

                    if ((num % i) == 0)

                        bPrime = false;

                }

                return bPrime;

            }

            static public int GetPrimeFactors(int num, out int[] arrResult)

            {

                int count = 0;

                int[] arr = new int[MAX_SIZE];

                arrResult = new int[MAX_SIZE];

                int i = 0;

                int idx = 0;



                for (i = 2; i <= num; i++)

                {

                    if (IsPrimeNumber(i) == true)

                        arr[count++] = i;

                }



                while (true)

                {

                    if (IsPrimeNumber(num) == true)

                    {

                        arrResult[idx++] = num;

                        break;

                    }



                    for (i = count - 1; i >= 0; i--)

                    {

                        if ((num % arr[i]) == 0)

                        {

                            arrResult[idx++] = arr[i];

                            num = num / arr[i];

                            break;

                        }

                    }

                }

                return idx;

            }

            public static void ReturnPrimeFactors() // The last exercise, chapter 4
            {
                int[] arrResult;

                Console.Write("Enter a number to find prime factor: ");

                int n = Convert.ToInt32(Console.ReadLine());

                int count = GetPrimeFactors(n, out arrResult);

                for (int i = 0; i < count; i++)

                {

                    Console.Write($"{Convert.ToString(arrResult[i])}");

                    if (i != count - 1)

                        Console.Write(" x ");

                }

                Console.WriteLine();
            }



            //the class is public 'cause we need to acess it outside the assembly

            //Class BankAccount
            public class BankAccount
            {
                public string? AccountName; // instance member
                public decimal Balance; // instance member
                public static decimal InterestRate; // shared member
            }

            //Class that carries the values about some Person

            public class Person
            {
                public string? Name;
                public int Age;
                public const string Species = "Homo Sapiens";
            }

            static void ClassAplicationsBankAccount()
            {
                BankAccount.InterestRate = 0.012M; // store a shared value
                BankAccount jonesAccount = new();
                jonesAccount.AccountName = "Mrs. Jones";
                jonesAccount.Balance = 2400;

                Console.WriteLine(format: "{0} earned {1:C} interest.",
                arg0: jonesAccount.AccountName,
                arg1: jonesAccount.Balance * BankAccount.InterestRate);

                BankAccount gerrierAccount = new();
                gerrierAccount.AccountName = "Ms. Gerrier";
                gerrierAccount.Balance = 98;

                Console.WriteLine(format: "{0} earned {1:C} interest.",
                 arg0: gerrierAccount.AccountName,
                 arg1: gerrierAccount.Balance * BankAccount.InterestRate);

                Person Jack = new();

                Console.WriteLine("Bob name:");
                Jack.Name = Console.ReadLine();

                Console.WriteLine($"{ Jack.Name} is a {Person.Species}");
                
            }

            public class TextAndNumber
            {
                public string? Text;
                public int Number;

            }
            public class AllMeaning
            {
                public TextAndNumber GetData()

                {
                    return new TextAndNumber
                    {
                        Text = "Universe is",
                        Number = 42
                    };
                }
            }

            //partial classes

            public partial class Human
            {
                public string? Name;
                public string? Planet;

                public string Origin
                {
                    get
                    {
                        return string.Format($"{Name} and your house {Planet}");
                    }
                }


            }

            static void PartialAplications()
            {
                Human Jack = new()
                {
                    Name = "Jack Norther",
                    Planet = "Mars"
                };

                Console.Write($"{Jack.Origin}\nName: {Jack.Name}\nHome: {Jack.Planet}");
            }

            //Funcionality

            public static int Factorial(int number)
            {
                if(number < 0)
                {
                    throw new ArgumentException($"{nameof(number)} cannot be less than 0");
                }
                return localFactorial(number);
                int localFactorial(int localNumber)
                {
                    if (localNumber == 0) return 1;
                    return localNumber * localFactorial(localNumber - 1);
                }
            }

            //Pattern matching with objects

            public class Passenger
            {
                public string? Name;
            }
            public class BusinessClassPassenger : Passenger
            {
                public override string ToString()
                {
                    return $"Business Class: {Name}";
                }
            }
            public class FirstClassPassenger : Passenger
            {
                public int AirMiles { get; set; }
                public override string ToString()
                {
                    return $"{AirMiles} AIRMILES: {Name}";
                }
            }

            static void PatternClasses()
            {
                Passenger[] passengers =
                {
                    new FirstClassPassenger {AirMiles = 12_213, Name = "Jake"},
                    new FirstClassPassenger {AirMiles = 34_2332, Name = "Joseph"},
                    new BusinessClassPassenger {Name = "Leonard"}
                };
                foreach (Passenger passenger in passengers)
                {
                    Console.WriteLine($"{passenger}");
                }
            }

            static string TypeCard(int n)
            {
                if (n == 0)
                {
                    string? str_type = "joker";
                    return Convert.ToString(str_type);
                }
                else if (n == 1)
                {
                    string? str_type = "ace";
                    return Convert.ToString(str_type);
                }
                else if (n == 2)
                {
                    string? str_type = "king";
                    return Convert.ToString(str_type);
                }
                else if (n == 3)
                {
                    string? str_type = "queen";
                    return Convert.ToString(str_type);
                }
                else
                {
                    string? str_type = "jack";
                    return Convert.ToString(str_type);
                }
            }

            public class Cards
            {

            }
            public class Properties : Cards
            {
                public string? Suit;
                public int Number;
                public string? Color;
                public string? type;

            }

            public static void DeckOfCards()
            {
                int rdm = Random.Shared.Next(1, 4);

                Cards[] deck =
                {
                    new Properties {Suit = "Heart", Number = Random.Shared.Next(1,16), Color = "Red", type = TypeCard(rdm)},
                    new Properties {Suit = "Diamond", Number = Random.Shared.Next(1,16), Color = "Black", type = TypeCard(rdm)},
                    new Properties {Suit = "Club", Number = Random.Shared.Next(1,16), Color = "White", type = TypeCard(rdm)}

                };

                foreach (Cards card in deck)
                {
                    try
                    {
                        Console.WriteLine(card);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"{ex.ToString()} and {ex.Message}");
                    }
                }
            }


            public class CryptographyTool
            {
                // AES encryption and decryption
                public static string AESEncrypt(string plainText, string key)
                {
                    byte[] iv = new byte[16];
                    byte[] array;

                    using (Aes aes = Aes.Create())
                    {
                        aes.Key = Encoding.UTF8.GetBytes(key);
                        aes.IV = iv;

                        ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                        using (var ms = new System.IO.MemoryStream())
                        {
                            using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                            {
                                using (var sw = new System.IO.StreamWriter(cs))
                                    sw.Write(plainText);
                                array = ms.ToArray();
                            }
                        }
                    }

                    return Convert.ToBase64String(array);
                }

                public static string AESDecrypt(string cipherText, string key)
                {
                    byte[] iv = new byte[16];
                    byte[] buffer = Convert.FromBase64String(cipherText);

                    using (Aes aes = Aes.Create())
                    {
                        aes.Key = Encoding.UTF8.GetBytes(key);
                        aes.IV = iv;

                        ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                        using (var ms = new System.IO.MemoryStream(buffer))
                        {
                            using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                            {
                                using (var sr = new System.IO.StreamReader(cs))
                                    return sr.ReadToEnd();
                            }
                        }
                    }
                }

                // RSA encryption and decryption
                public static string RSAEncrypt(string plainText, string publicKey)
                {
                    byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

                    using (var rsa = new RSACryptoServiceProvider(2048))
                    {
                        rsa.FromXmlString(publicKey);

                        byte[] encryptedData = rsa.Encrypt(plainTextBytes, true);
                        return Convert.ToBase64String(encryptedData);
                    }
                }

                public static string RSADecrypt(string cipherText, string privateKey)
                {
                    byte[] cipherTextBytes = Convert.FromBase64String(cipherText);

                    using (var rsa = new RSACryptoServiceProvider(2048))
                    {
                        rsa.FromXmlString(privateKey);

                        byte[] decryptedData = rsa.Decrypt(cipherTextBytes, true);
                        return Encoding.UTF8.GetString(decryptedData);
                    }
                }

                // DES encryption and decryption
                public static string DESEncrypt(string plainText, string key, string iv)
                {
                    byte[] keyBytes = Encoding.UTF8.GetBytes(key);
                    byte[] ivBytes = Encoding.UTF8.GetBytes(iv);

                    byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
                    byte[] encryptedBytes = null;

                    using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                    {
                        des.Key = keyBytes;
                        des.IV = ivBytes;

                        encryptedBytes = des.CreateEncryptor().TransformFinalBlock(plainTextBytes, 0, plainTextBytes.Length);
                    }

                    return Convert.ToBase64String(encryptedBytes);
                }

                public static string DESDecrypt(string cipherText, string key, string iv)
                {
                    byte[] keyBytes = Encoding.UTF8.GetBytes(key);
                    byte[] ivBytes = Encoding.UTF8.GetBytes(iv);

                    byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
                    byte[] decryptedBytes = null;

                    using (DESCryptoServiceProvider des =
                            new DESCryptoServiceProvider())
                    {
                        des.Key = keyBytes;
                        des.IV = ivBytes;

                        decryptedBytes = des.CreateDecryptor().TransformFinalBlock(cipherTextBytes, 0, cipherTextBytes.Length);
                    }

                    return Encoding.UTF8.GetString(decryptedBytes);
                }


                static void space() => Console.WriteLine("\n\n\n");

                //LINQ

                static void LinqAp1()
                {
                    List<int> numbers = new List<int>();
                    for(int i = 1; i <= 99; i++)
                    {
                        numbers.Add(i);
                    }
                    IEnumerable<int> firstAndLastFive = numbers.Take(5).Concat(numbers.TakeLast(5));
                    /*Take the firsts five numbers and write, then it takes the lasts 5 five numbers and writes in the console too
                     * and the Concat method realize an union of these elemments*/

                    foreach(int i in firstAndLastFive)
                    {
                        Console.WriteLine(i);
                    }
                }

                static void LinqAp2()
                {
                    int[] values = new int[] { 0, 12, 44, 36, 92, 54, 13, 8 };
                    IEnumerable<int> result =
                        from v in values
                        where v < 54 // conditional clause
                        orderby -v // highest to lowesr
                        select v;   //tells it what to put 

                    foreach(int i in result)
                    {
                        //output
                        Console.WriteLine(i);
                    }
                }

                //Linq working with objects

                class Comic
                {
                    public string Name { get; set; }
                    public int Issue { get; set; }
                    public override string ToString() => $"{Name} (Issue #{Issue})";

                    public static readonly IEnumerable<Comic> Catalog =
                        new List<Comic> {
                            new Comic { Name = "Johnny America vs. the Pinko", Issue = 6 },
                            new Comic { Name = "Rock and Roll (limited edition)", Issue = 19 },
                            new Comic { Name = "Woman's Work", Issue = 36 },
                            new Comic { Name = "Hippie Madness (misprinted)", Issue = 57 },
                            new Comic { Name = "Revenge of the New Wave Freak (damaged)", Issue = 68 },
                            new Comic { Name = "Black Monday", Issue = 74 },
                            new Comic { Name = "Tribal Tattoo Madness", Issue = 83 },
                            new Comic { Name = "The Death of the Object", Issue = 97 },
                        };
                    public static readonly IReadOnlyDictionary<int, decimal> Prices =
                        new Dictionary<int, decimal> {
                             { 6, 3600M },
                             { 19, 500M },
                             { 36, 650M },
                             { 57, 13525M },
                             { 68, 250M },
                             { 74, 75M },
                             { 83, 25.75M },
                             { 97, 35.25M },
                             };
                }

                static void LinqAp3()
                {
                    //We can replace to <var mostExpensive> 
                    // In this way, the code works too

                    IEnumerable<Comic> mostExpensive =
                         from comic in Comic.Catalog
                         where Comic.Prices[comic.Issue] > 500
                         orderby -Comic.Prices[comic.Issue]
                         select comic;

                    foreach (Comic comic in mostExpensive)
                    {
                        Console.WriteLine($"{comic} is worth {Comic.Prices[comic.Issue]:c}");
                    }
                }

                static void LinqAp4()
                {
                    int[] slayers = { 12, 64, 23, 65, 23, 56, 6546, 32 ,44, 65 };
                    var knifes =
                        from tros in slayers
                        where (tros == 6546 || tros == 44 || tros >= 13)
                        orderby tros descending
                        select tros + 10;

                    foreach(var luses in slayers)
                    {
                        Console.WriteLine(luses);   
                    }
                    
                }

                static void SimpleSequence()
                {
                    int[] sequence = { 12, 54, 78, 8, 3, 4, 5, 6, };
                    var greaterThanFour =
                        from number in sequence
                        where number > 4
                        select number;
                    foreach(var num in greaterThanFour)
                    {
                        Console.WriteLine(num);
                    }
                }
                
                //The <new> keyword
                static void Newva()
                {

                    var platos = new[]
                    {
                        new {Name = "Apologies", knowledge = 1},
                        new {Name = "Phedro", knowledge = 2},
                        new {Name = "Republic", knowledge = 67},
                        new {Name = "DelfsOracle", knowledge = 2143},
                    };



                }


                //lambda expressions 
                
                static double GetRandomDouble(int max)/*<<<function*/ => max * Random.Shared.Next(); /*<<<<return*/

                static int Summa(int a, int b) => a + b;

                // the key <?> operator
                //is this condition true ? yes : no

                static void TheQKeyOperator()
                {
                    
                    Console.WriteLine("Type something");
                    int a = Convert.ToInt32(Console.ReadLine());    

                    if(a > 120)
                    {
                        Console.WriteLine("anormal");
                    }
                    else
                    {
                        Console.WriteLine("normal");
                    }

                    int answer = a > 120 ? 1 : 0;
                    //where 1 is true and 0 is false
                    var numer = 0.23;
                    var num = "";
                        
                }
                // Lambda expressions & LINQ

                static void LambdExLinQ()
                {
                    var array = new[] { 1, 2, 3, 4, };
                    var result = from i in array select i * 2;
                    foreach(var i in result)
                    {
                        Console.WriteLine(i);
                    }
                    
                }

                static void ordebymethod()
                {
                    var nums = new[] { 2, 43, 54, 12, 56.3, 32, 54, 676, 47242, 5634123, 56421, 4321, 3452 };
                    var result =
                        from num in nums // new var num in numbers(nums)
                        where num > 56.3 //condition 
                        orderby -num //descending(+ operator means greater to lesser) & (- operator means lesser to greater)
                        select num; //select the result(num)

                    foreach(var i in result)
                    {
                        Console.WriteLine(i);
                    }
                }
                
                

                    static void Main(string[] args)
                {
                    ordebymethod();
                }
            }
        }
    }
}
