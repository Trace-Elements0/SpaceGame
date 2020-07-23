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

            string a = null;
            string Gender = null;
            string name;
            Console.WriteLine("In the galaxy called Milky Way, there has been a war going since before I was born.The Space Force started the war,");
            Console.WriteLine("spreading order and peace However, a Rebellion was formed to counter Space Force.");
            Console.WriteLine("For years, lives have been lost and put to misery.. All thanks to the Rebellion,");
            Console.WriteLine("that is why I want to join the Space Force, to help establish peace.Right now,");
            Console.WriteLine("I am on my way to Space Force Headquarters to start my training as a recruit");
            Console.WriteLine("This is where my journey begins…….. Press enter to continue");
            Console.ReadLine();

            Console.WriteLine("Enter you Gender : ");
            Console.WriteLine("\t - male");
            Console.WriteLine("\t - female");
            Gender = Console.ReadLine();


            if (Gender == "male")
            {
                Console.WriteLine("Alright brother lets do this! press enter to continue...");
                Console.ReadLine();
            }
           else if ( Gender == "female")
            {
                Console.WriteLine("Ay ay Mam!, lets get to it! press enter to continue...");
                Console.ReadLine();
            }

            Console.WriteLine(" <0__0>.. Welcome to the Space Force Recruit.. type in your name now.. ");
            name = Console.ReadLine();

            Console.WriteLine("Wow! what an ugly name...  well " + name);
            Console.WriteLine("your first mission is to go to planet Mars and retrive an ore which is said to have magic powers,");
            Console.WriteLine("This ore can help us dearly with our battle! " + name + (" we are counting on you!"));
            Console.ReadLine();
            Console.WriteLine("These will be your weapon options... choose one to carry with you :");


            Console.WriteLine("\ta - Sword");
            Console.WriteLine("\tb - Ray Gun");
            Console.WriteLine("\tc - 5 Grenades");
            Console.WriteLine("\td - Sniper Rifle");
            a = Console.ReadLine();


            if (a == "a")
            {
                Console.WriteLine("Sword.. a true warrios weapon Great choice! lets see if you can handle it");
                Console.ReadLine();
            }

            else if (a == "b")
            {
                Console.WriteLine("Ray gun.. I hope you know how to use it");
                Console.ReadLine();
            }
            else if (a == "c")
            {
                Console.WriteLine("Grenades.. be quick and accurate.. make these 5 count!");
                Console.ReadLine();
            }

           else if(a == "d")
            {
                Console.WriteLine("Sniper Rifle.. One Shot.. One Kill.. make each shot count!");
                Console.ReadLine();
            }


            Console.WriteLine("<0_0> greetings Human what are you doing on our planet?!");
            Console.ReadLine();







            
        }
    }
}
