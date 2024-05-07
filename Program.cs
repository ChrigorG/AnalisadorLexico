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

            }
        }
    }
}
