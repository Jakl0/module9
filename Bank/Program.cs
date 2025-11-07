namespace Bank
{
    class Konto_Bankowe
    {
        private int stan;
        private int kwota;
        private int op;
        private int koniec = 1;

        public void wczytaj_dane()
        {
            Console.WriteLine("Podaj początkowy stan konta");
            stan = int.Parse(Console.ReadLine());
        }
        public void wyswietl(){
            Console.Clear();
            Console.WriteLine($"aktualny stan konta: {stan}zł");
        }
        public void wybierz()
        {
            Console.WriteLine("Jaką operację chcesz wykonać?");
            Console.WriteLine("1.Wpłać");
            Console.WriteLine("2.Wypłać");
            Console.WriteLine("3.Zakończ");
            do
            {
                op = int.Parse(Console.ReadLine());
            } while (op != 1 && op != 2 && op != 3);
        }
        public void wpisz_kwote()
        {
            do
            {
                Console.WriteLine("podaj kwotę ");
                kwota = int.Parse(Console.ReadLine());
            } while (kwota < 0);
        }
        public void przelicz()
        {
            if (op == 1)
            {
                stan = stan + kwota;
            }
            else if (op ==3)
            {
                koniec = 0;
            }
            else
            {
                stan = stan - kwota;
            }
        }
        public void aplikacja()
        {
            wczytaj_dane();
            while (koniec == 1)
            {
                wyswietl();
                wybierz();
                if (op == 3) {
                    break;
                }
                wyswietl();
                wpisz_kwote();
                przelicz();
                wyswietl();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Konto_Bankowe b1 = new Konto_Bankowe();
            b1.aplikacja();
        }
    }
}
