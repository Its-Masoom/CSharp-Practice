// ..............................................................................
// Practice Questions
// ..............................................................................


// ..............................................................................
// Exercise 1: Calculate the sum of all elements in a 2D array.
// ..............................................................................

//using System;

//namespace day3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[,] two_dim = { { 1, 4, 2 }, { 3, 6, 8 } };
//            int sum = 0;
//            foreach (int i in two_dim)
//            {
//                sum = sum + i;
//            }
//            Console.WriteLine("Sum of the 2-D array is: {0}", sum);
//            Console.ReadLine();
//        }
//    }
//}

// ..............................................................................
// Exercise 2: Find the maximum element in a 2D array.
// ..............................................................................

//using System;

//namespace day3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[,] two_dim = { { 1, 4, 2 }, { 3, 100, 8 } };
//            int temp = two_dim[0,0];
//            int sum = 0;
//            foreach (int i in two_dim)
//            {
//                if (i > temp)
//                {
//                    temp = i;
//                }
//            }
//            Console.WriteLine("Greatest number in 2-D array is: {0}", temp);
//            Console.ReadLine();
//        }
//    }
//}


// ..............................................................................
// Exercise 3:  Calculate the average value of each row in a 2D array.
// ..............................................................................

//using System;

//namespace day3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //int[,] two_dim = { { 1, 4, 2 }, { 3, 100, 8 } };
//            int[,] two_dim = { { 1, 4, 2, 9 }, { 3, 100, 8, 2 } };


//            for (int i = 0; i < two_dim.GetLength(0); i++)
//            {
//                float sum = 0;
//                float average;
//                int column = two_dim.GetLength(1);

//                for (int j = 0; j < two_dim.GetLength(1); j++)
//                {
//                    sum = sum + two_dim[i, j];
//                }
//                //average = (float)(sum / column);
//                average = (sum / column);
//                Console.WriteLine("The average of {0} row is: {1}", i, average);
//            }
//            Console.ReadLine();
//        }
//    }
//}

// ..............................................................................
// Exercise 4: Check if a given value exists in a 2D array.
// ..............................................................................

//using System;

//namespace day3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[,] two_dim = { { 1, 4, 2 }, { 3, 100, 8 } };
//            Console.WriteLine("Enter the value that you want to check: ");
//            int check_value = Convert.ToInt32(Console.ReadLine());
//            int check = 0;

//            foreach (int i in two_dim)
//            {
//                if (i == check_value)
//                {
//                    check = 1;
//                    break;
//                }
//                else
//                {
//                    check = 0;

//                }


//            }

//            if (check == 1)
//            {
//                Console.WriteLine("Entered Element Exists");
//            }
//            else
//            {

//                Console.WriteLine("Entered Element Not Exists");

//            }
//            Console.ReadLine();
//        }
//    }
//}


// ..............................................................................
// Exercise 5: Transpose a 2D array (convert rows to columns and vice versa).
// ..............................................................................


