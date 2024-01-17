using System.Runtime.Intrinsics.X86;

namespace Set2_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            int catePare = 0;

            for (int i = 1; i <= n; i++) 
            {
                Console.Write($"Introduceti numarul de pe pozitia {i}: ");
                int x = int.Parse(Console.ReadLine());
                if( x % 2 == 0 )
                {
                    catePare++;
                }
            }

            Console.WriteLine($"In secventa sunt {catePare} numere pare.");
            
        }
    }
}