using System;

namespace PalindromePrime
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MIN_VALUE = 1;
            const int MAX_VALUE = 1000000;
            int number;

            Console.WriteLine("Ingrese un valor entero");
            var isValueInt = int.TryParse(Console.ReadLine(), out number);

            if (!isValueInt)
            {
                Console.WriteLine($"El valor debe ser un número entero");
                return;
            }

            if (number < MIN_VALUE || number > MAX_VALUE)
            {
                Console.WriteLine($"El valor debe ser mayor igual a {MIN_VALUE} y menor igual a {MAX_VALUE}");
                return;
            }

            var value = CalculateValue(number);

            Console.WriteLine($"Entrada: {number} -> Salida: {value}");
        }

        static int CalculateValue(int number)
        {
            while (!(IsPalindrome(number) && IsPrime(number)))
                number++;

            return number;
        }

       static bool IsPalindrome(int number)
        {
            var numberValue = number.ToString().ToCharArray();
            var invertedNumber = string.Empty;
            var isPalindrome = false;

            for (int i = numberValue.Length - 1; i >= 0; i--)
                invertedNumber += numberValue.GetValue(i);

            isPalindrome = Convert.ToInt32(invertedNumber) == number;

            return isPalindrome;
        }

        static bool IsPrime(int number)
        {
            var isPrime = true;

            if (number == 1)
                isPrime = false;

            for (int i = 2; i < number; i++)
                if ((number % i) == 0)
                {
                    isPrime = false;
                    break;
                }

            return isPrime;
        }
    }
}
