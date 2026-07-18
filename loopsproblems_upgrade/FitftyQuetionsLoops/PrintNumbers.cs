using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace loopsproblems_upgrade.FitftyQuetionsLoops
{
    public class PrintNumbers
    {
        public void printNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void reversePrintNumbers()
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        public void printEvenNumbers()
        {
            int j = 2;
            for (int i = 1; i <= 20; i++)
            {
                if (i % j == 0)
                {
                    Console.WriteLine("Even number " + i);
                }
                else
                {
                    Console.WriteLine("Odd Numers " + i);

                }

            }
            Console.WriteLine();
        }

        // Find the sum of numbers from 1 to 100.
        public int sumofNumbers(int a)
        {
            int result = 0;
            for (int i = 1; i <= a; i++)

            {
                result += i;

            }
            //Console.WriteLine(result);

            return result;

        }

        public void printTable()
        {
            int a = 3;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(a * i);
            }
        }
        public void printTable2(int a)
        {
            for (int i = 1; i <= 10l; i++)
            {
                Console.WriteLine(a * i);
            }

        }

        public void PrintNumberN(int n)
        {
            int i = 1;
            while (i <= n)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public void PrintNumberUsingDoWhile()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 10);
        }

        public void ArrayUsingForloop()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
        }

        public void IterationsLoopCount()

        {
            int count = 0;
            for (int i = 1; i <= 9; i++)
            {
                count++;

            }
            Console.WriteLine("Total Iterations: " + count);
        }


        public void UsingWhileLoop()
        {
            int count = 0;
            while (count <= 10)
            {
                count++;
            }
            Console.WriteLine(count);


        }
        //Find the factorial of a number.
        public void factorial()
        {
            int j = 5;
            int i = 1;
            int factorial = 1;

            while (i <= j)
            {

                factorial = factorial * i;
                i++;

            }

            Console.WriteLine(factorial);



        }
        //  Print numbers from 1 to 100, but:
        //Skip multiples of 3 (continue)
        // Stop when the number reaches 80 (break)
        //  Print only numbers divisible by 5.

        public void PrintNum()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    continue;

                }

                if (i == 80)
                {
                    break;


                }
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }


        //Find the sum of all even numbers from 1 to 100.

        public void sumofevennumber()
        {

            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("The sum of all even numbers from 1 to 100 is: " + sum);

        }


        //Find the sum of all odd numbers from 1 to 100.

        public void Oddofevennumber()
        {

            int oddSum = 0;
            int i = 1;

            do
            {
                if (i % 2 != 0)
                {
                    oddSum += i;

                }
                i++;


            } while (i <= 100);

            Console.WriteLine("The sum of all odd numbers from 1 to 100 is: " + oddSum);



        }

        //Reverse a number (e.g., 1234 → 4321).


        public void Revese()
        {
            int num = 1234;//123,12,1,0
            int r = 0;//4,43,432,4321

            while (num > 0)
            {
                int digit = num % 10; //last digit
                r = r * 10 + digit; //0*10+4=4, 4*10 + 3 = 43, 43*10 + 2 = 432, 432*10 + 1 = 4321
                num = num / 10; //1234/10=123, 123/10=12, 12/10=1, 1/10=0

            }
            Console.WriteLine("The reverse of the number is: " + r);


        }
        //Find whether a number is prime

        public void Primen(int n)
        {

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(n + " is not a prime number.");
                    return;
                }
            }
        }

        //
        public void countDigits(int num)
        {

            int countDigits = 0;
            while (num < 0)
            {
                countDigits++;
                num = num / 10;
            }
            Console.WriteLine(countDigits);



        }

        public void SumOfDigits(int n)//158
        {

            int sum = 0;

            while (n >= 0)

            {

                n = n / 10;//158
                sum++;



            }
            Console.WriteLine(sum);

        }

        public void starPattern()
        {
            int rows = 5; 
            int col = 1;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                col++;
            }

        }


    }

}

