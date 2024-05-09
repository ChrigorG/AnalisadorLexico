using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorLexico.Model
{
    class File : Base
    {
        public string directoryFile { get; set; }

        public void ReadFile()
        {
            try
            {
                using (StreamReader reader = new StreamReader(directoryFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        content += line;
                    }
                }
            }catch(FileNotFoundException)
            {
                Console.WriteLine("Arquivo não encontrado.");
            }catch(Exception ex) 
            {
                Console.WriteLine($"Erro ao tentar ler arquivo, verifique: ${ex.Message}");
            }
        }
    }
}
