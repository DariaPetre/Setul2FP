
namespace Set2_ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibo(n));
        }
        static int Fibo(int n)
        {
            int k = 2, a, b, c;
            a = 0;
            b = 1;
            if (n == 1) return 0;
             else if (n == 2) return 1;
                else
                {
                    while (k < n)
                    {
                        c = a + b;
                        a = b;
                        b = c;
                        k++;
                    }
                 
                }
            return b;
        }
    }
}