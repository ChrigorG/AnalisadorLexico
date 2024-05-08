using AnalisadorLexico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorLexico
{
    class Program
    {
        static void Main(string[] args)
        {
            Init();
            Console.ReadKey();
        }

        private static void Init()
        {
            File file = new File();
            Console.WriteLine("Informe o diretório do arquivo:");
            file.directoryFile = Console.ReadLine();
            file.ReadFile();

            if (!string.IsNullOrEmpty(file.content))
            {
                Analysis analysis = new Analysis(file.content);
                analysis.Execute();
                print(analysis.ListTokens);
            }
        }

        private static void print(List<Tokens> ListTokens)
        {
            Console.WriteLine("__________________________________________________________________");
            Console.WriteLine("|       Token       |       Lexema       |       Descrição       |");
            Console.WriteLine("|___________________|____________________|_______________________|");
            foreach (var item in ListTokens)
            {
                Console.WriteLine($"|       {item.token}       |       {item.lexeme}       |       {item.address}       |");
            }
            Console.WriteLine("|___________________|____________________|_______________________|");
            Console.WriteLine("\n");
            Console.WriteLine("                      *** Finalizado ***                          ");
        }
    }
}
