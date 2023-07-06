using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//// ................................ Section 1 ................................
//// Exercise 1: Print "Hello, World!" to the console
//namespace PractriceSet
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//            Console.ReadLine();
//        }
//    }
//}

////Exercise 2: Asks the user for their name and greets them with "Hello, [name]" 
//namespace PractriceSet
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter your name:");
//            string name = Console.ReadLine();
//            Console.WriteLine("Hello, " + name);
//            Console.ReadLine();
//        }
//    }
//}

////Exercise 3: Takes two numbers as input and prints their sum
//namespace PractriceSet
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter first number:");
//            string num1 = Console.ReadLine(); 
//            Console.WriteLine("Enter second number:");
//            string num2 = Console.ReadLine();
//            Console.WriteLine($"The sum of {num1} and {num2} is: "
//                + (Convert.ToInt32(num1) + Convert.ToInt32(num2)));
//            Console.ReadLine();
//        }
//    }
//}

////Exercise 4: Takes a number as input and print its square
//namespace PractriceSet
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number of which square you want:");
//            int num = Convert.ToInt32(Console.ReadLine());
//            int num_square = num * num;
//            Console.WriteLine("The square of {0} is {1}", num, num_square);
//            Console.ReadLine();
//        }
//    }
//}

////Exercise 5: Prints all even number from 1 to 100
//namespace PractriceSet
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            for (int i = 1; i <= 100; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    Console.WriteLine(i);
//                }
//            }
//            Console.ReadLine();
//        }
//    }
//}

//// ................................ Section 2 ................................
//// Exercise 1: Asks the user for a number n and prints the sum of the numbers 1 to n
//namespace PractriceSet
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter number n: ");
//            int num = Convert.ToInt32(Console.ReadLine());
//            int sum = num;
//            for (int i = 0; i < num; i++)
//            {
//                sum = sum + i;
//            }
//            Console.WriteLine("The sum of numbers 1 to {0} is: {1}", num, sum);
//            Console.ReadLine();
//        }
//    }
//}

////Exercise 2: Print a multiplication table for numbers upto 12
//namespace PractriceSet
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int size = 12;
//            for (int i = 1; i <= size; i++)
//            {
//                Console.Write("The multiplication table for {0,2} is:", i);
//                for (int j = 1; j <= size; j++)
//                {
//                    Console.Write("{0,4}", i * j);
//                }
//                Console.WriteLine();
//            }
//            Console.ReadLine();
//        }
//    }
//}

//// Exercise 3: Prints all prime numbers upto n
//namespace PractriceSet
//{
//    class Program
//    {
//        static bool isPrime(int n)
//        {
//            if (n <= 1)
//                return false;

//            for (int i = 2; i < n; i++)
//                if (n % i == 0)
//                    return false;

//            return true;
//        }


//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter number n: ");
//            int num = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("The Prime numbers upto {0} are: ", num);
//            for (int i = 2; i <= num; i++)
//            {
//                if (isPrime(i))
//                {
//                    Console.WriteLine(i);
//                }
//            }
//            Console.ReadLine();
//        }
//    }
//}

//// Exercise 4: Computes the factorial of a number (n!)
//namespace PractriceSet
//{
//    class Program
//    {
//        static int factorial (int num)
//        {
//            if (num == 0 || num == 1)
//                return 1;

//            return num * factorial(num - 1);
//        }

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter number n: ");
//            int num = Convert.ToInt32(Console.ReadLine());
//            int fact_num = factorial(num);
//            Console.WriteLine("The factorial of {0} is {1}", num, fact_num);
//            Console.ReadLine();
//        }
//    }
//}

//// Exercise 5: Prints the Fibonacci Sequence upto n terms
namespace PractriceSet
{
    class Program
{
    static int fibonacci(int num)
    {
        if (num == 0)
            return 0;

        if (num == 1 || num == 2)
            return 1;

        return fibonacci(num - 1) + fibonacci(num - 2);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter number n: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Fibonacci Sequence upto {0} terms is:", num);
        for (int i = 0; i < num; i++)
        {
            int fib_num = fibonacci(i);
            Console.WriteLine(fib_num);
        }
        Console.ReadLine();
        
    }
}
}