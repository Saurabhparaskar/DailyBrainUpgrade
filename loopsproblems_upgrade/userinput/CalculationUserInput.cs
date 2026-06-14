

namespace loopsproblems_upgrade.userinput
{
    internal class CalculationUserInput
    {
        int a, b, c;

        public void GetUserInput()
        {
           
            Console.WriteLine("Enter the first Number: ");
            a =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Number: ");
            b=Convert.ToInt32(Console.ReadLine());

        }
        public void sum()
        {
            c = a + b;
            Console.WriteLine("The sum of the two numbers is: " + c);
        }
        public void sub()
        {
            c = a - b;
            Console.WriteLine("The difference of the two numbers is: " + c);
        }
        public void mul()
        {
            c = a * b;
            Console.WriteLine("The product of the two numbers is: " + c);
        }
        public void div()
        {
            if (b != 0)
            {
                c = a / b;
                Console.WriteLine("The quotient of the two numbers is: " + c);
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
        }

    }
}
