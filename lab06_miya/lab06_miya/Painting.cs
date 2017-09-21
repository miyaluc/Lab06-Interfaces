using System;
using System.Collections.Generic;
using System.Text;

namespace lab06_miya
{
    class Painting : IndoorActivities, IPaint
    {
        public int NumberOfActivities
        {
            get; set;
        }
        public int Name
        {
            get; set;
        }

        public bool CleanBrushes()
        {
            Console.WriteLine("Most people learn to clean up after themselves in preschool.");
            return true;
        }

        public bool DrinkCoffee()
        {
            Console.WriteLine("Not everyone drinks coffee. I think painters prefer tea.");
            return false;
        }

        public void KeepCalm()
        {
            string Name = "Miya";
            Console.WriteLine($"{Name} stays calm even when his/her painting has been ruined.");
        }

        public void Paint(IPaint painter)
        {
            painter.CleanBrushes();
            Console.WriteLine($"We have {NumberOfActivities} painting instructors today. Pick which class you'd like to join.");
        }
    }
}
