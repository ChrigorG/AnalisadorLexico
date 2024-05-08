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
            List<String> listSplitString = MainRegex.ReturnListOfSplitString(this.content);

            foreach (var item in listSplitString)
            {
                var dictionary = tableTokens.table.Where(token => token.Key.ToLower().Equals(item.ToLower())).FirstOrDefault();
                if(dictionary.Value != null)
                    ListTokens.Add(dictionary.Value);
            }
        }
    }
}
