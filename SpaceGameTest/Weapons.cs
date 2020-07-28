using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static ClassLibrary.Enumerations;

namespace ClassLibrary
{
    public class Weapons
    {
        public WeaponTypes WeaponType { get; set; }        
        public int Range { get; set; }
        public int Rank { get; set; }
    }
}