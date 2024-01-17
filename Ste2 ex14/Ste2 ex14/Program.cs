
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
            int contorDescrescatoare = 0;
            int contorCrescatoare = 0;
            /*
              Conditii:
              -sa existe maxim doua subsecvente ordonate (1.crescator sau 2.descrescator)
              -1.(primul numar) > (ultimul numar) sau 2.(primul numar) < (ultimul numar)
            */
            for (int i = 1; i < n; i++)
            {
                Console.Write($"Introduceti numarul de pe pozitia {i}: ");
                int y = int.Parse(Console.ReadLine());
                if (x > y)
                    contorDescrescatoare++;
                if (x < y)
                    contorCrescatoare++;


                x = y;
            }
            if ((contorDescrescatoare <= 1 && primulNumar > x) || (contorCrescatoare <= 1 && primulNumar < x))
                Console.WriteLine("Secventa este monotona rotita.");
            else
                Console.WriteLine("Secventa NU este monotona rotita.");

        }
    }
}