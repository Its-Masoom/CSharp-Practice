// Section 3:
// ....................................................................................................
// Exercise 1: Write a program that searches for number n in an array of 5 (where n is user input).
// ....................................................................................................
//using System;

//class Program
//{
//    static bool search_num(int n, int[] arr)
//    {
//        foreach (int num in arr)
//        {
//            if (num == n)
//                return true;
//        }
//        return false;
//    }

//    static void Main(string[] args)
//    {
//        Console.Write("Enter a number to search: ");
//        int number = Convert.ToInt32(Console.ReadLine());

//        int[] array = { 10, 20, 30, 40, 50 };

//        bool found = search_num(number, array);

//        if (found)
//            Console.WriteLine("Number found in the array.");
//        else
//            Console.WriteLine("Number not found in the array.");

//        Console.ReadLine();
//    }
//}

// ............................................................................................................
// Exercise 2: Write a program that checks if a string is a palindrome.
// ............................................................................................................

//using System;
//namespace palindrome
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string input_string;
//            string rev_string = "";
//            Console.Write("Enter the String whose palindrome you want to check: ");

//            input_string = Console.ReadLine();

//            for (int i = input_string.Length-1; i >= 0; i--)
//            {
//                rev_string = rev_string + input_string[i].ToString();
//            }

//            if (rev_string == input_string)
//            {
//                Console.WriteLine("Entered String is a palindrome");
//            }

//            else
//            {
//                Console.WriteLine("Entered string is not a palindrome");
//            }
//        }
//    }
//}


// ............................................................................................................
// Exercise 3: Write a program that finds the largest and smallest number in an unsorted array of integers.
// ............................................................................................................
//using System;

//class Program
//{
//    static void search_largest_smallest(int[] arr, out int smallest, out int largest)

//    {
//        smallest = largest = arr[0];

//        for (int i = 1; i < arr.Length; i++)
//        {
//            if (arr[i] < smallest)
//                smallest = arr[i];

//            if (arr[i] > largest)
//                largest = arr[i];
//        }
//    }

//    static void Main(string[] args)
//    {
//        int[] array = { 100, 30, 40, 10, 50 };

//        int smallest; 
//        int largest;

//        search_largest_smallest(array, out smallest, out largest);

//        Console.WriteLine("Smallest number: " + smallest);
//        Console.WriteLine("Largest number: " + largest);

//        Console.ReadLine();
//    }
//}


// ............................................................................................................
// Exercise 4: Write a program that prints a right angle triangle using the "*" character, with the height
// based on user input. (using loops and following is only sample input)
// ............................................................................................................

//using System;

//class Program
//{

//    static void Main(string[] args)
//    {
//        Console.Write("Enter height of the triangle: ");
//        int row = Convert.ToInt32(Console.ReadLine());
//        int col = 1;
//        for (int i = 0; i < row; i++)
//        {
//            for (int j = 0; j < col; j++)
//            {
//                Console.Write("*");
//            }
//            Console.WriteLine("\n");
//            col = col + 1;
//        }

//    }
//}

// ............................................................................................................
// Exercise 5: Write a program that prints a pyramid
// ............................................................................................................
//using System;

//class Program
//{

//    static void Main(string[] args)
//    {
//        int row_copy;
//        Console.Write("Enter height of the triangle: ");
//        int row = Convert.ToInt32(Console.ReadLine());
//        int col = 1;
//        row_copy = row;
//        for (int i = 0; i < row; i++)
//        {
//            for (int j = row_copy; j > 0; j--)
//            {
//                Console.Write(" ");
//            }

//            row_copy = row_copy - 1;

//            for (int k = 0; k < col; k=k+1)
//            {
//                Console.Write("*");
//            }
//            col = col + 2;
//            Console.WriteLine("\n");

//        }

//    }
//}

// ............................................................................................................
// Exercise 6: Write a program that takes a string as input and outputs the reverse of that string. 
// ............................................................................................................
//using System;
//namespace palindrome
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string input_string;
//            string rev_string = "";
//            Console.Write("Enter the String which you want to reverse: ");

//            input_string = Console.ReadLine();

//            for (int i = input_string.Length - 1; i >= 0; i--)
//            {
//                rev_string = rev_string + input_string[i].ToString();
//            }

//            Console.WriteLine("The string you entered was {0} and its reversed is {1}", input_string, rev_string);
//        }
//}
//}


// ............................................................................................................
// Exercise 7: Write a program that sorts an array. (take input as random numbers)
// ............................................................................................................

//using System;

//namespace SortArrayExample
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter array size or number of elements you want in array:");
//            int arr_size = Convert.ToInt32(Console.ReadLine());

//            int[] unsort_arr = new int[arr_size];

//            for (int j = 0; j < arr_size; j++)
//            {
//                Console.Write("Enter Element {0}: ", j);
//                unsort_arr[j] = Convert.ToInt32(Console.ReadLine());
//            }

//            int temp;

//            for (int i = 0; i <= unsort_arr.Length-1; i++)
//            {
//                for (int j = i + 1; j < unsort_arr.Length; j++)
//                {
//                    if (unsort_arr[i] > unsort_arr[j])
//                    {
//                        temp = unsort_arr[i];
//                        unsort_arr[i] = unsort_arr[j];
//                        unsort_arr[j] = temp;
//                    }
//                }
//            }
//            Console.WriteLine("Array in ascending order is");
//            foreach (var sort_element in unsort_arr)
//            {
//                Console.WriteLine(sort_element);
//            }
//            Console.ReadLine();
//        }
//    }
//}

// ............................................................................................................
// Exercise 8: Write a program that checks if a given number is a perfect number.
// ............................................................................................................

//using System;

//class Program
//{
//    static bool perfect_num_check(int num)
//    {
//        int sum = 0;
//        for (int i = 1; i < num; i++)
//        {
//            if (num % i == 0)
//                sum += i;
//        }

//        return (sum == num);
//    }

//    static void Main(string[] args)
//    {
//        Console.Write("Enter a number: ");
//        int num = Convert.ToInt32(Console.ReadLine());
//        bool isPerfect = perfect_num_check(num);

//        if (isPerfect)
//            Console.WriteLine("Entered Number is a Perfect Number");
//        else
//            Console.WriteLine("Entered Number is not a Perfect Number");

//        Console.ReadLine();
//    }
//}

// ............................................................................................................
// Exercise 9: Write a program that takes a string as input and outputs the reverse of that string. 
// ............................................................................................................
//using System;

//class Program
//{

//    static void Main(string[] args)
//    {
//        Console.Write("Enter height of the triangle: ");
//        int row = Convert.ToInt32(Console.ReadLine());
//        int col = 1;
//        for (int i = 0; i < row; i++)
//        {
//            for (int j = 0; j < col; j++)
//            {
//                Console.Write("{0}",(j+1));
//            }
//            Console.WriteLine("\n");
//            col = col + 1;
//        }

//    }
//}

// ............................................................................................................
// Exercise 10: Write a program that finds the longest common subsequence of two given strings.
// A subsequence is a sequence that appears in the same relative order but not necessarily contiguous.
// For example, for the input strings "ABCDGH" and "AEDFHR," the longest common subsequence is "ADH."
// ............................................................................................................
using System;

class LongestCommonSubsequence
{
    static void Main()
    {
        //string str1 = "ABCDGH";
        //string str2 = "AEDFHR";
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();
        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        int len1 = str1.Length;
        int len2 = str2.Length;

        int[,] dp = new int[len1 + 1, len2 + 1];

        for (int i = 0; i <= len1; i++)
        {
            for (int j = 0; j <= len2; j++)
            {
                if (i == 0 || j == 0)
                    dp[i, j] = 0;
                else if (str1[i - 1] == str2[j - 1])
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                else
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
            }
        }

        int lcsLength = dp[len1, len2];
        char[] lcs = new char[lcsLength];
        int index = lcsLength - 1;
        int p = len1, q = len2;

        while (p > 0 && q > 0)
        {
            if (str1[p - 1] == str2[q - 1])
            {
                lcs[index] = str1[p - 1];
                p--;
                q--;
                index--;
            }
            else if (dp[p - 1, q] > dp[p, q - 1])
                p--;
            else
                q--;
        }

        Console.WriteLine("The longest common subsequence is: " + new string(lcs));
        Console.ReadLine();
    }
}
