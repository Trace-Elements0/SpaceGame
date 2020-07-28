using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Musket : Weapons
    {
        public void ShotHit(Characters TheMerchant, Characters Alien)
        {
            Alien.Health -= TheMerchant.AttackLvl;
        }
        public void ShotMiss()
        {
        //TODO
        }
    }
}