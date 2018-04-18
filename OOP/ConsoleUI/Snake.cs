using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Snake : Point
    {
        List<Point> snake = new List<Point>();
        int newX=1;
        int newY=0;

        public Snake(int xPos, int yPos, char symbol ) : base(xPos, yPos, symbol)
        {
            LoadSnake();
            Draw();

                      
        }

        public void LoadSnake()
        {
           for(int i=0; i<5;i++)
           {
                snake.Add(new Point(xPos,yPos,symbol));
                xPos++;
           }
        }

        public void Move(ConsoleKey key)
        {
            Point oldHead = snake.Last();
            Point tail = snake.First();

          
            switch (key)
            {
               
                case ConsoleKey.LeftArrow:
                    if (newX == 1) break;
                    newX = -1;
                    newY = 0;
                    break;
                case ConsoleKey.UpArrow:
                    if (newY == 1) break;
                    newY = -1;
                    newX = 0;
                    break;
                case ConsoleKey.RightArrow:
                    if (newY == -1) break;
                    newX = 1;
                    newY = 0;
                    break;
                case ConsoleKey.DownArrow:
                    if (newY == -1) break;
                    newY = 1;
                    newX = 0;
                    break;
                default:
                    break;
            }

            snake.Add(new Point(oldHead.xPos + newX, oldHead.yPos+ newY, symbol));
            DrawHead(snake.Last());
            snake.Remove(tail);
            RemoveTail(tail);
            Thread.Sleep(100);

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
