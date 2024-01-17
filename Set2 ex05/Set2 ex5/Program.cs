

namespace Set2_ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            int cateEgaleCuPoz = 0;

            for(int i = 0; i < n; i++) 
            {
                Console.Write($"Introduceti numarul de pe pozitia {i}: ");
                int x = int.Parse(Console.ReadLine());

                if (x == i)
                {
                    cateEgaleCuPoz++;
                }
            }
            Console.WriteLine(cateEgaleCuPoz);
        }
    }
}