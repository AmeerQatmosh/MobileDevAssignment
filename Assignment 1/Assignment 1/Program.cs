using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("               ========================================================================");
            Console.WriteLine("               |      Welcome to Number Operations Console Application in C#          |");

            void print_menu()

            {

                Console.WriteLine("               ========================================================================");
                Console.WriteLine("               | To perform the following operations, choose the operation number.    |");
                Console.WriteLine("               ========================================================================");
                Console.WriteLine("               | 1. Find the Largest Number Among given numbers.                      |");
                Console.WriteLine("               | 2. Reverse a given number.                                           |");
                Console.WriteLine("               | 3. Find the largest digit of a number.                               |");
                Console.WriteLine("               | 4. Find the first int number inside a text.                          |");
                Console.WriteLine("               ========================================================================");
                Console.WriteLine("               | 5. Exit.                                                             |");
                Console.WriteLine("               ========================================================================");
                Console.WriteLine("\n");
                Console.WriteLine("Enter your choice: ");
                
            }

            while (true)
            {
                print_menu();
                int operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {

                    case 1:
                        LargestNumberFinder.LargestNumberValue();
                        break;

                    case 2:
                        NumberReverser.Reverse();
                        break;

                    case 3:
                        DigitAnalyzer.GetLargestDigit();
                        break;

                    case 4:
                        NumberSearcher.GetFirstIntNumber();
                        break;
                    case 5:
                        Console.WriteLine("*Press any button to exit the application! ");
                        return;
                      
                    default:
                        Console.WriteLine("*Unknown choice, Please try again! ");
                        break;

                }
            }
        }
    }

    // Operation 1: Find the Largest Number Among given numbers.
    class LargestNumberFinder 
    {
    public static void LargestNumberValue() 
        {
            
            Console.WriteLine("Enter the number of values, 'It recommends inputting a small number to avoid the hassle of entering too many number values': " );
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter value " + (i+1) + " : ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int largest = array[0];
            int smallest = array[0];

            for (int i = 1; i < size; i++)
            {
                if (array[i] > largest)
                {
                    largest = array[i];
                }
                if (array[i] < smallest)
                {
                    smallest = array[i];
                }
            }

            Console.WriteLine("*Largest Number Value is: " + largest );
            Console.WriteLine("*Smallest Number Value : " + smallest);

        }
    }

    // Operation 2: Reverse a given number.
    class NumberReverser
    {
        public static void Reverse()
        {
            int number, reverse = 0, rem;
            Console.Write("Enter a number, 'It recommends inputting a number without a number of digits exceeding 10 digits.': ");
            number = int.Parse(Console.ReadLine());
            while (number != 0)
            {
                // rem : return last digit, example 1234 % 10 = 4 -> rem = 4  
                rem = number % 10;
                reverse = reverse * 10 + rem;
                number /= 10;
            }

            Console.Write("\n" + "*The Reversed Number is: " + reverse + "\n\n");

        }
    }

    // Operation 3: Find the largest digit of a number.
    class DigitAnalyzer
    {
        public static void GetLargestDigit()
        {
            int number , rem, largestDigit = 0;
            Console.Write("Enter a number, 'It recommends inputting a number without a number of digits exceeding 10 digits.': ");
            number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                // rem : return last digit, example 1234 % 10 = 4 -> rem = 4  
                rem = number % 10;
                if (largestDigit < rem)
                {
                    largestDigit = rem;
                }
                number = number / 10;
            }

            Console.WriteLine("\n" + "*The Largest Digit is:" + largestDigit + "\n\n");


        }
    }

    // Operation 4: Find the first int number inside a text.
    class NumberSearcher
    {
        public static void GetFirstIntNumber()
        {

            string text;
            Console.Write("Enter a Text, 'It recommends inputting a simple short text': ");
            text = Convert.ToString(Console.ReadLine());

            string newtext = string.Empty;
            int value = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]))
                    newtext += text[i];
                else if (newtext.Length != 0)
                    break;
            }

            if (newtext.Length > 0)
                value = int.Parse(newtext);

            Console.WriteLine("*First Integer Number in the text is:" + value);
            Console.ReadLine();

        }
    }
}

