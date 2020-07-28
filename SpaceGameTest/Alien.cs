using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static ClassLibrary.Enumerations;

namespace ClassLibrary
{
    public class Alien
    {   
        public AlienTypes AlienType { get; set; }
        public int Health { get; set; }
        public int DefenseLvl { get; set; }
        public float Loot { get; set; }
        public List<Product> Products { get; set; }
        public List<Weapon> Weapons { get; set; }


        public Alien(AlienTypes types)
        {
            this.AlienType = types;
            AssignAlien(types);
        }

        private void AssignAlien(AlienTypes types)
        {
            switch (types)
            {
                case AlienTypes.Fred:
                    this.Health = 4;
                    this.DefenseLvl = 6;
                    this.Loot = 2;
                    Product
                    break;

                case WeaponTypes.:
                    this.HitPoints = 6;
                    this.Range = 2;
                    this.Rank = 3;
                    break;
            }
        }
    }
}
