using loopsproblems_upgrade.forloopquetions;
using loopsproblems_upgrade.userinput;

namespace loopsproblems_upgrade
 
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Loops obj = new Loops();
            //obj.PrintNumbers();

            //Factorial obj1 = new Factorial();
            //obj1.factorial();
            //ForEachLoops f2 = new ForEachLoops();
            //f2.printArrayList();
            //PrintNumber p1 = new PrintNumber();
            //p1.PrintNumbers();
            //SwitchCase s = new SwitchCase();
            //s.switchCase();
            //StarPrint star = new StarPrint();
            //star.starPrint();


            CalculationUserInput c = new CalculationUserInput();
            c.GetUserInput();
            c.sum();
        }
    }

}
