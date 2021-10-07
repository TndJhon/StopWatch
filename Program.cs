using System;
using System.Threading;

namespace StopWatch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            Console.Clear();
            WriteMenu();

            Console.SetCursorPosition(3, 1);
            Console.WriteLine("StopWatch");
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("===================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("S - Segundos => 10s");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("M - Minutos => 1m");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("===================");
            Console.SetCursorPosition(3, 8);
            Console.Write("Cronometrando: ");
            
            var data = Console.ReadLine();
            var type = char.Parse(data.Substring(data.Length - 1, 1));
            var time = int.Parse(data.Substring(0 , data.Length -1));
            var multiplier = 1;

            if(type == 'm')
                multiplier = 60;

            if(time == 0)
                Environment.Exit(0);

             PreStart(time * multiplier)  ;     

        }
        public static void PreStart(int time)
        {
            var currentTime = 0;
            
            Console.ForegroundColor = ConsoleColor.Green;
            
            while(currentTime != time)
            {
                currentTime++;
                Console.SetCursorPosition(3, 9);
                Console.WriteLine($"Tempo Corrido: {currentTime}");
                Console.SetCursorPosition(3, 15);
                Thread.Sleep(1000);
            }

        }
        public static void WriteMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write('|');
            for(int i = 0; i <= 30; i++)
                Console.Write('=');

            Console.WriteLine('|');
            for(int x = 0; x <= 10; x++)
            {
                Console.Write('|');
                for(int z =  0; z <= 30; z++)
                    Console.Write(' ');

                Console.WriteLine('|'); 
            }
            Console.Write('|');
            for(int a = 0; a <= 30; a++)
                Console.Write('=');

            Console.WriteLine('|');         

        }
    }
}