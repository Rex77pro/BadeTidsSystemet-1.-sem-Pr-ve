using System;
using System.Collections.Generic;
using System.Text;

namespace BadeTidsSystemet__1._sem_Prøve
{
    class BadetidsPeriode
    {
        //Type string Angiver typen af badeaktivitet – f.eks. ”Morgendukkert” eller ”Aftensvaler”. Default er ”Badning”
        //UgeDag DayOfWeek Dag i ugen hvor man må bade. Default er DayOfWeek.Sunday
        //StartTidspunkt DateTime Default er new DateTime()
        //SlutTidspunkt DateTime Default er new DateTime()

        private string _type;
        private DayOfWeek _ugeDag;
        private DateTime _startTidspunkt;
        private DateTime _slutTidsPunkt;
       

        public BadetidsPeriode(string Type, DayOfWeek UgeDag, DateTime Start, DateTime Slut)
        {
            _type = Type;
            _ugeDag = UgeDag;
            _startTidspunkt = Start;
            _slutTidsPunkt = Slut;

            Kredse = new Dictionary<string, Kreds>()
            {
                { "HUP", new Kreds ("HUB", "HulaPigerne", "Mimersvej 4, Køge", 25)  }
            };
            
        }

        public string Type { get; set; }
        public DayOfWeek UgeDag { get; set; }
        public DateTime Start { get; set; }
        public DateTime Slut { get; set; }
        public Dictionary<string, Kreds> Kredse { get; set; }


        public override string ToString()
        {
            string tekst = $"Type: {_type} | Dag: {_ugeDag} | Start: {_startTidspunkt.TimeOfDay}, Slut {_slutTidsPunkt.TimeOfDay}";

            foreach (var k in Kredse)
            {
                tekst = tekst + "\n" + k ;
            }
            return tekst;
        }

        public void AdderKreds(string id, Kreds kreds)
        {
            Kredse.Add(id, kreds);
        }

        public void SletKreds(string id)
        {
            Kredse.Remove(id);
        }
    }
}
