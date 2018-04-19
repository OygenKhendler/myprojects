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
        public bool colusion = false;

        public Point(int xPos, int yPos, char symbol)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.symbol = symbol;
        }

        public virtual void Draw()
        {
            Console.SetCursorPosition(xPos, yPos);
            Console.Write(symbol);
        }

        public void Remove()
        {
            Console.SetCursorPosition(xPos, yPos);
            Console.Write(' ');
        }

        public void NewPoint(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.UP:
                    yPos -= offset;
                    break;
                case Direction.RIGHT:
                    xPos += offset;
                    break;
                case Direction.DOWN:
                    yPos += offset;
                    break;
                case Direction.LEFT:
                    xPos -= offset;
                    break;   
            }
        }
        public bool Colusion(Point p ,List<Point> points)
        {
            foreach (Point point in points)
            {
                if (p.xPos == point.xPos && p.yPos == point.yPos)
                {
                    colusion = true;
                }
                if (colusion) break;
            }
            return colusion;
        }

    }
}
