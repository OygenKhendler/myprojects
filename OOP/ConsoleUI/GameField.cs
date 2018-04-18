using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class GameField : Point
    {
        List<Point> verticalFieldLine = new List<Point>();
        List<Point> horizontalFieldLine = new List<Point>();
       

        public GameField(int xPos, int yPos, char symbol) : base(xPos, yPos, symbol)
        {
            Console.SetWindowSize(100,50);
            int maxHeight = Console.WindowHeight - 1;
            int maxWidght = Console.WindowWidth - 1;
            LoadGameField();
        }
        public void LoadGameField()
        {
            int maxHeight = Console.WindowHeight - 1;
            int maxWidght = Console.WindowWidth - 1;

            while (xPos != Console.WindowWidth && maxWidght != 0)
            {
                horizontalFieldLine.Add(new Point(xPos, yPos, symbol));
                xPos++;

                horizontalFieldLine.Add(new Point(maxWidght, maxHeight, symbol));
                maxWidght--;
            }
            while (yPos != Console.WindowHeight && maxHeight != 0)
            {
                verticalFieldLine.Add(new Point(xPos, yPos, symbol));
                yPos++;

                verticalFieldLine.Add(new Point(maxWidght, maxHeight, symbol));
                maxHeight--;

            }
        }

        public override void Draw()
        {

            foreach (Point field in verticalFieldLine)
            {
                Console.SetCursorPosition(field.xPos, field.yPos);
                Console.Write(symbol);
            }
            foreach (Point field in horizontalFieldLine)
            {
                Console.SetCursorPosition(field.xPos, field.yPos);
                Console.Write(symbol);
            }

            //while (yPos != Console.WindowHeight&& maxHeight != 0)
            //{
            //    Console.SetCursorPosition(xPos, yPos);
            //    Console.Write(symbol);
            //    yPos++;

            //    Console.SetCursorPosition(maxWidght,maxHeight);
            //    Console.Write(symbol);
            //    maxHeight--;
            //}

            //while (xPos != Console.WindowWidth && maxWidght != 0)
            //{
            //    Console.SetCursorPosition(xPos, yPos);
            //    Console.Write(symbol);
            //    xPos++;

            //    Console.SetCursorPosition(maxWidght, maxHeight);
            //    Console.Write(symbol);
            //    maxWidght--;
            //}
        }
    }
}
