using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci");
			Console.Write("Hasta qué número? ");
			
			int numero = int.Parse(Console.ReadLine());
			
			Func<int> countUpTo = createCountUpTo(numero);
			Console.WriteLine(0);
			for (int i = 0; i < numero; i++)
			{
				Console.WriteLine(countUpTo());
			}
        }
		private static Func<int> createCountUpTo(int x)
		{	
			int num1 = 0, num2 = 1, suma;
			return() =>
			{
				suma = num1;
				num1 = num2;
				num2 = suma + num1;
				return num1;
			};
		}
		
    }
}
