using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Snake : Point
    {
        List<Point> snake = new List<Point>();

        public Snake(int xPos, int yPos, char symbol) : base(xPos, yPos, symbol)
        {
            LoadSnake();
            Draw();

            while (true)
            {
                Move();
            }
                      
        }

        public void LoadSnake()
        {
           for(int i=0; i<5;i++)
           {
                snake.Add(new Point(xPos,yPos,symbol));
                xPos++;
           }
        }

        public void Move()
        {
            Point oldHead = snake.Last();
            Point tail = snake.First();

            snake.Add(new Point(oldHead.xPos + 1, oldHead.yPos, symbol));
            DrawHead(snake.Last());
            snake.Remove(tail);
            RemoveTail(tail);

        }

        private void DrawHead(Point head)
        {
            Console.SetCursorPosition(head.xPos, head.yPos);
            Console.Write(symbol);
        }

        private void RemoveTail(Point tail)
        {
            Console.SetCursorPosition(tail.xPos, tail.yPos);
            Console.Write(' ');
        }

        public override void Draw()
        {
            foreach (Point p in snake)
            {
                Console.SetCursorPosition(p.xPos, p.yPos);
                Console.Write(p.symbol);
            }
           
        }
    }
}
