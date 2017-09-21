using System;
using System.Collections.Generic;
using System.Text;

namespace lab06_miya
{
    class Kids : IPaint, IAdult
    {
        public string Name
        {
            get; set;
        }
        public string FavoriteHobby
        {
            get; set;
        }
        public void FaveFood()
        {
            Console.WriteLine("Mom said she'd make macaroni and cheese for me again tonight!");
        }
        public bool IsMessy()
        {
            return true;
        }

        public void EatHealthyFood()
        {
            Console.WriteLine("Green stuff in my food is gross!");
        }

        public bool CleanBrushes()
        {
            Console.WriteLine("My parents clean for me.");
            return false;
        }

        public void Sleep()
        {
            Console.WriteLine("My bedtime is 8PM.");
        }

        public bool DrinkCoffee()
        {
            return false;
        }

        public void KeepCalm()
        {
            string FavoriteHobby = "climbing trees";
            Console.WriteLine($"I like {FavoriteHobby} so much. I'm really good too. I don't get scared.");
        }

        public int Age
        {
            get
            {
                return Age;
            }
            set
            {
                if (Age >= 13)
                {
                    Console.WriteLine("You're good to go. Paint your heart out!");
                }
                else
                {
                    Console.WriteLine("Wait until you're 13. Leave painting to the grownups.");
                }
            }
        }
    }
}
