using System;
using System.IO;
using System.Threading;

namespace editor
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("\nBEM VINDO AO EDITOR TOPZEIRA\n");
            Console.WriteLine("1 - Abrir arquivo\n2 - Criar arquivo\n0 - Sair\n------------------");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir();break;
                case 2: Criar(); break;
                default: Menu(); break;
            }
        }

        static void Abrir()
        {
            Console.Clear();
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine("\nDigite nome do arquivo");
            Console.WriteLine("v----------------------\n");
            var nome = Console.ReadLine();
            Console.Clear();
            using(var file = new StreamReader($"{path}\\{nome}.txt"))
            {
                string texto = file.ReadToEnd();
                Console.WriteLine(texto);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }
        static void Criar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo  (ESC para sair)");
            Console.WriteLine("\n--------------------------------------");

            string texto = "";

            do
            {
                texto += Console.ReadLine();
                texto += Environment.NewLine;
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);
            
            Salvar(texto);
        }

        static void Salvar(string texto)
        {
            Console.Clear();
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine("DDigite um nome para o arquivo");
            Console.WriteLine("v----------------------------\n");
            var nome = Console.ReadLine();

            using (var file  =  new StreamWriter($"{path}\\{nome}.txt"))
            {
                file.Write(texto);
            }
            Console.Clear();
            Console.WriteLine("Salvando arquivo...");
            Thread.Sleep(1500);
            Console.Clear();

            Console.WriteLine("Arquivo salvo!");
            Thread.Sleep(1700);
            Console.Clear();
            Menu();
        }
    }
}