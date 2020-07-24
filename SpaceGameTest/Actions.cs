using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class Actions
    {
        public void Attack()
        {
        //TODO:
        }
        public void AttackAlien(Characters TheMerchant, Characters Alien)
        {
            Console.WriteLine("The Merchant lands a heavy hit on the alien.");
            Alien.health -= TheMerchant.Attack;
            while (Alien.health != 0)
                Console.WriteLine("The Alien lives to fight another day");
            else
                Alien.Die();
        }
        public void AttackMerchent()
        {
            //TODO
        }
        public Buy()
        {
            //TODO
        }
        public Defend()
        {

        }
        public Die()
        {
            //TODO:
        }
        public Sell()
        {
            //TODO
        }
        public Restart()
        {

        }



    }
}