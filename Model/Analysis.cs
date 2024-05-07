using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorLexico.Model
{
    class Analysis : Base
    {
        public IList<BaseLexica> ListBaseLexica { get; set; }

        public Analysis(string content) 
        {
            this.content = content;
        }

        public void Execute()
        {

        }
    }

    class BaseLexica
    {
        public string token { get; set; }
        public string lexema { get; set; }
    }
}
