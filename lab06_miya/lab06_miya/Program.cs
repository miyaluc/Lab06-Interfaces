using System;

namespace lab06_miya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If you've never gone to a paint while drinking wine event, you've got to try it.");

            Painting monaLisa = new Painting();
            monaLisa.CleanBrushes();
            monaLisa.DrinkCoffee();
            monaLisa.KeepCalm();

            Adults oldEnough = new Adults();
            oldEnough.HaveKids();
            oldEnough.EatHealthyFood();
            oldEnough.Sleep();

            Kids playAllDay = new Kids();
            playAllDay.EatHealthyFood();
            //playAllDay.Age = 16; 
            playAllDay.FaveFood();


            Console.Read();
        }
    }
}
