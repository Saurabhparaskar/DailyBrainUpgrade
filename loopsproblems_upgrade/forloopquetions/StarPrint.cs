

namespace loopsproblems_upgrade.forloopquetions
{
    public class StarPrint
    {
        public void starPrint()
        {
            int n = 10;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
