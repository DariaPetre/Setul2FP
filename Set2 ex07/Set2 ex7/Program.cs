namespace Set2_ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            int max = -2147483647 - 1;
            int min = 2147483647;
           


            for (int i = 0; i < n; i++) 
            {
                Console.Write($"Introduceti numarul de pe pozitia {i}: ");

                int x = int.Parse(Console.ReadLine());

                if (x > max)
                    max = x;
                if (x < min)
                    min = x;
            }
            Console.WriteLine($"Minimul secventei este {min}.");
            Console.WriteLine($"Maximul secventei este {max}.");

        }
    }
}