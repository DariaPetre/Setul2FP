namespace Set2_ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            bool esteMonotonCrescatoare = true;
            bool esteMonotonDescrescatoare = true;

            Console.Write($"Introduceti numarul de pe pozitia {0}: ");

            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                Console.Write($"Introduceti numarul de pe pozitia {i}: ");
                int y = int.Parse(Console.ReadLine());

                if (x > y)
                    esteMonotonCrescatoare = false;
                if (x < y)
                    esteMonotonDescrescatoare = false;
                x = y;
            }
            if ( esteMonotonCrescatoare || esteMonotonDescrescatoare )
                Console.WriteLine("Secventa este monotona.");
            else
                Console.WriteLine("Secventa NU este monotona.");

        }
    }
}
