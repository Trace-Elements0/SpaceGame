using ClassLibrary;
using System;
using System.Dynamic;
using static ClassLibrary.Enumerations;

namespace SpaceGameTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TheMerchant player = new TheMerchant();
            Weapons musket = new Weapons();
            StoryLine Story = new StoryLine();
            musket.WeaponType = WeaponTypes.Musket;
            player.Weapons.Add(musket);

            string a = null;
            string Gender = null;
            string name;
            //Took the ling pieces of write line and made a story class and we'll be able to call the 
            //parts of the story as methods as we go through. This first one below is called Prologue.
            Story.Prologue();
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
            //Didn't take it out but if we do remove the option to enter a custom name we save ourselves the 
            //need to keep reiterating a placeholder for the name. Last game I played was Halo 3. An you don't
            //get the option to change Master Chiefs name? Let's talk throuigh it.
            Console.WriteLine(" <0__0>.. Welcome to the Space Force Recruit.. type in your name now.. ");
            name = Console.ReadLine();

            Console.WriteLine("Wow! what an ugly name...  well " + name);
            Console.WriteLine("your first mission is to go to planet Mars and retrive an ore which is said to have magic powers,");
            Console.WriteLine("This ore can help us dearly with our battle! " + name + (" we are counting on you!"));
            Console.ReadLine();
            Console.WriteLine("These will be your weapon options... choose one to carry with you :");


            Console.WriteLine("\ta - Sword");
            Console.WriteLine("\tb - musket");
            Console.WriteLine("\tc - 5 Grenades");
            Console.WriteLine("\td - Sniper Rifle");
            a = Console.ReadLine();


            if (a == "a")
            {
                Console.WriteLine("Sword.. a true warrior weapon Great choice! lets see if you can handle it");
                Console.ReadLine();
            }

            else if (a == "b")
            {
                Console.WriteLine("musket.. I hope you know how to use it");
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
