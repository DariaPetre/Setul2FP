
namespace Set2_ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            Console.Write($"Introduceti numarul de pe pozitia {0}: ");
            int x = int.Parse(Console.ReadLine());

            int primulNumar = x;
            int contor = 0;
            /*
              Conditii:
              -sa existe maxim doua subsecvente ordonate crescator
              -(primul numar) > (ultimul numar)
            */
            for (int i = 1; i < n; i++) 
            {
                Console.Write($"Introduceti numarul de pe pozitia {i}: ");
                int y = int.Parse(Console.ReadLine());
                if (x > y)
                    contor++;
                    
                x = y;
            }
           if( contor <= 1 && primulNumar > x) 
                Console.WriteLine("Secventa este crescatoare rotita.");
            else
                Console.WriteLine("Secventa NU este crescatoare rotita.");

        }
    }
}