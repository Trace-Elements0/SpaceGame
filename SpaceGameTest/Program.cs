using ClassLibrary;
using System;
using static ClassLibrary.Enumerations;

namespace SpaceGameTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TheMerchant player = new TheMerchant();
            Weapons musket = new Weapons();
            musket.WeaponType = WeaponTypes.Musket;
            player.Weapons.Add(musket);
        }
    }
}
