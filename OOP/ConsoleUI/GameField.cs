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
       

        public GameField(int xPos, int yPos) : base(xPos, yPos)
        {
            
            Console.SetWindowSize(80,40);
            
            LoadGameField();
            foreach(Point field in verticalFieldLine)
            {
                field.Draw();
            }
            foreach (Point field in horizontalFieldLine)
            {
                field.Draw();
            }
        }
        public void LoadGameField()
        {
            int maxHeight = Console.WindowHeight-1;
            int maxWidght = Console.WindowWidth-1;

            while (xPos != Console.WindowWidth && maxWidght != 0)
            {
                horizontalFieldLine.Add(new Point(xPos, yPos));
                xPos++;

                horizontalFieldLine.Add(new Point(maxWidght, maxHeight));
                maxWidght--;
            }
            while (yPos != Console.WindowHeight && maxHeight != 0)
            {
                verticalFieldLine.Add(new Point(xPos, yPos));
                yPos++;

                verticalFieldLine.Add(new Point(maxWidght, maxHeight));
                maxHeight--;

            }
        }
        public List<Point> GetVerticalPoints()
        {
            return verticalFieldLine;
        }
        public List<Point> GetHorizontalPoints()
        {
            return horizontalFieldLine;
        }

    }
}
