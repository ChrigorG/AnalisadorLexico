using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

                // Valida se o dictionary é vázio e se o Value já não foi adicionado na lista para não se repetir
                if (dictionary.Value != null && !ListTokens.Any(value => value == dictionary.Value))
                {
                    ListTokens.Add(dictionary.Value);
                } else if (dictionary.Value == null && !ListTokens.Any(value => value.token == item)){
                    if (MainRegex.IsNumber(item))
                    {
                        addListTokenNumber(item);
                    } else if (MainRegex.IsLiteral(item))
                    {
                        addListTokenLiteral(item);
                    } else if (MainRegex.IsCharacters(item))
                    {
                        addListTokenCharacter(item);
                    }else if (MainRegex.IsIdentifier(item))
                    { 
                        addListTokenIdentifier(item);
                    } else
                        addListValueUndefined(item);
                }
            }

        }

        private void addListTokenNumber(string item)
        {
            ListTokens.Add(new Tokens()
            {
                token = item,
                lexeme = $"<{item},>",
                type = tableTokens.Number,
                description = "Valor númerico"
            });
        }

        private void addListTokenLiteral(string item)
        {
            item = item.Length > 10 ? $"{item.Substring(0, 10)}[...]" : item;
            ListTokens.Add(new Tokens()
            {
                token = item,
                lexeme = $"<{item},>",
                type = tableTokens.Literal,
                description = "É um Literal"
            });
        }

        private void addListTokenCharacter(string item)
        {
            ListTokens.Add(new Tokens()
            {
                token = item,
                lexeme = $"<{item},>",
                type = tableTokens.Simbol,
                description = "É um caracter especial"
            });
        }

        private void addListTokenIdentifier(string item)
        {
            ListTokens.Add(new Tokens()
            {
                token = item,
                lexeme = $"<{item},>",
                type = tableTokens.Identifier,
                description = "É um identificador"
            });
        }

        private void addListValueUndefined(string item)
        {
            ListTokens.Add(new Tokens()
            {
                token = item,
                lexeme = $"<{item},>",
                type = tableTokens.Undefined,
                description = "Campo não permitido na linguagem"
            });
        }
    }
}
