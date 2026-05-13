using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopsproblems_upgrade
{
    public class Factorial
    {

        public void factorial()
        {
            Console.WriteLine("Enter a number to calculate its factorial:");
            int number = Convert.ToInt32(Console.ReadLine());
            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            Console.WriteLine($"The factorial of {number} is: {result}");
        }
    }
}
