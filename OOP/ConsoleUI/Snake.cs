using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Snake : Point
    {
        public Snake(int xPos, int yPos, char symbol) : base(xPos, yPos, symbol)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.symbol = symbol;
        }

        public void LoadSnake()
        {
            List<int> xPosSnake = new List<int>();
            List<int> yPosSnake = new List<int>();

            for(int i=0; i<3;i++)
            {

            }
            
        }
    }
}
