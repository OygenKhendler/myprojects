using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Food
    {
        Random random = new Random();
        public Point foodPoint;
        int width;
        int height;

        public Food(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void GreatFood()
        {
            int x = random.Next(1,width-2);
            int y = random.Next(1, height-2);
            foodPoint = new Point(x, y);
            foodPoint.Draw();
        }
    }
}
