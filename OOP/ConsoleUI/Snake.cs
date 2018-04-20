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
        
        List<Point> points = new List<Point>();
        public Point snakeHead;
        public Direction _direction;

        

        public Snake(int xPos, int yPos ) : base(xPos, yPos)
        {
            
            LoadSnake();
            foreach (Point p in points)
            {
                p.Draw();
            }     
        }

        public void LoadSnake()
        {
           for(int i=0; i<5;i++)
           {
                points.Add(new Point(xPos,yPos));
                xPos++;
           }
            snakeHead = points.Last();
        }

        public void Move()
        {
            Point head = points.Last();
            Point tail = points.First();
            Point newPoint = NewPoint(head);

            points.Add(newPoint);
            points.Remove(tail);
           
            newPoint.Draw();
            snakeHead = newPoint;
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
            Point head = points.Last();
            for (int i = 0; i < points.Count-2; i++)
            {
                if(head.Colusion(points[i])) return true;
            }
            return false;
        }

        public bool Aet(Food food)
        {
            Point head = points.Last();
            if (head.Colusion(food.foodPoint))
            {
                points.Add(new Point(food.foodPoint));
                return true;
            }
            
            return false;
        }
       






    }
}
