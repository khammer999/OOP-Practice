using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class SuperHero
    { //fields
        private double strengthLevel;
        private bool hasCape;
        private string superPower;
        private string nemesis;

        public double StrengthLevel
        {
            get { return this.strengthLevel; }
            set { this.strengthLevel = value; }
        }

        public bool HasCape
        {
            get { return this.hasCape; }
            set { this.hasCape = value; }
        }

        public string SuperPower
        {
            get { return this.superPower; }
            set { this.superPower = value; }
        }

        public string Nemesis
        {
            get { return this.nemesis; }
            set { this.nemesis = value; }
        }


        public SuperHero()
        {
            // default constructor
        }

        public SuperHero(double strengthLevel,bool hasCape,string superPower,string nemesis)
        {
            this.StrengthLevel = strengthLevel;
            this.HasCape = hasCape;
            this.SuperPower = superPower;
            this.Nemesis = nemesis;
            // overloaded constructor
        }

        public SuperHero(bool hasCape)
        {
            this.HasCape = hasCape;
        }

        //methods

        public void GetHealth(int strength)

        {
            StrengthLevel = strength/2;
            Console.WriteLine("Its Kryptonite!!! Strength level at {0} percent", StrengthLevel);
        }

        public double EatSpinach()
        {
            StrengthLevel = StrengthLevel * 1.25;
            return StrengthLevel;
        }

 

    }
}
