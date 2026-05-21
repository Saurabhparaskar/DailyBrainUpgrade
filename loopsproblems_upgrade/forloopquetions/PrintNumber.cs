using System;

public class PrintNumber
{
	public void PrintNumbers()
	{
		int count = 0;
		for (int i=0;i<=10;i++)
		{
			Console.WriteLine(i);
			count++;
        }
        Console.WriteLine("Total Numbers "+count);
        Console.ReadLine(); 

    }
   
}
