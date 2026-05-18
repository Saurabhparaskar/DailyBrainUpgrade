

namespace loopsproblems_upgrade
{
    public class ForEachLoops
    {
        public void printArrayList()
        {
            int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 1000 };

            foreach (int num in numbers)
            {
                Console.WriteLine($"Number: {num}");

            }

        }
    }
}
