using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_xml_dokumenti
{
    internal class Osoba
    {
        string ime, prezime;
        int godRod;

        public Osoba(string ime, string prezime, int godRod)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godRod = godRod;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public int GodRod { get => godRod; set => godRod = value; }

        public override string ToString()
        {
            return "Ime: " + Ime + "\r\nPrezime: " + Prezime + "\r\nGodina rođenja: " + godRod;
        }
    }
}
