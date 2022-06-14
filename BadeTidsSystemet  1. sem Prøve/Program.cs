using System;

namespace BadeTidsSystemet__1._sem_Prøve
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BadetidsPeriode b1 = new BadetidsPeriode("Badning", DayOfWeek.Saturday, new DateTime(2022,6,14,6,30,00), new DateTime(2022,6,14,8,00,00));
                Console.WriteLine(b1);
                Console.WriteLine();

                b1.AdderKreds("Jun", new Kreds("Jun", "Junior", "Gothersgade 120, København", 32));
                b1.AdderKreds("Vik", new Kreds("Vik", "Vikinger", "Alfabetsvej 28, ABC 123", 28));
                Console.WriteLine(b1);

                Console.WriteLine();

                b1.SletKreds("HUP");
                b1.SletKreds("Vik");

                Console.WriteLine(b1);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex); ;
            }



            Console.WriteLine("\n");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }
    }
}
