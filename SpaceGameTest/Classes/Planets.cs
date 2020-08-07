using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceGameTest
{
    class Planets
    {
        void Saturn()
        {
            Alien saturnAlien = new Alien();
            {
                saturnAlien.Name = "Zoidburg";
                saturnAlien.Health = 100;
                saturnAlien.Loot = 75;
                saturnAlien.Product = Characters.ProductTypes.Hydrogen;
                saturnAlien.CharacterType = Characters.CharacterTypes.Alien;
            }
        }

        void Mars()
        {
            Alien marsAlien = new Alien();
            {
                marsAlien.Name = "Fred";
                marsAlien.Health = 100;
                marsAlien.Loot = 65;
                marsAlien.Product = Characters.ProductTypes.Ore;
                marsAlien.CharacterType = Characters.CharacterTypes.Alien;
            }
        }

        void Venus()
        {
            Alien venusAlien = new Alien();
            {
                venusAlien.Name = "Bert";
                venusAlien.Health = 100;
                venusAlien.Loot = 60;
                venusAlien.Product = Characters.ProductTypes.Petroleum;
                venusAlien.CharacterType = Characters.CharacterTypes.Alien;
            }
        }

        void Jupiter()
        {
            Alien jupiterAlien = new Alien();
            {
                jupiterAlien.Name = "Ernie";
                jupiterAlien.Health = 100;
                jupiterAlien.Loot = 75;
                jupiterAlien.Product = Characters.ProductTypes.Aluminum;
                jupiterAlien.CharacterType = Characters.CharacterTypes.Alien;
            }
        }
    }
}

    
