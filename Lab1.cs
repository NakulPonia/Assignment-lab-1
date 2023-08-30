

// PROGRAM 1
using System;
namespace Assignment1
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int sum = 0;
            Console.WriteLine("Enter 5 Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum is :" + sum);
        }
    }
}

// PROGRAM 2
namespace Assignment1
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            double sum = 0;
            Console.WriteLine("Enter 5 Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            double avg = sum / 5;

            Console.WriteLine("Average is :" + avg);
        }
    }
}

//PROGRAM 3
using System;
namespace Assignment1
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int max = 0;
            Console.WriteLine("Enter 5 Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }


            Console.WriteLine(" Maximum Element is :" + max);
        }
    }
}

// PROGRAM 4
using System;
namespace Assignment1
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int even = 0;
            int odd = 0;
            Console.WriteLine("Enter 5 Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }


            Console.WriteLine(" Total Even Element is :" + even);
            Console.WriteLine(" Total Odd Element is :" + odd);
        }
    }
}

// PROGRAM 5
using System;
namespace Assignment1
{
    internal class Program5
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int start = 0;
            int end = arr.Length - 1;
            Console.WriteLine("Enter 5 Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
            Console.WriteLine("Reverse Array is :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();

        }
    }
}

// PROGRAM 6
using System;
namespace Assignment1
{
    internal class Program6
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                arr[i] = arr[i] * 2;
            }


            Console.WriteLine("Array is :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();

        }
    }
}

// PROGRAM 7
using System;
namespace Assignment1
{
    internal class Program7
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            Console.WriteLine("Enter 5 Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Enter Elements to be search");
            int n = Convert.ToInt32(Console.ReadLine());



            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    Console.WriteLine("Element found at index :" + i);
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Element not found");
            Console.ReadLine();

        }
    }
}

// PROGRAM 8
using System;
namespace Assignment1
{
    internal class Program8
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            Console.WriteLine("Enter 5 Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }
            Console.WriteLine("Array is:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");

            }
            Console.WriteLine();
            Console.WriteLine("Second Minimum is: " + arr[1]);
            Console.ReadLine();

        }
    }
}

// PROGRAM 9
using System;
namespace Assignment1
{
    internal class Program9
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 3, 3, 3, 4, 5, 5 };
            int l = arr.Length;
            int r = removeDuplicateFromArray(arr, l);

            Console.WriteLine("Final Array is:");
            for (int i = 0; i < r; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
        }
        static int removeDuplicateFromArray(int[] arr, int n)
        {
            if (n == 0 || n == 1)
                return 0;

            int[] arr2 = new int[n];
            int j = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    arr2[j++] = arr[i];
                }

            }

            arr2[j++] = arr[n - 1];

            for (int i = 0; i < j; i++)
            {
                arr[i] = arr2[i];
            }

            return j;
        }
    }
}




// PROGRAM 10
using System;
namespace Assignment1
{
    internal class Program10
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int[] arr2 = new int[5];
            int j = 0;
            int[] arr3 = new int[5];
            Console.WriteLine("Enter 5 Elements of First Array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Enter 5 Elements of second Array");
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = 0; k < arr2.Length; k++)
                {
                    if (arr[i] == arr2[k])
                    {
                        arr3[j] = arr[i];
                        j++;
                    }
                }

            }
            Console.WriteLine("Final Array with Common Elements are:");
            for (int i = 0; i < j; i++)
            {
                Console.Write(arr3[i] + " ");

            }

        }
    }
}

