using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arvuppgift
{
    internal abstract class Figur
    {
        protected double area;
        protected double omkrets;

        public abstract double getOmkrets();
        public abstract double getArea();
        public abstract string getName();
    }

    class Cirkel : Figur// Cikel metoder
    {
        private double radie;
        public Cirkel(double radie) 
        {
            this.radie = radie;
        }

        public override double getOmkrets()
        {
            return Math.Round(2*Math.PI*radie, 3);
        }
        public override double getArea()
        {
            return Math.Round(Math.PI*Math.Pow(radie, 2), 3);
        }
        public override string getName()
        {
            return "Cirkel";
        }
    }

    class Rektangel : Figur// Rektangel metoder
    {
        private double value1 = 0;
        private double value2 = 0;
        public Rektangel(double hojd, double langd)
        {
            this.value1 = hojd;
            this.value2 = langd;
        }

        public override double getOmkrets()
        {
            double svar = value1 * 2 + value2 * 2;
            return Math.Round(svar, 3);
        }
        public override double getArea()
        {
            double svar = value1 * value2;
            return Math.Round(svar, 3);
        }
        public override string getName()
        {
            return "Rektangel";
        }
    }

    class Triangel : Figur// Triangel metoder
    {
        private double sida1 = 0;
        private double sida2 = 0;
        private double sida3 = 0;
        private string FigureName = "Triangel";

        public Triangel(double sida1, double sida2, double sida3)
        {
            this.sida1 = sida1;
            this.sida2 = sida2;
            this.sida3 = sida3;
        }

        public override double getArea()
        {
            double s = (sida1 + sida2 + sida3) / 2;
            double area = Math.Sqrt(s * (s - sida1) * (s - sida2) * (s - sida3));
            return Math.Round(area, 3);
        }
        public override double getOmkrets()
        {
            double omkrets = sida1 + sida2 + sida3;

            return Math.Round(omkrets, 3);
        }
        public override string getName()
        {
            FigureName = "Triangel";

            return FigureName;
        }

    }

    class Kvadrat : Rektangel// Kvadrat metoder
    {
        private double sida;
        public Kvadrat(double sida) : base(sida, sida)
        {
            this.sida = sida;
        }

        public override double getOmkrets()
        {
            return Math.Round(sida*4, 3);
        }
        public override double getArea()
        {
            return Math.Round(sida*sida, 3);
        }
        public override string getName()
        {
            return "Kvadrat";
        }
    }
}
