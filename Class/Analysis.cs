using System;
using System.Collections.Generic;
using System.Linq;

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

        public void Execute()
        {
            List<string> listSplitString = MainRegex.ReturnListOfSplitString(this.content);

            foreach (var item in listSplitString)
            {
                var dictionary = tableTokens.table.FirstOrDefault(token => token.Key.ToLower() == item.ToLower());

                if (dictionary.Value != null && !ListTokens.Any(value => value == dictionary.Value))
                {
                    ListTokens.Add(dictionary.Value);
                }
            }

        }
    }
}
