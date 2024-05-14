using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AnalisadorLexico.Model
{
    class Analysis : Base
    {
        public List<Tokens> ListTokens { get; set; } = new List<Tokens>();
        private TableTokens tableTokens { get; set; } = new TableTokens();

        public Analysis(string content)
        {
            this.content = content;
        }

        // Função principal que vai executar as analise dos Split executo na Classe MainRegex
        // Separando o que é cada elemento encontrado e analisando-as
        public void Execute()
        {
            List<string> listSplitString = MainRegex.ReturnListOfSplitString(this.content);

            foreach (var item in listSplitString)
            {
                var dictionary = tableTokens.table.FirstOrDefault(token => token.Key.ToLower() == item.ToLower());

                // Valida se o value é vázio e se o Value já não foi adicionado na lista para não se repetir
                if (dictionary.Value != null && !ListTokens.Any(value => value == dictionary.Value))
                {
                    ListTokens.Add(dictionary.Value);
                } else if (MainRegex.IsNumber(item) && !ListTokens.Any(value => value.token == item))
                {
                    ListTokens.Add(new Tokens()
                    {
                        token = item,
                        lexeme = $"<{item},>",
                        type = tableTokens.Number,
                        description = "Valor númerico"
                    });
                } else if (MainRegex.IsLiteral(item) && !ListTokens.Any(value => value.token == item))
                {
                    ListTokens.Add(new Tokens()
                    {
                        token = item,
                        lexeme = $"<{item},>",
                        type = tableTokens.Literal,
                        description = "É um string"
                    });
                } else if (MainRegex.IsCharacters(item) && !ListTokens.Any(value => value.token == item))
                {
                    var texto = item.Length <= 20 ? item : item.Substring(0, 20);
                    ListTokens.Add(new Tokens()
                    {
                        token = texto,
                        lexeme = $"<{texto},>",
                        type = tableTokens.Simbol,
                        description = "É um caracter especial do Pascal"
                    });
                }
                //} else
                //{
                //    ListTokens.Add(new Tokens()
                //    {
                //        token = item,
                //        lexeme = $"<{item},>",
                //        type = tableTokens.Undefined,
                //        description = "E caracter não pertence a linguagem"
                //    });
                //}
            }

        }
    }
}
