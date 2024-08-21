using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace randomtest
{
    public class Program1
    {
        public bool IfNumberContains3(int num)
        {
            while (num > 0)
            {
                if (num % 10 == 3) { return true; }
                num /= 10;
            }
            return false;
        }


        //static void Main(string[] args)
        //{
        //    Program1 INC3 = new Program1();
        //    Console.WriteLine(INC3.IfNumberContains3(7201432));
        //    Console.WriteLine(INC3.IfNumberContains3(87501));
        //}

        public double FructionsSum(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double ii = (1 / i);
                sum = sum + (ii * ii);
            }
            return sum;
        }


        //static void Main(string[] args)
        //{
        //    Program1 INC3 = new Program1();
        //    Console.WriteLine(INC3.FructionsSum(2));
        //    Console.WriteLine(INC3.FructionsSum(3));
        //    Console.WriteLine(INC3.FructionsSum(5));
        //    Console.WriteLine(INC3.FructionsSum(7));
        //}


        public int[] SortArrayAscending(int[] arr)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {

                for (int i = 0; i < arr.Length - 1; i++)
                {

                    if (arr[i] > arr[i + 1])
                    {
                        int tmp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = tmp;
                    }
                }

            }
            return arr;
        }

        public int RightNum(int[] arr)
        {
            return arr.Length - 1;
        }

        //static void Main(string[] args)
        //{
        //    Program1 INC3 = new Program1();
        //    int[] sortedArray = INC3.SortArrayAscending(new int[] { 1, 4, 8, 3, 5 });

        //    //寫法一
        //    for (int i = 0; i < sortedArray.Length; i++)
        //    {
        //        Console.Write($"{sortedArray[i]} ");
        //    }
        //    //寫法二
        //    foreach (var s in sortedArray)
        //    {
        //        Console.Write($"{s} ");
        //    }
        //    //寫法三
        //    string result = string.Join(" ", sortedArray);
        //    Console.WriteLine(result);


        //    int[] arr1 = INC3.SortArrayAscending(new int[] { 190, 291, 145, 209, 280, 300 });
        //    int[] arr2 = INC3.SortArrayAscending(new int[] { -9, -2, -7, -8, -4 });



        //    Console.WriteLine(arr1[INC3.RightNum(arr1)]);
        //    Console.WriteLine(arr2[INC3.RightNum(arr2)]);

        //}

 
            public bool ThreeIncresingAdjust(int[] arr)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i + 1] - arr[i] == 1 && arr[i + 2] - arr[i + 1] == 1)
                    {
                        return true;
                    }
                }
                return false;
            }



        static void Main(string[] args)
        {
            //Program1 INC3 = new Program1();
            //int[] arr1 = new int[] { 45, 23, 44, 68, 65, 70, 80, 81, 82 };
            //int[] arr2 = new int[] { 7, 3, 5, 8, 9, 3, 1, 4 };
            //bool tmp = INC3.ThreeIncresingAdjust(arr1);
            //bool tmp2 = INC3.ThreeIncresingAdjust(arr2);
            //Console.WriteLine(tmp);
            //Console.WriteLine(tmp2);
            //Console.WriteLine(INC3.ThreeIncresingAdjust(new int[] { 15, 17, 14, 11, 18, 19, 16, 16 }));
            //Console.WriteLine(INC3.ThreeIncresingAdjust(new int[] { -9, 0, -1, -6, -5, -4, -8, 0 }));
            //Two7snext_toeachother W7N = new Two7snext_toeachother();
            //Console.WriteLine(W7N.Two7snext(new int[] { 8, 2, 5, 7, 9, 0, 7, 7, 3, 1 }));
            //Console.WriteLine(W7N.Two7snext(new int[] { 9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7 }));
            //ReturnEvenNumbers R = new ReturnEvenNumbers();
            //Console.WriteLine(R.REN(100));

            //CheckBracketsSequence CBS = new CheckBracketsSequence();
            //Console.WriteLine(CBS.m_CBS("(((()))"));
            //Console.WriteLine(CBS.m_CBS("(((())))"));

            //AddSeparator AD = new AddSeparator();
            //Console.WriteLine(AD.m_AS("ABCD","^"));
            //Console.WriteLine(AD.m_AS("chocolate", "-"));
            //Console.WriteLine(AD.m_AS("computer", "_"));
            //Console.WriteLine(AD.m_AS("$*(#", " "));
            //Console.WriteLine(AD.m_AS("AC", "B"));
            //Console.WriteLine(AD.m_AS("octopus", "X"));

            IsPalindrome isPalindrome = new IsPalindrome();
            Console.WriteLine(isPalindrome.m_IsPalindrome("eye"));
            Console.WriteLine(isPalindrome.m_IsPalindrome("home"));
            Console.WriteLine(isPalindrome.m_IsPalindrome("madam"));
            Console.WriteLine(isPalindrome.m_IsPalindrome("123454321"));
            Console.WriteLine(isPalindrome.m_IsPalindrome("apple"));
            Console.WriteLine(isPalindrome.m_IsPalindrome("Never Odd Or Even"));



        }

    }

}
