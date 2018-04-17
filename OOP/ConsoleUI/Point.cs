using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Point
    {
        public int xPos;
        public int yPos;
        public char symbol;

        public Point(int xPos, int yPos, char symbol)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.symbol = symbol;
        }

        public virtual void Draw()
        {     
        }
    }
}
