using System;

namespace BadeTidsSystemet__1._sem_Prøve
{
    class Program
    {
        static void Main(string[] args)
        {
            Kreds k1 = new Kreds("HUP", "HulaPigerne", "Mimersvej 4, 4600 Køge", 25);
            Console.WriteLine(k1);

            Console.WriteLine("\n");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }
    }
}
