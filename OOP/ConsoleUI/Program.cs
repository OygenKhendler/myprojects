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


        static void Main(string[] args)
        {
            GameField gameField = new GameField(0, 0);
            gameField.Draw();

            Snake snake = new Snake(10, 10);
            while (true)
            {
                
                
               snake.Move();

               if (Console.KeyAvailable)
               {  
                    ConsoleKeyInfo consoleKey = Console.ReadKey();
                    snake.OnButtonKey(consoleKey.Key);
               }

               if (snake.Colusion())
               {
                    Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                    Console.Write("You lost.");
                    break;
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
