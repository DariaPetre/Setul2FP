namespace Set2_ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            int contor = 0;

            Console.Write($"Introduceti numarul de pe pozitia {0}: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write($"Introduceti numarul de pe pozitia {1}: ");
            int y = int.Parse(Console.ReadLine());

            for (int i = 2; i < n; i++) 
            {
                Console.Write($"Introduceti numarul de pe pozitia {i}: ");
                int z = int.Parse(Console.ReadLine());

                if( x != 0 &&  y != 0 && z == 0 )
                    contor++;
                x = y;
                y = z;

            }
            if (x != 0 && y != 0)
                contor++;
            Console.WriteLine($"In secventa sunt {contor} grup/grupuri de numere separate prin 0.");
        }
    }
}