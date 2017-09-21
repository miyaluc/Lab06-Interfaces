using System;
using System.Collections.Generic;
using System.Text;

namespace lab06_miya
{
    interface IAdult
    {
        string Name
        {
            get; set;
        }
        void EatHealthyFood();
        bool CleanBrushes();
        void Sleep();
    }
}
