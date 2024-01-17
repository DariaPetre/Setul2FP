namespace Set2_ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            bool esteCrescatoare = true;

            Console.Write($"Introduceti numarul de pe pozitia {0}: ");
            int x = int.Parse(Console.ReadLine());
            
            for (int i = 1; i < n; i++) 
            {
                Console.Write($"Introduceti numarul de pe pozitia {i}: ");
                int y = int.Parse(Console.ReadLine());

                if (x > y)
                    esteCrescatoare = false;                 
                x = y;
            }
            if (esteCrescatoare)
                Console.WriteLine("Secventa este crescatoare.");
            else
                Console.WriteLine("Secventa NU este crescatoare.");

        }
    }
}