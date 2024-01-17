
namespace Set2_ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            Console.Write($"Introduceti numarul de pe pozitia {0}: ");
            int x = int.Parse(Console.ReadLine());

            bool bitonica = true;
            bool crescatoare = false;
            bool descrescatoare = false;

            

            for (int i = 1; i < n; i++) 
            {
                Console.Write($"Introduceti numarul de pe pozitia {i}: ");
                int y = int.Parse(Console.ReadLine());

                if (!crescatoare && descrescatoare)
                    bitonica = false;
                
                if(x < y)
                    crescatoare = true;
                if (x > y)
                    descrescatoare = true;
               
                if(crescatoare && descrescatoare && x<y)
                    bitonica = false;
                

                x = y;
            }

            if((crescatoare && !descrescatoare)|| (!crescatoare && descrescatoare))
                bitonica = false;

            if (bitonica)
                Console.WriteLine("Secventa este bitonica.");

            else
                Console.WriteLine("Secventa NU este bitonica.");
                
        }
    }
}