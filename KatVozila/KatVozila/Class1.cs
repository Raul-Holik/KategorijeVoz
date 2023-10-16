using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatVozila
{
    class Vozila
    {
        string model, godiste, brKotaca;
        string kategorija;
        

        public Vozila(string model,string godiste, string brKotaca,string kategorija)
        { 
            this.model = model;
            this.godiste = godiste;
            this.brKotaca = brKotaca;
            this.kategorija = kategorija;
            
        }

        public string Model { get=>model; set=>model=value; }
        public string Godiste { get=>godiste; set=>godiste=value; }
        public string BrKotaca { get=>brKotaca; set=>brKotaca=value; }
        public string Kategorija { get=>Kategorija; set=>Kategorija=value; }
    }
}
