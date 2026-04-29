using System;



namespace Тренировочные_проекты
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 101);
            int guess = 0;
            int attempts = 1;

            Console.WriteLine("Игра:угадайте загаданное число!");
            


            while (guess != random)
            {
                Console.WriteLine("Введите ваше число!");
                guess = int.Parse(Console.ReadLine());
                attempts++;


                if (guess > random)
                {
                    Console.WriteLine("Меньше!Попробуйте еще!");
                }
                if (guess < random)
                {
                    Console.WriteLine("Больше!Попробуйте еще!");

                }

                else if (guess == random)
                {
                    Console.WriteLine("Ура!Вы угадали число за " + attempts + " попыток!");
                }
                
            }
            Console.ReadLine();














        }
    }
}
