
namespace Set2_ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            Console.Write($"Introduceti numarul de pe pozitia {0}: ");
            int x = int.Parse(Console.ReadLine());

            bool corect = true;
            int contorZero = 0;
            int contorOne = 0;
            int contorIncuibare = 1;

            if (x == 1)
                corect = false;
            else
            {
                contorZero++;

                for (int i = 1; i < n; i++)
                {
                    Console.Write($"Introduceti numarul de pe pozitia {i}: ");
                    int y = int.Parse(Console.ReadLine());

                    if (y == 0)
                    {
                        contorZero++;

                        if (x == 0)
                            contorIncuibare++;
                    }
                    else
                        contorOne++;

                    if (contorOne > contorZero)
                        corect = false;

                    x = y;
                }
            }
            if (contorZero != contorOne)
                 corect = false;

            if (corect)
                Console.WriteLine($"Secventa este corecta, iar maxiumul de incuibare este {contorIncuibare}.");
            else
                Console.WriteLine("Secventa NU este corecta.");

        }
    }
}