using ClassLibrary;
using System;
using System.Dynamic;
using System.Threading.Channels;


namespace SpaceGameTest
{

    public class Program
    {
        static void Main(string[] args)
        {


            StoryLine Story = new StoryLine();

            MainCharacter Cadet = new MainCharacter();
            {
                Cadet.Name = "Cadet";
                Cadet.Health = 100;
                Cadet.Loot = 0;
                Cadet.Experience = 0;
                Cadet.Products = Products.Food;
            }
            Story.Start();
            Console.Read();
            Story.ChapterOnePartOne();
            Console.Read();
            Story.FirstMissionBrief();

            Console.WriteLine("Before you go, pick a weapon.\n");
            Console.WriteLine("These will be your weapon options, choose one to carry with you :\n");
            for (Weapons w = Weapons.Musket; w <= Weapons.Dukes; w++)
            {
                Console.WriteLine($"Option {(int)w} is {w}");
                //string value = w.ToString();
                //Console.WriteLine(value);
            }

            int selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    Cadet.Weapons = Weapons.Musket;
                    Console.WriteLine($"\n\tNice choice! A {Cadet.Weapons}");
                    break;
                case 2:
                    Cadet.Weapons = Weapons.Sword;
                    Console.WriteLine($"\n\tNice choice! A {Cadet.Weapons}");
                    break;
                case 3:
                    Cadet.Weapons = Weapons.Blunderbuss;
                    Console.WriteLine($"\n\tNice choice! A {Cadet.Weapons}");
                    break;
                case 4:
                    Cadet.Weapons = Weapons.Dukes;
                    Console.WriteLine($"\n\tNice choice! Your {Cadet.Weapons}");
                    break;
            }
            Console.Clear();
            Console.Write(Cadet);

            







        }
    }
}

//Alien.Health = ShotHit(TheMerchant, Alien);
//{

//{

//string a = null;
//Console.WriteLine("Your first mission with Space Force is to go to planet Mars and retrieve an ore which is said to have magic powers,\n");
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


