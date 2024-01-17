namespace Set2_ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            double suma = 0;

            for(int i = 0; i < n; i++) 
            {
                Console.Write($"Introduceti numarul de pe pozitia {i}: ");
                double x = double.Parse(Console.ReadLine());
                suma = suma + (1 / x);

            }
            Console.WriteLine(suma);
        }
    }
}