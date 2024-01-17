namespace Set2_ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            Console.Write($"Introduceti numarul de pe pozitia {0}: ");
            int x = int.Parse(Console.ReadLine());

            int lungime = 1;
            int lmax = 1;

            for (int i = 1; i < n; i++) 
            {
                Console.Write($"Introduceti numarul de pe pozitia {i}: ");
                int y = int.Parse(Console.ReadLine());

                if (x == y)
                {
                    lungime++;
                    if (lungime > lmax)
                        lmax = lungime;
                }
                else lungime = 1;

                x = y;
            }
            Console.WriteLine(lmax);
        }
    }
}