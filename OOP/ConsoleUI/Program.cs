using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            do
            {
                snake.Move(Console.ReadKey().Key);

            } while (Console.ReadKey().Key!=ConsoleKey.Escape);
    
        }

        //protected virtual void OnButtonDown()
        //{

        //}

    }
}
