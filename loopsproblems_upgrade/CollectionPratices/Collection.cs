
namespace loopsproblems_upgrade.CollectionPratices

{
    public class Collection
    {

        public int CreateList()
        {
            var Search = 100;
            var Count = 0;
            int sum = 0;
            List<int> numbers = new List<int>();
            numbers.Add(100);
            numbers.Add(200);
            numbers.Add(300);
            numbers.Add(100);
            numbers.Add(400);
            numbers.Add(100);

            foreach (var n in numbers)
            {
                Console.WriteLine(n);


            }
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == Search)
                {
                    Count++;
                }
            
            }
            Console.WriteLine($"Search Item {Search} Found {Count} times.");
            Console.WriteLine(numbers.Capacity);



            for (int i = 0; i < numbers.Count; i++) { 
            
                sum +=numbers[i];
                int Index;
                if (numbers[i]==300)
                {
                    Console.WriteLine($"Index of 300 is {numbers.IndexOf(300)}");
                }
            
            }
            Console.WriteLine($"Addition of Collection List {sum}");
            return numbers.Count;
        }
    }
}