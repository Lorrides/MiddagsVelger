﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddagsVelger
{
    class MiddagLager
    {
        public Random Tilfeldig;

        string[] Middag = { "Taco", "Lasagne", "Kyllingsalat", "Kylling i creme fraiche", "Skinkesteik", "Biff og fløtegratinertepoteter", "Torsk" ,"Laks" };
        string[] Tilbehør = { "rundstykker", "brød", "pasta", "salat", "ost", "muffins!", "ertestuing" , "poteter" , "pomesfrites" };
        string[] Drikke = { "Cola", "vin", "vann", "fanta", "solo", "agurkvann", "øl" ,"pepsi"};

        public string GetMenuItem()
        {
            string tilfeldigMiddag = Middag[Tilfeldig.Next(Middag.Length)];
            string tilfeldigDrikke = Drikke[Tilfeldig.Next(Drikke.Length)];
            string tilfeldigTilbehør = Tilbehør[Tilfeldig.Next(Tilbehør.Length)];

            return tilfeldigMiddag + " med " + tilfeldigTilbehør + " og " +  tilfeldigDrikke;
            
        }
    }
}
