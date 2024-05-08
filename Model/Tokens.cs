using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorLexico.Model
{
    class Tokens
    {
        public String lexeme;
        public byte token;
        public String classToken;
        public String type;
        public int address;

        public Tokens(byte token, String lexeme, int address)
        {
            this.lexeme = lexeme;
            this.token = token;
            this.address = address;
        }
    }
}
