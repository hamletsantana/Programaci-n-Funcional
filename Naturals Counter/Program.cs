using System;

namespace Naturals_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Naturals Counter");
			Console.Write("Hasta qué número? ");
			
			int numero = int.Parse(Console.ReadLine());
			
			Func<int> countUpTo = createCountUpTo(numero);
			
			for (int b = 0; b < numero; b++)
			{
				Console.WriteLine(countUpTo());
			}
        }
		
		private static Func<int> createCountUpTo(int x)
		{
			int i = 0;
			
			return() =>
			{
				i += 1;
				if (i == x + 1)
				{
					i = 1;
				}
				return i;
			};
		}
    }
}
