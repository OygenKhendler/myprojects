using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class GameField : Point
    {
        public GameField(int xPos, int yPos, char symbol) : base(xPos, yPos, symbol)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.symbol = symbol;
            Console.SetWindowSize(100,50);
        }

        public override void Draw()
        {
            int maxHeight = Console.WindowHeight-1;
            int maxWidght = Console.WindowWidth-1;
            
            while (yPos != Console.WindowHeight&& maxHeight != 0)
            {
                Console.SetCursorPosition(xPos, yPos);
                Console.Write(symbol);
                yPos++;

                Console.SetCursorPosition(maxWidght,maxHeight);
                Console.Write(symbol);
                maxHeight--;
            }

            while (xPos != Console.WindowWidth && maxWidght != 0)
            {
                Console.SetCursorPosition(xPos, yPos);
                Console.Write(symbol);
                xPos++;

                Console.SetCursorPosition(maxWidght, maxHeight);
                Console.Write(symbol);
                maxWidght--;
            }
        }
    }
}
