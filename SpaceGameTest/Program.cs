using ClassLibrary;
using System;
using System.Dynamic;
using static ClassLibrary.Enumerations;
using static ClassLibrary.Characters;


namespace SpaceGameTest
{

    class Program
    {
        static void Main(string[] args)
        {            
            StoryLine Story = new StoryLine();
            Weapons musket = new Weapons();
            var theMerchant = new TheMerchant
            {
                Health = 100,
                DefenseLvl = 100,
                AttackLvl = 60,
                Loot = 0,
                WeaponTypes = Sword,
            };

            theMerchant.Weapons.Add(musket);
            musket.WeaponType = WeaponTypes.Musket;
            
        }
    }
}

        //Alien.Health = ShotHit(TheMerchant, Alien);
        //{

        //{

           // string a = null;
           // Story.Prologue();

           // Console.WriteLine("Your first mission with Space Force is to go to planet Mars and retrieve an ore which is said to have magic powers,");
           // Console.WriteLine("This ore can help us dearly with our battle! We are counting on you!");
           // Console.ReadLine();
           // Console.WriteLine("These will be your weapon options... choose one to carry with you :");


           // Console.WriteLine("\ta - Sword");
           // Console.WriteLine("\tb - Musket");
           // Console.WriteLine("\tc - Grenades");
           // Console.WriteLine("\td - Sniper Rifle");
           // a = Console.ReadLine();


           // if (a == "a")
           // {
           //     Console.WriteLine("Sword.. a true warrior weapon Great choice! lets see if you can handle it");
           //     Console.ReadLine();
           // }

           // else if (a == "b")
           // {
           //     Console.WriteLine("musket.. I hope you know how to use it");
           //     Console.ReadLine();
           // }
           // else if (a == "c")
           // {
           //     Console.WriteLine("Grenades.. be quick and accurate.. make these 5 count!");
           //     Console.ReadLine();
           // }

           //else if(a == "d")
           // {
           //     Console.WriteLine("Sniper Rifle.. One Shot.. One Kill.. make each shot count!");
           //     Console.ReadLine();
           // }


           // Console.WriteLine("<0_0> greetings Human what are you doing on our planet?!");
           // Console.ReadLine();
        
    
