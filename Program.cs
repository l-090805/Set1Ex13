namespace Set1Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti anul y1: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Introduceti anul y2: ");
            int y2 = int.Parse(Console.ReadLine());

            int count = 0;

            for( int an = y1 ; an <= y2 ; an++ )
            {
                if(EsteBisect( an))
                {
                    count++;
                }
            }

            Console.WriteLine($"Ingtre anul {y1} si {y2} exista {count} ani bisecti");


            static bool EsteBisect(int an)
            {
                return (an % 4 == 0 && an % 100 != 0 || an % 400 == 0);
            }

        }
    }
}
