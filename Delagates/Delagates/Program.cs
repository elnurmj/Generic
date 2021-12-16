using System;
using System.Collections.Generic;

namespace Delagates
{
    class Program
    {
        public delegate bool Result(int num);
        public delegate void StringUppering(string str, int n);
        public delegate string Compare(string str);
        
        static void Main(string[] args)
        {
            Action<string, int> words = StringToUpper;
            words += StringToLower;
            words("ELNUR", 21);
            words("emin", 22);

            Console.WriteLine(Sum(n => n % 2 != 0, 3, 4, 6, 8, 1, 9));
            Console.WriteLine(Sum(SumOfNumsBiggerThan4, 1, 2, 3, 4, 5, 6, 7, 8, 9));
            Console.WriteLine(Sum(SumOfDevidedTo3And7, 21, 63));

            Animal animal = new Animal();
            Console.WriteLine(GetAnimal(animal));

            Func<string, int> func = StrsLength;
            Console.WriteLine(func("Elnur is learning about C#" + " " + "Emin is master in C#"));
        }
        public static void StringToUpper(string str, int n)
        {
            Console.WriteLine(str.ToUpper() + "" + n);
        }
        public static void StringToLower(string str, int n)
        {
            Console.WriteLine(str.ToLower() + "" + n);
        }
        
        //public static bool SumOfOddNumbers(int num)
        //{
        //    return num % 2 != 0;
        //}
        public static bool SumOfNumsBiggerThan4(int num)
        {
            return num > 4;
        }

        public static bool SumOfDevidedTo3And7(int num)
        {
            return num % 3 == 0 && num % 7 == 0;
        }

        public static int StrsLength(string str)
        {
            return str.Length; 
        }


        public static int Sum(Predicate<int> result, params int[] nums)
        {
            var sum = 0;
            foreach (var item in nums)
            {
                if (result(item))
                {
                    sum += item;
                }

            }
            return sum;
        }

        public static Animal GetAnimal(Animal animal)
        {

            return animal;
        }
        

    }

    public class Animal
    {
        public string GetAnimal { get; set; }
    }
}
