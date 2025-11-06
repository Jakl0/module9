namespace kalk_bmi
{
    internal class Program
    {
        static double ObliczBMI(double a,double b)
        {
            b = b / 100;
            b = b * b;
            return a / b;
        }
        static string InterpretujBMI(double bmi)
        {
            string a;
            if (bmi >=30) {
                a = "Otyłość";
            }
            else if(bmi <30 && bmi > 25)
            {
                a = "Nadwaga";
            }
            else if (bmi > 18.5 && bmi < 25)
            {
                a = "Waga prawidłowa";
            }
            else
            {
                a = "Niedowaga";
            }
            return a;
        }
        static void Main(string[] args)
        {
            double waga;
            double wzrost;
            Console.WriteLine("podaj wzrost (cm)");
            wzrost = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj wagę (kg)");
            waga = int.Parse(Console.ReadLine());
            double bmi = ObliczBMI(waga,wzrost);
            Console.WriteLine($"{bmi:F2}");
            Console.WriteLine(InterpretujBMI(bmi));
        }
    }
}