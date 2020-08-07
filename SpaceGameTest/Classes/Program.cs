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
                Cadet.Product = Characters.ProductTypes.Food;
                Cadet.CharacterType = Characters.CharacterTypes.Hero;
            }
            Story.Start();
            Actions.Pause();
            Story.ChapterOnePartOne();
            Actions.Pause();
            Story.FirstMissionBrief();
            Actions.Pause();

            Console.WriteLine("Before you go, pick a weapon.\n");
            Console.WriteLine("These will be your weapon options, choose one to carry with you :\n");
            for (Characters.WeaponTypes w = Characters.WeaponTypes.Musket; w <= Characters.WeaponTypes.Dukes; w++)
            {
                Console.WriteLine($"Option {(int)w} is {w}");
            }

            //Need input validation to make sure user only selects options 1-4//
            int selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    Cadet.Weapon = Characters.WeaponTypes.Musket;
                    Console.WriteLine($"\n\tNice choice! A {Cadet.Weapon}");
                    break;
                case 2:
                    Cadet.Weapon = Characters.WeaponTypes.Sword;
                    Console.WriteLine($"\n\tNice choice! A {Cadet.Weapon}");
                    break;
                case 3:
                    Cadet.Weapon = Characters.WeaponTypes.Blunderbuss;
                    Console.WriteLine($"\n\tNice choice! A {Cadet.Weapon}");
                    break;
                case 4:
                    Cadet.Weapon = Characters.WeaponTypes.Dukes;
                    Console.WriteLine($"\n\tNice choice! Your {Cadet.Weapon}");
                    break;
            }
            Actions a = new Actions();
            a.Fight(Cadet, saturnAlien);
        }
    }
}

