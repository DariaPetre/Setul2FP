namespace Set2_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            int suma = 0;
            decimal produs = 1;

            for (int i = 1; i <= n; i++)
            {
                suma = suma + i;
                produs = produs * i;
            }
            Console.WriteLine($"Suma numerelor de la 1 la n este {suma}");
            Console.WriteLine($"Produsul numerelor de la 1 la n este {produs}");

        }
    }
}