using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static ClassLibrary.Enumerations;

namespace ClassLibrary
{
    public class Characters
    {
        public Characters()
        {
            this.Products = new List<Product>();
            this.Weapons = new List<Weapon>();
            this.Planets = new List<Planet>();
        }
        public int Health { get; set; }
        public string Name { get; set; }
        public int DefenseLvl { get; set; }       
        public float Loot { get; set; }
        public List<Product> Products { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<Planet> Planets { get; set; }
    }
}