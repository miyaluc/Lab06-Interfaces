using System;
using System.Collections.Generic;
using System.Text;

namespace lab06_miya
{
    class Adults : IPaint
    {
        public string Name
        {
            get; set;
        }
        public bool HaveKids()
        {
            Console.WriteLine("Adults have kids IT's what they DO.");
            return true;
        }
        public void DrinkCoffee()
        {
            Console.WriteLine("One to two cups a day!");
        }
        public void Sleep()
        {
            Console.WriteLine("I get 8-10 hours a day.");
        }
        public bool CleanBrushes()
        {
            Console.WriteLine("Of course I clean up after myself. I'm bomb at adulting.");
            return true;
        }
        public void KeepCalm()
        {
            Console.WriteLine("Always stay calm under pressure.");
        }
        public void EatHealthyFood()
        {
            Console.WriteLine("Kale! Blueberries! Gluten-free bread!");
        }

        bool IPaint.DrinkCoffee()
        {
            return true;
            //throw new NotImplementedException();
        }
    }
}
