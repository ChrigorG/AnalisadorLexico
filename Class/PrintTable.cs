using AnalisadorLexico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorLexico.Class
{
    class PrintTable
    {
        private int maxLength { get; } = 2;
        private int maxLengthLexeme { get; set; }
        private int maxLengthType { get; set; }
        private int maxLengthToken { get; set; }
        private int maxLengthDescription { get; set; }
        private int maxLengthTrace { get; set; }
        private int maxLengthTraceAddress { get; set; } 
        private int maxLengthTraceToken { get; set; }
        private int maxLengthTraceLexeme { get; set; }
        private int maxLengthTraceType { get; set; }
        private int maxLengthTraceDescription { get; set; }
        private string titleAddress { get; } = "ID";
        private string titleToken { get; } = "Token";
        private string titleLexeme { get; } = "Lexema";
        private string titleType { get; } = "Tipo";
        private string titleDescription { get; } = "Descrição";

        public void Print(List<Tokens> ListTokens)
        {
            if (ListTokens == null || ListTokens.Count == 0)
            {
                Console.WriteLine("\n\n*** Nenhuma informação encontrada. Finalizando programa ***");
                return;
            }

            // Captura o tamanho maximo de cada texto para fica indentado a tabela
            this.maxLengthToken = ListTokens.Max(item => item.token.Length);
            this.maxLengthType = ListTokens.Max(item => item.type.Length);
            this.maxLengthLexeme = ListTokens.Max(item => item.lexeme.Length);
            this.maxLengthDescription = ListTokens.Max(item => item.description.Length);

            // Caso algum texto do Lexema for maior que o titulo, se não, captura o tamanho do titulo do lexema 
            this.maxLengthLexeme = this.maxLengthLexeme > this.titleLexeme.Length ? this.maxLengthLexeme : this.titleLexeme.Length;

            // Aqui faço o calculo referente a quantidade maxima de traços da tabela / Por Titulo
            this.maxLengthTraceAddress = this.maxLength + this.titleAddress.Length + this.maxLength;
            this.maxLengthTraceToken = this.maxLength + this.titleToken.Length + (this.maxLength + (this.maxLengthToken - this.titleToken.Length));
            this.maxLengthTraceLexeme = this.maxLength + this.titleLexeme.Length + (this.maxLength + (this.maxLengthLexeme - this.titleLexeme.Length));
            this.maxLengthTraceType = this.maxLength + this.titleType.Length + (this.maxLength + (this.maxLengthType - this.titleType.Length));
            this.maxLengthTraceDescription = this.maxLength + this.titleDescription.Length + (this.maxLength + (this.maxLengthDescription - this.titleDescription.Length));

            this.maxLengthTrace = this.maxLengthTraceAddress + this.maxLengthTraceToken + this.maxLengthTraceLexeme +
                                  this.maxLengthTraceType + this.maxLengthTraceDescription;

            IEnumerable<Tokens> lista = ListTokens.OrderBy(item => item.address);
            // Imprime o Cabeçalho da tabela
            PrintHeaderTable();
            // Imprime o conteúdo da lista
            PrintContentTable(lista);
            // Imprime o fim da tabela
            PrintBottomTable();
        }

        private void PrintHeaderTable()
        {
            // Inicia o print da tabela com as colunas ( ID, Token, Lexema, Tipo, Descrição ) nessa ordem
            Console.WriteLine("\n\n                                                                *** Iniciando ***\n");
            Console.WriteLine($"{Helper.ReturnTrace(this.maxLengthTrace + 5)}");

            // Para cada linha abaixo é uma coluna da tabela separadas por um pipe
            Console.WriteLine($"|{Helper.ReturnSpace(maxLength)}{this.titleAddress}{Helper.ReturnSpace(this.maxLength, this.titleAddress.Length, this.titleAddress.Length)}" +
                              $"|{Helper.ReturnSpace(maxLength)}{this.titleToken}{Helper.ReturnSpace(this.maxLength, this.titleToken.Length, this.maxLengthToken)}" +
                              $"|{Helper.ReturnSpace(maxLength)}{this.titleLexeme}{Helper.ReturnSpace(this.maxLength, this.titleLexeme.Length, this.maxLengthLexeme)}" +
                              $"|{Helper.ReturnSpace(maxLength)}{this.titleType}{Helper.ReturnSpace(this.maxLength, this.titleType.Length, this.maxLengthType)}" +
                              $"|{Helper.ReturnSpace(maxLength)}{this.titleDescription}{Helper.ReturnSpace(this.maxLength, this.titleDescription.Length, this.maxLengthDescription)}|");

            // Separador do Titulo do Conteudo
            Console.WriteLine($"|{Helper.ReturnTrace(this.maxLengthTraceAddress)}|{Helper.ReturnTrace(this.maxLengthTraceToken)}" +
                              $"|{Helper.ReturnTrace(this.maxLengthTraceLexeme)}|{Helper.ReturnTrace(this.maxLengthTraceType)}" +
                              $"|{Helper.ReturnTrace(this.maxLengthTraceDescription)}|");
        }

        private void PrintContentTable(IEnumerable<Tokens> ListTokens)
        {
            string token, lexeme, address, type, description;

            // Imprimi os itens da lista referente aos dados encontrados no arquivo .Pas.
            // Para cada titulo um item sendo apresentado de acordo com as colunas ( ID, Token, Lexema, Tipo, Descrição )
            foreach (var item in ListTokens)
            {
                address = item.address.ToString("D3");
                lexeme = item.lexeme;
                token = item.token;
                type = item.type;
                description = item.description;
                Console.WriteLine($"|{Helper.ReturnSpace(this.maxLength)}{address}{Helper.ReturnSpace(this.maxLength, address.Length, this.titleAddress.Length)}" +
                                  $"|{Helper.ReturnSpace(this.maxLength)}{token}{Helper.ReturnSpace(this.maxLength, token.Length, this.maxLengthToken)}" +
                                  $"|{Helper.ReturnSpace(this.maxLength)}{lexeme}{Helper.ReturnSpace(this.maxLength, lexeme.Length, this.maxLengthLexeme)}" +
                                  $"|{Helper.ReturnSpace(this.maxLength)}{type}{Helper.ReturnSpace(this.maxLength, type.Length, this.maxLengthType)}" +
                                  $"|{Helper.ReturnSpace(this.maxLength)}{description}{Helper.ReturnSpace(this.maxLength, description.Length, this.maxLengthDescription)}|");
            }
        }

        private void PrintBottomTable()
        {
            // Separador do Conteudo da parte final
            Console.WriteLine($"|{Helper.ReturnTrace(this.maxLengthTraceAddress)}|{Helper.ReturnTrace(this.maxLengthTraceToken)}" +
                              $"|{Helper.ReturnTrace(this.maxLengthTraceLexeme)}|{Helper.ReturnTrace(this.maxLengthTraceType)}" +
                              $"|{Helper.ReturnTrace(this.maxLengthTraceDescription)}|");
            Console.WriteLine("\n");
            Console.WriteLine("                                                                *** Finalizando ***");
            Console.WriteLine("\r\n\n\"O sucesso é a soma de pequenos esforços repetidos dia após dia.\"");
            Console.WriteLine("\n                                                                (Robert Collier)");
        }
    }
}
