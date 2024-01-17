
namespace Set2_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());


            int poz = -1;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti numarul de pe pozitia {i}: ");
                int x = int.Parse(Console.ReadLine());

                if (x == a)
                {                   
                    poz = i;
                }
                    
            }
            Console.WriteLine(poz);
            
        }
    }
}