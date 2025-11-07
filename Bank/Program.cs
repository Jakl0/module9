namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stan;
            int kwota;
            int op;
            Console.WriteLine("Podaj początkowy stan konta");
            stan = int.Parse(Console.ReadLine());
            Console.Clear();
            while (true)
            {
                Console.WriteLine($"aktualny stan konta: {stan}zł");
                Console.WriteLine("Jaką operację chcesz wykonać?");
                Console.WriteLine("1.Wpłać");
                Console.WriteLine("2.Wypłać");
                do
                {
                    op = int.Parse(Console.ReadLine());
                } while (op != 1 && op != 2);
                Console.Clear();
                Console.WriteLine($"aktualny stan konta: {stan}zł");
                do
                {
                    Console.WriteLine("podaj kwotę ");
                    kwota = int.Parse(Console.ReadLine());
                } while (kwota < 0);



                if (op == 1)
                {
                    stan = stan + kwota;
                }
                else
                {
                    stan = stan - kwota;
                }
                kwota = 0;
                Console.Clear();
            }
        }
    }
}
