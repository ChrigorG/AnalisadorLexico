using AnalisadorLexico.Class;
using AnalisadorLexico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            Console.WriteLine(Mensage.informDirectoryFile);
            file.directoryFile = Console.ReadLine();
            file.ReadFile();

            if (string.IsNullOrEmpty(file.content))
            {
                // Se o conteúdo estiver vázio, imprima uma mensagem de arquivo vázio
                Console.WriteLine($"\n\n{Mensage.noneContentFile}");
                // Saindo da função, retornando nada ao chamador pois a função é "Void". Isso não exigi do else abaixo (Estética)
                return;
            }

            // Caso o arquivo não esteja vázio (Vázio é diferente de espaços em brancos), faça a analise...
            Analysis analysis = new Analysis(file.content);
            PrintTable printTable = new PrintTable();
            analysis.Execute();
            printTable.Print(analysis.ListTokens);
        }
    }
}
