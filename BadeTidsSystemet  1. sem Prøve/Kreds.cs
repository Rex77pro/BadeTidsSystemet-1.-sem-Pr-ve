using System;
using System.Collections.Generic;
using System.Text;

namespace BadeTidsSystemet__1._sem_Prøve
{
    class Kreds
    {

        //ID- string Kredsens ID
        //Navn string Kredsens navn
        //Adresse string Kredsens adresse
        //AntalDeltagere int Antallet af personer kredsen deltager med

        private string _id;
        private string _navn;
        private string _adresse;
        private int _deltagere;

        public Kreds(string Id, string Navn, string Adresse, int Deltagere)
        {
            _id = Id;
            _navn = Navn;
            _adresse = Adresse;
            _deltagere = Deltagere;
        }

        public string Id { get; set; }
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public int Deltagere { get; set; }

        public override string ToString()
        {
            return $"Id: {_id} | Navn: {_navn} | Adresse: {_adresse} | Antal deltagere: {_deltagere}";
        }

    }
}
