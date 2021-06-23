using System;

namespace Primes_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, cont = 0;
			Console.WriteLine("Primes Counter");
			Console.Write("Hasta que número primo desea contar ");
			
			numero = int.Parse(Console.ReadLine());
			
			for (int i = 1; i <= numero; i++)
			{
				if(numero % i == 0)
				{
					cont = cont + 1;
				}
			}
			if(cont == 2)
			{
				Console.WriteLine("Los números primos hasta " + numero + " son: ");
				Func<int> primo = PrimeOrNot(numero);
				Console.WriteLine(primo());
				
			}
			else
			{
				Console.WriteLine("Debió insertar un número primo");
				Environment.Exit(1);
			}
			
			
        }
		private static Func<int> PrimeOrNot(int x)
		{	
			
			return() =>
			{
				int num, cont = 0;
				num = 2;
				
				while (num < x)
				{
					for (int i = 1; i <= num; i++)
					{
						if(num % i == 0)
						{
							cont = cont + 1;
						}
					}
					if(cont == 2)
					{
						Console.WriteLine(num);
					}
					else
					{
						cont = 0;
					}
					num++;
				}
				return num;
			};
		}
    }
}
