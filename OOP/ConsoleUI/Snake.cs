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

        public Direction _direction;

        

        public Snake(int xPos, int yPos ) : base(xPos, yPos)
        {
            
            LoadSnake();
            foreach (Point p in snake)
            {
                p.Draw();
            }     
        }

        public void LoadSnake()
        {
           for(int i=0; i<5;i++)
           {
                snake.Add(new Point(xPos,yPos));
                xPos++;
           }
        }

        public void Move()
        {
            Point head = snake.Last();
            Point tail = snake.First();
            Point newPoint = NewPoint(head);

            snake.Add(newPoint);
            snake.Remove(tail);
           
            newPoint.Draw();
            tail.Remove();
            
            
        }

        public void OnButtonKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    _direction = Direction.LEFT;
                    break;
                case ConsoleKey.UpArrow:
                    _direction = Direction.UP;
                    break;
                case ConsoleKey.RightArrow:
                    _direction = Direction.RIGHT;
                    break;
                case ConsoleKey.DownArrow:
                    _direction = Direction.DOWN;
                    break;

            }

                
        }
        private Point NewPoint(Point point)
        {
            Point tempPoint = new Point(point.xPos, point.yPos);
            tempPoint.NewPoint(1, _direction);
            Point newPoint = tempPoint;
            return newPoint;
        }

        public bool Colusion()
        {
            Point head = snake.Last();
            for (int i = 0; i < snake.Count-2; i++)
            {
                if(head.Colusion(snake[i]))return true;
            }
            return false;
        }
        


      

       
    }
}
