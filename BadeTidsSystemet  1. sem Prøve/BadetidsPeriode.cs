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

        Dictionary<string, Kreds> kredse = new Dictionary<string, Kreds>()
        {
            { "HUP", new Kreds ("HUB", "HulaPigerne", "Mimersvej 4, 4600 Køge", 25)  }
        };

        public BadetidsPeriode(string Type, DayOfWeek UgeDag, DateTime Start, DateTime Slut)
        {
            _type = Type;
            _ugeDag = UgeDag;
            _startTidspunkt = Start;
            _slutTidsPunkt = Slut;
            
        }

        public string Type { get; set; }
        public DayOfWeek UgeDag { get; set; }
        public DateTime Start { get; set; }
        public DateTime Slut { get; set; }

        public override string ToString()
        {
            return $"Type: {_type} | Dag: {_ugeDag} | Start: {_startTidspunkt}, Slut {_slutTidsPunkt}";
        }


    }
}
