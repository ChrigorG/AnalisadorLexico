using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorLexico.Model
{
    class Tokens
    {
        private String lexeme;
        private byte token;
        private String classToken;
        private String type;
        private int address;

        public Tokens(byte token, String lexeme, int address)
        {
            this.lexeme = lexeme;
            this.token = token;
            this.address = address;
        }
    }
}
