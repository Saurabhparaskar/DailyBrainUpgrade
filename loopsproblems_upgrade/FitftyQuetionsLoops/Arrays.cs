using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopsproblems_upgrade.FitftyQuetionsLoops
{
    public class Arrays
    {


        //public void Arrays1()
        //{
        //    int[] numbers = { 1, 2, 3, 4, 5, 8 };
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        Console.WriteLine(numbers[i]);

        //    }
      //  }

        public void Arrays2(int[] numbers)
        {
            int[] arr1 = { 10, 20 };

            int[] arr2 = arr1;

            arr2[1] = 100;

            Console.WriteLine(arr1[1]);  
            Console.WriteLine(arr2[1]);
        }


        public void SumOfArray()
        {
            int sum = 0; 
	        int[] arr = { 10, 20, 30 };
            for (int i = 0; i < arr.Length; i++)
              {
                sum = sum + arr[i];//10,30,60

            }
            Console.WriteLine(sum);
        }

        public void LargestElement()
        {

            int largestElement = 0;
            int[] arr = { 10, 20, 30 };

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > largestElement)
                {
                    largestElement = arr[i];

                }


            }
            Console.WriteLine(largestElement);


        }

        public void Reverse()
        {
       
            int[] arr = { 10, 20, 30 };
            for (int i = arr.Length-1; i >=0; i--)
            {

                Console.WriteLine(arr[i]);
                

            }
 
        }

        public void CountEvenOdd()
        {


            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            int even = 0;
            int odd = 0;

            for (int i = 0; i <arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine("Even : "+arr[i]);
                    even++;
                }
                else
                {
                    Console.WriteLine("Odd : "+arr[i]);
                    odd++;

                }
            }
            Console.WriteLine("Total Even Number : " + even);
           Console.WriteLine("Total odd Number : "+odd);
        }
        public void SmallestElement()
        {


            int[] arr = { 10, 2, 15, 78, 74, 1 };
            int SmallestElement = arr[0];

            for (int i = 1; i <arr.Length; i++)
            {
                 
                if (arr[i] < SmallestElement)
                {

                    SmallestElement = arr[i];

                }
          

            }
            Console.WriteLine("Smallest Number is : "+ SmallestElement);
        }




        public void SearchElement()
        {
            int[] arr = { 10, 20, 30, 40, 50, 70, 80, 100 };
            int Search = 50;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == Search )

                {
                    Console.WriteLine("Search Element found Index NO :-> " + i);
                    break;
                }
                else
                        { Console.WriteLine("Not Found") ; 
                }

            }



        }

        public void SearchElementCount()
        {
            int[] arr = { 10, 20, 30, 40, 50, 70, 80, 100,50,50 };
            int Search = 50;
            int Count =0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == Search)

                {
                    Count++;
                }

            }
            Console.WriteLine($"50 appears {Count} Times  " +Count);
        }
        }
        }
 
