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
            do
            {
                Console.Clear();
       
            GameField gameField = new GameField(0,0);
            gameField.Draw();

            Snake snake = new Snake(10, 10);
            Food food = new Food(81, 41);
            int speed = 200;
            int score = 0;

            food.GreatFood();
            while (true)
            {
                if (snake.Colusion()||gameField.Colusion(snake))
                {
                    Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                    Console.WriteLine("You lost.Your score: {0}", score);
                    Console.SetCursorPosition(Console.WindowWidth / 2, (Console.WindowHeight / 2)+1);
                    Console.WriteLine("Press Space to Restart.");
                        break;
                }
                if (snake.Aet(food))
                {
                    food.GreatFood();
                    if (speed > 40)
                    {
                        speed -= 20;
                        score++;
                    }
                    if (score==100)
                    {
                        Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                        Console.WriteLine("You won. Your score: {0}", score);
                        break;
                    }

                }
                else
                {
                    snake.Move();

                }
                Thread.Sleep(speed);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo consoleKey = Console.ReadKey();
                    snake.OnButtonKey(consoleKey.Key);
                }

            }
            } 
            while (Console.ReadKey().Key==ConsoleKey.Spacebar);
            
            

        }

    } 
}
