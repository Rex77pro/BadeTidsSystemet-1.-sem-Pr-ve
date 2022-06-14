using System;

namespace BadeTidsSystemet__1._sem_Prøve
{
    class Program
    {
        static void Main(string[] args)
        {
            Kreds k1 = new Kreds("HUP", "HulaPigerne", "Mimersvej 4, 4600 Køge", 25);
            Console.WriteLine(k1);

            BadetidsPeriode b1 = new BadetidsPeriode("Badning", DayOfWeek.Saturday, new DateTime().AddHours(6).AddMinutes(30), new DateTime().AddHours(8).AddMinutes(0));
            Console.WriteLine(b1);

            Console.WriteLine("\n");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }
    }
}
