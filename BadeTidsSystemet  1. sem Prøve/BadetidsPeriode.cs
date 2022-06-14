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

        public string _type;
        public DayOfWeek _ugeDag;
        public DateTime _startTidspunkt;
        public DateTime _slutTidsPunkt;
       

        public BadetidsPeriode(string Type, DayOfWeek UgeDag, DateTime Start, DateTime Slut)
        {
            this.Type = Type;
            _ugeDag = UgeDag;
            _startTidspunkt = Start;
            _slutTidsPunkt = Slut;

            Kredse = new Dictionary<string, Kreds>()
            {
                { "HUP", new Kreds ("HUB", "HulaPigerne", "Mimersvej 4, Køge", 25)  }
            };
            
        }

        public string Type
        { get { return _type; } 
            set {
                if (value.Length < 4)
                {
                    throw new ArgumentException("Minimum 4 tegn");
                }
                _type = value;
            } }
        public DayOfWeek UgeDag 
        { get; set; }
        public DateTime Start
        {
            get
            {
                return _startTidspunkt;
            }
            set 
            {
                if (_startTidspunkt > _slutTidsPunkt)
                {
                    throw new ArgumentException("StartTidspunktet skal være mindre end Sluttidspunktet");
                }
                
                
            }
        }
        public DateTime Slut { get { return _slutTidsPunkt; } set { _slutTidsPunkt = value; } }
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
