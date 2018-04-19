using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        //public delegate void OnButtonDownEvenHandler(object source, EventArgs args);

        //public event OnButtonDownEvenHandler ButtonDown;

        static void Main(string[] args)
        {
            GameField gameField = new GameField(0, 0, '+');
            gameField.Draw();

            Snake snake = new Snake(Console.WindowWidth / 2, Console.WindowHeight / 2, '#');
            while (true)
            {
                
               snake.Move();

               if (Console.KeyAvailable)
               {  
                    ConsoleKeyInfo consoleKey = Console.ReadKey();
                    snake.OnButtonKey(consoleKey.Key);
               }
               
                

                Thread.Sleep(100);
            }


            Console.ReadKey();

        }

        //protected virtual void OnButtonDown()
        //{

        //}

    }
}
