using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static ClassLibrary.Enumerations;

namespace ClassLibrary
{
    public class Characters
    {
        public int Health;
        public string? Name;
        public int DefenseLvl;
        public int AttackLvl;
        public float Loot;
        public string[] Products;
        public Enumerations Weapons;

        public void Defend()
        {
            throw new System.NotImplementedException();
        }

        public void Sell()
        {
            throw new System.NotImplementedException();
        }

        public void Buy()
        {
            throw new System.NotImplementedException();
        }
    }
}