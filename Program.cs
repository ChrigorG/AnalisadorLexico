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
                Print(analysis.ListTokens);
            }
        }

        private static void Print(List<Tokens> ListTokens)
        {
            int maxLength = 7;
            if(ListTokens.Count == 0)
            {
                Console.WriteLine("\n\n*** Nenhuma informação encontrada ***");
                return;
            }

            int maxLengthLexeme = ListTokens.Max(item => item.lexeme.Length);

            string titleToken = "Token";
            string titleLexeme = "Lexema";
            string titleAddress = "Descrição";
            string token, lexeme, address = string.Empty;

            maxLengthLexeme = maxLengthLexeme > titleLexeme.Length ? maxLengthLexeme : titleLexeme.Length;

            Console.WriteLine("\n\n                          *** Iniciando ***\n                          ");
            Console.WriteLine("_________________________________________________________________________");

            Console.WriteLine($"|{ReturnSpace(maxLength)}{titleToken}{ReturnSpace(maxLength, titleToken.Length, titleToken.Length)}" +
                              $"|{ReturnSpace(maxLength)}{titleLexeme}{ReturnSpace(maxLength, titleLexeme.Length, maxLengthLexeme)}" +
                              $"|{ReturnSpace(maxLength)}{titleAddress}{ReturnSpace(maxLength, titleAddress.Length, titleAddress.Length)}|");
            
            Console.WriteLine("|___________________|____________________________|_______________________|");

            foreach (var item in ListTokens)
            {
                lexeme = item.lexeme;
                token = item.token.ToString("D3");
                address = item.address.ToString("D3");

                Console.WriteLine($"|{ReturnSpace(maxLength)}{token}{ReturnSpace(maxLength, token.Length, titleToken.Length)}" +
                                  $"|{ReturnSpace(maxLength)}{lexeme}{ReturnSpace(maxLength, lexeme.Length, maxLengthLexeme)}" +
                                  $"|{ReturnSpace(maxLength)}{address}{ReturnSpace(maxLength, address.Length, titleAddress.Length)}|");
            }

            Console.WriteLine("|___________________|____________________________|_______________________|");
            Console.WriteLine("\n");
            Console.WriteLine("                          *** Finalizando ***                          ");
        }

        private static string ReturnSpace(int spaceAdditional, int lengthText = 0, int maxLength = 0)
        {
            int calc = maxLength - lengthText;
            string space = string.Empty;

            for (int i = 0; i < (calc + spaceAdditional); i++)
                space += " ";
            
            return space;
        }
    }
}
