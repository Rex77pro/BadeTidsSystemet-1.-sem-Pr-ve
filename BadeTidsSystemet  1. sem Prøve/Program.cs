using System;

namespace BadeTidsSystemet__1._sem_Prøve
{
    class Program
    {
        static void Main(string[] args)
        {
            BadetidsPeriode b1 = new BadetidsPeriode("Badning", DayOfWeek.Saturday, new DateTime().AddHours(6).AddMinutes(30), new DateTime().AddHours(8).AddMinutes(0));
            Console.WriteLine(b1);

            Console.WriteLine();

            b1.AdderKreds("Jun", new Kreds("Jun", "Junior", "Gothersgade 120, København", 35));
            b1.AdderKreds("Vik", new Kreds("Vik", "Vikinger", "Alfabetsvej 28, ABC 123", 28));
            Console.WriteLine(b1);

            Console.WriteLine();

            b1.SletKreds("HUP");
            b1.SletKreds("Vik");

            Console.WriteLine(b1);



            Console.WriteLine("\n");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }
    }
}
