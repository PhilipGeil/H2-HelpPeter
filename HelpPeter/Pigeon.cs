using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpPeter
{
    class Pigeon : Bird, IFly
    {
        public override void SetLocation(double longitude, double latitude)
        {
            //sæt en lokation
        }

        public void SetAltitude(double altitude)
        {
            //Sæt en højde  
        }

        public override void Draw()
        {
            //Tegn fuglen på skærmen
        }

        public override string ToString()
        {
            return "I am Pigeon";
        }
    }
}
