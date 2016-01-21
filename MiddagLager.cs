using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddagsVelger
{
    class MiddagLager
    {

        
        public Random Tilfeldig;

        string[] Middag = { "Taco", "Lasagne", "Kyllingsalat", "Kylling i creme fraiche", "Skinkesteik", "Biff og fløtegratinertepoteter", "Salat" };
        string[] Tilbehør = { "Rundstykker", "Brød", "Pasta", "Salat", "Ost", "noe2 ", "noe3 " };
        string[] Drikke = { "Cola", "Vin", "Vann", "Fanta", "Solo", "Agurkvann", "Øl" };

        public string GetMenuItem()
        {
            string tilfeldigMiddag = Middag[Tilfeldig.Next(Middag.Length)];
            string tilfeldigDrikke = Drikke[Tilfeldig.Next(Drikke.Length)];
            string tilfeldigTilbehør = Tilbehør[Tilfeldig.Next(Tilbehør.Length)];

            return tilfeldigMiddag + " med " + tilfeldigTilbehør + " og " +  tilfeldigDrikke;
            
        }

        public string SettMiddag()
        {
           

            return null;
        }

    }
}
