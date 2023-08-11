using System;

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
            Console.WriteLine("1 - Abrir arquivo\n2 - Criar arquivo\n3 - Sair\n------------------");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Abrir();break;
                case 2: Editar(); break;
                case 3: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("");
        }
        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo  (ESC para sair)");
            Console.WriteLine("\n---------------------");

            string texto = "";

            do
            {
                texto += Console.ReadLine();
                texto += Environment.NewLine;
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape)
            
            Console.WriteLine(texto)
        }
    }
}