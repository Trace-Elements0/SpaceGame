using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SpaceGameTest
{
    class StoryLine
    {
        public void Prologue()
        {
            Console.WriteLine("In the galaxy called Milky Way, there has been a war going since before I was born.The Space Force started the war,\n" +
                "spreading order and peace However, a Rebellion was formed to counter Space Force.\n" +
                "For years, lives have been lost and put to misery.. All thanks to the Rebellion\n" +
                "that is why I want to join the Space Force, to help establish peace.Right now,\n" +
                "I am on my way to Space Force Headquarters to start my training as a recruit\n" +
                "This is where my journey begins…….. Press enter to continue");
            Console.WriteLine("Enter you Gender : ");
            Console.WriteLine("\t - male");
            Console.WriteLine("\t - female");
        }
        public void ChapterOne()
        {
            Console.WriteLine("The Merchant arrives at the Space HQ to start their training as a recruit. \n" +
                "The user enters the training hall, with other recruits with the goals as the user. \n" +
                " The Captain enters the training hall, he looks over his recruits and gives a brief on the Joining the Space Force. \n" +
                " The user gets his first mission, it is to go on Mars and retrieve an ore, it is said to have magical powers which would be beneficial to the Space Force. ");
        }
        public void ChapterTwo()
        {
            //TODO
        }
        public void ChapterThree()
        {
            //TODO
        }
        public void FinalChapter()
        {
            //TODO
        }

    }
}
