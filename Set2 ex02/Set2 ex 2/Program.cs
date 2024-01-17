namespace Set2_ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            int cateNegative = 0;
            int catePozitive = 0;
            int cateSuntZero = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Introduceti numarul de pe pozitia {i}: ");
                int x = int.Parse(Console.ReadLine());

                if (x < 0)
                    cateNegative++;

                if (x == 0)
                    cateSuntZero++;

                if (x > 0)
                    catePozitive++;
            }

            Console.WriteLine($"In secventa sunt {cateNegative} numere negative.");
            Console.WriteLine($"In secventa sunt {cateSuntZero} numere egale cu 0.");
            Console.WriteLine($"In secventa sunt {catePozitive} numere pozitive.");
        }
    }
}