using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 - 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Example
            //Input: 5
            //Output: 1, 2, 3, 4, 5
            // Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //{
            //   Console.Write(i + (i < num ? ", " : ""));
            //}

            #endregion

            #region Q2 - Write a program that allows the user to insert an integer then  print a multiplication table up to 12.

            // Example
            //  Input: 5
            //5 10 15 20 25 30 35 40 45 50 55 60
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //  Console.Write(num * i + " ");
            // }
            #endregion

            #region Q3 -  Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Example:
            //Input: 15
            //Output: 2 4 6 8 10 12 14
            // Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            // Console.Write("Even numbers: ");
            //for (int i = 2; i <= number; i += 2)
            //{
            //  Console.Write(i + " ");
            //}
            #endregion

            #region Q4 - Write a program that takes two integers then prints the power.
            //Example:
            //Input: 4 3
            //Output: 64
            //Hint: how to calculate 4 ^ 3 = 4 * 4 * 4 = 64
            //Console.Write("Enter the base: ");
            //int baseNum = int.Parse(Console.ReadLine());

            //Console.Write("Enter the exponent: ");
            //int exponent = int.Parse(Console.ReadLine());

            //int result = 1;
            //for (int i = 0; i < exponent; i++)
            //{
            //  result *= baseNum;
            //}
            // Console.WriteLine($"Result: {result}");
            #endregion

            #region Q5 - Write a program to enter marks of five subjects and calculate total, average and percentage.

            //Example
            //Input: -Enter Marks of five subjects: 95 76 58 90 89
            //Output: Total marks = 408
            //Average Marks = 81
            //Percentage = 81
            // int[] marks = new int[5];
            //int total = 0;

            //Console.WriteLine("Enter marks for 5 subjects:");
            //for (int i = 0; i < 5; i++)
            //{
            //  marks[i] = int.Parse(Console.ReadLine());
            //total += marks[i];
            //}

            //double average = total / 5.0;
            //double percentage = (total / 500.0) * 100;

            // Console.WriteLine($"Total marks = {total}");
            //Console.WriteLine($"Average marks = {average}");
            //Console.WriteLine($"Percentage = {percentage}");
            #endregion

            #region Q6 -  Write a program to allow the user to enter a string and print the REVERSE of it.
            // Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //char[] charArray = input.ToCharArray();
            //Array.Reverse(charArray);

            //Console.WriteLine("Reversed string: " + new string(charArray));

            #endregion

            #region Q7 - Write a program to allow the user to enter int and print the REVERSED of it.
            // Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //int reversed = 0;
            //while (number > 0)
            //{
            //  reversed = reversed * 10 + number % 10;
            //number /= 10;
            //}

            //Console.WriteLine("Reversed integer: " + reversed);


            #endregion

            #region Q8 - Write a program in C# Sharp to find prime numbers within a range of numbers.
            // Test Data :
            //Input starting number of ranges: 1
            //Input ending number of range: 50
            //Expected Output :
            //The prime number between 1 and 50 are:
            // 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47

            //           Console.Write("Input starting number of range: ");
            //         int start = int.Parse(Console.ReadLine());
            //
            //       Console.Write("Input ending number of range: ");
            //     int end = int.Parse(Console.ReadLine());

            //   Console.WriteLine("Prime numbers:");
            // for (int i = start; i <= end; i++)
            //           {
            //             if (IsPrime(i))
            //               Console.Write(i + " ");
            //     }
            //  }

            //        static bool IsPrime(int num)
            //      {
            //        if (num < 2) return false;

            //      for (int i = 2; i <= Math.Sqrt(num); i++)
            //    {
            //      if (num % i == 0) return false;
            //    }
            //  return true;
            #endregion

            #region Q9 - Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //Test Data :
            //Enter a number to convert: 25
            //Expected Output :
            //The Binary of 25 is 11001.

            //  Console.Write("Enter a number to convert: ");
            //int number = int.Parse(Console.ReadLine());

            // string binary = "";
            //while (number > 0)
            //{
            //  binary = (number % 2) + binary;
            //number /= 2;
            //}

            //   Console.WriteLine("Binary: " + binary);
            #endregion

            #region Q10 - Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            // Console.WriteLine("Enter the coordinates of three points:");

            //Console.Write("Point 1 (x1, y1): ");
            //int x1 = int.Parse(Console.ReadLine());
            //int y1 = int.Parse(Console.ReadLine());

            //Console.Write("Point 2 (x2, y2): ");
            //int x2 = int.Parse(Console.ReadLine());
            //int y2 = int.Parse(Console.ReadLine());

            //Console.Write("Point 3 (x3, y3): ");
            //int x3 = int.Parse(Console.ReadLine());
            //int y3 = int.Parse(Console.ReadLine());

            //     if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            //       Console.WriteLine("The points lie on a straight line.");
            // else
            //   Console.WriteLine("The points do not lie on a straight line.");

            #endregion

            #region Q11  - . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.Write("Enter the size of the identity matrix: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //  for (int j = 0; j < n; j++)
            //{
            //  if (i == j)
            //    Console.Write("1 ");
            //else
            //  Console.Write("0 ");
            // }
            //Console.WriteLine();
            //}


            #endregion

            #region Q12 - Write a program in C# Sharp to find the sum of all elements of the array.
            //Console.Write("Enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] array = new int[size];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //  array[i] = int.Parse(Console.ReadLine());

            //int sum = 0;
            //foreach (int num in array)
            //  sum += num;

            //Console.WriteLine("Sum of array elements: " + sum);

            #endregion

            #region Q13 -  Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            // Console.Write("Enter the size of the arrays: ");
            //int size = int.Parse(Console.ReadLine());

            //int[] array1 = new int[size];
            //int[] array2 = new int[size];

            //Console.WriteLine("Enter the elements of the first array:");
            //for (int i = 0; i < size; i++)
            //  array1[i] = int.Parse(Console.ReadLine());

            //  Console.WriteLine("Enter the elements of the second array:");
            //for (int i = 0; i < size; i++)
            //  array2[i] = int.Parse(Console.ReadLine());

            //            int[] mergedArray = array1.Concat(array2).ToArray();
            //          Array.Sort(mergedArray);

            //        Console.WriteLine("Merged and sorted array: " + string.Join(" ", mergedArray));

            #endregion
            #region Q14 - Write a program in C# Sharp to count the frequency of each element of an array.
            //      Console.Write("Enter the size of the array: ");
            //    int size = int.Parse(Console.ReadLine());
            //  int[] array = new int[size];

            //Console.WriteLine("Enter the elements of the array:");
            //          for (int i = 0; i < size; i++)
            //            array[i] = int.Parse(Console.ReadLine());

            //      Dictionary<int, int> frequency = new Dictionary<int, int>();

            //    foreach (int num in array)
            //  {
            //    if (frequency.ContainsKey(num))
            //      frequency[num]++;
            //else
            //    frequency[num] = 1;
            //}

            //  Console.WriteLine("Frequency of each element:");
            //foreach (var pair in frequency)
            //  Console.WriteLine($"{pair.Key}: {pair.Value} times");

            #endregion

            #region Q15 - Write a program in C# Sharp to find maximum and minimum element in an array
            //  Console.Write("Enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] array = new int[size];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            // array[i] = int.Parse(Console.ReadLine());

            //            int max = array[0], min = array[0];

            //          foreach (int num in array)
            //        {
            //          if (num > max) max = num;
            //        if (num < min) min = num;
            //  }

            //Console.WriteLine($"Maximum: {max}, Minimum: {min}");

            #endregion

            #region Q16 - Write a program in C# Sharp to find the second largest element in an array.
            //Console.Write("Enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] array = new int[size];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //  array[i] = int.Parse(Console.ReadLine());

            //Array.Sort(array);
            //Console.WriteLine("Second largest element: " + array[size - 2]);
            #endregion

            #region Q17 - Consider an Array of Integer values with size N, having values as    
            //in this Example (7,0   0,0,0,5,6,7,5,0,,7,5,3)

       //     Console.Write("Enter the size of the array: ");
         //   int size = int.Parse(Console.ReadLine());
           // int[] array = new int[size];

         //   Console.WriteLine("Enter the elements of the array:");
           // for (int i = 0; i < size; i++)
             //   array[i] = int.Parse(Console.ReadLine());

         //   Dictionary<int, int> firstIndex = new Dictionary<int, int>();
           // int maxDistance = 0;

           // for (int i = 0; i < size; i++)
            //{
       //         if (firstIndex.ContainsKey(array[i]))
         //       {
                    
          //          int distance = i - firstIndex[array[i]];
            //        if (distance > maxDistance)
               //         maxDistance = distance;
                //}
                //else
                //{
                  
              //      firstIndex[array[i]] = i;
            //    }
          //  }

        //    Console.WriteLine("The longest distance between two equal cells is: " + maxDistance);



            #endregion
            #region Q18 -  Given a list of space separated words, reverse the order of the words.
            //  Console.WriteLine("Enter a sentence:");
            //string sentence = Console.ReadLine();

            //string[] words = sentence.Split(' ');
            //Array.Reverse(words);

            //Console.WriteLine(string.Join(" ", words));
            #endregion
            #region Q19 -Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            // Console.Write("Enter the size of the 2D array (rows x columns): ");
            // int rows = int.Parse(Console.ReadLine());
            //int cols = int.Parse(Console.ReadLine());

            // int[,] array1 = new int[rows, cols];
            //int[,] array2 = new int[rows, cols];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < rows; i++)
            //{
            //  for (int j = 0; j < cols; j++)
            //{
            //  array1[i, j] = int.Parse(Console.ReadLine());
            //array2[i, j] = array1[i, j];
            //           }
            //     }

            //   Console.WriteLine("Copied array:");
            // for (int i = 0; i < rows; i++)
            //{
            //  for (int j = 0; j < cols; j++)
            //{
            //  Console.Write(array2[i, j] + " ");
            // }
            // Console.WriteLine();
            //}
            #endregion
            #region Q20 -  Write a Program to Print One Dimensional Array in Reverse Order
            //  Console.Write("Enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] array = new int[size];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //  array[i] = int.Parse(Console.ReadLine());

            //Array.Reverse(array);
            //Console.WriteLine("Reversed array: " + string.Join(" ", array));
            #endregion

        }

    }
}
