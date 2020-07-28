using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static ClassLibrary.Enumerations;

namespace ClassLibrary
{
    public class Weapon
    {
        public WeaponTypes WeaponType { get; set; }
        public int Range { get; set; }
        public int Rank { get; set; }
        public int HitPoints { get; set; }

        public Weapon(WeaponTypes types)
        {
            this.WeaponType = types;
            AssignWeapon(types);
        }

        private void AssignWeapon(WeaponTypes types)
        {
            switch (types)
            {
                case WeaponTypes.Musket:
                    this.HitPoints = 4;
                    this.Range = 6;
                    this.Rank = 2;
                    break;

                case WeaponTypes.Sword:
                    this.HitPoints = 6;
                    this.Range = 2;
                    this.Rank = 3;
                    break;
            }
        }

    }
}
