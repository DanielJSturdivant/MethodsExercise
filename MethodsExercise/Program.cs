using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string favoriteColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string favoriteAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string favoriteBand = Console.ReadLine();

            Console.WriteLine($"When {userName} saw the new mascot of {favoriteBand} for the first time, he was shocked!");
            Console.WriteLine($"The band's new {favoriteAnimal} mascot had {favoriteColor} stripes that glowed in the dark!");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to subtract from the previous number");
            num2 = int.Parse(Console.ReadLine());

            int difference = Difference(num1, num2);
            Console.WriteLine($"The difference is: {difference}");

            Console.WriteLine("Give me number to multiply");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me another number to multiply");
            num2 = int.Parse(Console.ReadLine());

            int answer = Multiply(num1, num2);
            Console.WriteLine($"The product is: {answer}");

            Console.WriteLine("Give me another number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to divide the previous number by");
            num2 = int.Parse(Console.ReadLine());

            int result = Division(num1, num2);
            Console.WriteLine($"The result is: {result}");

            Console.WriteLine("Give me a new number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me one last number for modulus");
            num2 = int.Parse(Console.ReadLine());

            int final = Modulo(num1, num1);
            Console.WriteLine($"The final result is a modulus of: {final}");

            var product = Multiply(10, 10);
            Console.WriteLine($"The product is: {product}");
            Console.WriteLine(AddWithParams(1, 1, 1, 1, 1));
            
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Difference(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Division(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int Modulo(int num1, int num2)
        {
            return num1 % num2;
        }

        public static int AddWithParams(params int[] paramNumbers)
        {
            int sum = 0;
            foreach (var num in paramNumbers) 
            {
                sum += num; // sum = sum + num;
            }

            return sum;
        }

        
    }
}
