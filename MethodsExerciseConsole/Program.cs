using System;

namespace MethodsExerciseConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string userName = Console.ReadLine();

            //Console.WriteLine("How old are you?");
            //string age = Console.ReadLine();

            //Console.WriteLine("What is the name of your dog?");
            //string dogName = Console.ReadLine();

            //Console.WriteLine("What color is your dog?");
            //string color = Console.ReadLine();

            //Console.WriteLine($"How much does {dogName} weigh?");
            //string weight = Console.ReadLine();

            //Console.WriteLine($"How long has {userName} had {dogName}?");
            //string ownership = Console.ReadLine();

            //Console.WriteLine($"{userName} is {age} and has a {color} dog named {dogName}.");
            //Console.WriteLine($"He has had {dogName} for {ownership}.");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Give me a number to add to {num1}");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2, 2, 4, 6, 8);
            Console.WriteLine($"The sum is {sum}");

            Console.WriteLine("Give me a number to multiply");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Give me a number to multiply by {num1}");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is {product}");
        }

        public static int Sum(params int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }

            return sum;

        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

    }
}
