﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasljeđivanje_vježba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            NebeskoTijelo nebeskoTijelo = new NebeskoTijelo();
            Planet planet = new Planet(1000, 2000);
            Satelit satelit = new Satelit(100, 200);

            Console.WriteLine(nebeskoTijelo.Ispis());
            Console.WriteLine(planet.Ispis());
            Console.WriteLine(satelit.Ispis());

            Console.ReadKey();

        }
    }
    class NebeskoTijelo
    {
        double BrzinaOkoOsi, BrzinaOkoSunca;

        public double BrzinaOkoOsi1 { get => BrzinaOkoOsi; set => BrzinaOkoOsi = value; }
        public double BrzinaOkoSunca1 { get => BrzinaOkoSunca; set => BrzinaOkoSunca = value; }

        public virtual string Ispis()
        {
            return "Nebesko tijelo ima brzinu oko osi: " + BrzinaOkoOsi1 + " i ima brzinu oko sunca: " + BrzinaOkoSunca1 + ".";
        }
    }
    class Planet : NebeskoTijelo
    {
        public Planet(double brzinaOkoOsi, double brzinaOkoSunca)
        {
            BrzinaOkoOsi1 = brzinaOkoOsi;
            BrzinaOkoSunca1 = brzinaOkoSunca;
        }

        public override string Ispis()
        {
            return "Planet ima brzinu oko osi: " + BrzinaOkoOsi1 + " i ima brzinu oko sunca: " + BrzinaOkoSunca1 + "."; ;
        }
    }

    class Satelit : NebeskoTijelo
    {
        public Satelit(double brzinaOkoOsi, double brzinaOkoSunca)
        {
            BrzinaOkoOsi1 = brzinaOkoOsi;
            BrzinaOkoSunca1 = brzinaOkoSunca;
        }

        public override string Ispis()
        {
            return "Satelit ima brzinu oko osi: " + BrzinaOkoOsi1 + " i ima brzinu oko sunca: " + BrzinaOkoSunca1 + "."; ;
        }
    }
}
