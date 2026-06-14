

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


    }
}
