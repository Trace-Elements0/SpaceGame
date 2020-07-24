using SpaceGameTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace ClassLibrary
{
    public class TheMerchant : Characters
    {
        public TheMerchant()
        {
            this.MerchantBag = new List<Products>();
            this.Weapons = new List<Weapons>();
        }

        public int Loot
        {
            get => default;
            set
            {
            }
        }

        public List<Products> MerchantBag
        {
            get => default;
            set
            {
            }
        }

        public List<Weapons> Weapons
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// The Merchants action of space travel
        /// </summary>
        public void Travel(Planets )
        {
            Console.WriteLine("The Merchant embarks on a long journey too {planet}."0,);
        }

        public void Win()
        {
            if (Loot >= 100) || (StoryLine.FinalChapter == complete)
                Console.WriteLine("The Merchant has successfully completed the game. Great job!"):
        }

        public string Lose()
        {
                Console.WriteLine("Better luck next time. You've gotten The Merchant killed." +
                    "\n Would you like to try again?" +
                    "\n Select Y or N followed by selecting enter.");
            string response = Console.ReadLine();
            if (response == Y)
            {
                Restart();
            }
            else if (response == N)
            {
                Console.WriteLine("Come back and see us soon.");

            }
        }
    }
}