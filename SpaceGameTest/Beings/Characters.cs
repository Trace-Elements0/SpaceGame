using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using AutoMapper.Internal;
using Unipluss.Sign.ExternalContract.Entities;

namespace SpaceGameTest
{
    public class Characters
    {
        //getsets auotmap the properties
        //Health is a read only property so that it cannot be assigned a
        //different value. It starts at 100 for any character in the game
        public string Name { get; set; }
        public int Health { get; set; }
        public int Loot { get; set; }
        public int? Experience { get; set; }
        public Products Products { get; set; }
        public Weapons Weapons { get; set; }
    }
    public enum Products : short { Ore, Kit, Petroleum, Fuel, Hydrogen, Food, Aluminum }
    public enum Weapons { Musket = 1, Sword, Blunderbuss, Dukes }
}