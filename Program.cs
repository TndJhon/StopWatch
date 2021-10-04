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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("S = Segundos => 10s");
            Console.WriteLine("M = Minutos = > 10m");
            Console.WriteLine("Para sair aperte 0");
            Console.WriteLine("===================");

            var dados = Console.ReadLine().ToUpper();
            var tipo = Convert.ToChar(dados.Substring(dados.Length -1, 1));
            var time = Convert.ToInt16(dados.Substring(0, dados.Length -1));
            var multiplicador = 1;
            
            if(tipo == 'm')
                multiplicador = 60;
        
            if(time == 0)
                Environment.Exit(0);

            PreStarter(time * multiplicador);


        }
        public static void PreStarter(int time)
        {
            var currentTime = 0;
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }

    }
}