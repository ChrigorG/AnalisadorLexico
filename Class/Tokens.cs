using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorLexico.Model
{
    class Tokens
    {
        public string lexeme;
        public string  token;
        public string classToken;  
        public string type;
        public string description;
        public int address;

        public Tokens()
        {
        }

        public Tokens(string token, string lexeme, string type, string description, int address)
        {
            this.address = address;
            this.token = token;
            this.lexeme = lexeme;
            this.type = type;
            this.description = description;
        }
    }
}
