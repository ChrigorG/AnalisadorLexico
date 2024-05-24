# Analisador Léxico para Código Pascal

## Descrição do Projeto

Este projeto foi desenvolvido com o objetivo de aprender e praticar conceitos de análise léxica. Trata-se de um analisador léxico para código escrito na linguagem Pascal. O analisador identifica e classifica diferentes tokens presentes no código, como identificadores, literais, caracteres e valores desconhecidos, validando cadeias de caracteres utilizando expressões regulares (Regex).

## Funcionalidades

- **Identificação de Tokens:** O analisador separa o que é um token válido da tabela de tokens de Pascal.
- **Classificação de Elementos:** Diferencia números, identificadores, literais, caracteres e valores desconhecidos.
- **Validação com Regex:** Utiliza expressões regulares para validar e categorizar as cadeias de caracteres.
- **Exibição Dinâmica:** Exibe os dados classificados em uma tabela dinâmica ao final do processo.

## Tecnologias Utilizadas

- **Linguagem de Programação:** C#
- **Framework:** .NET Framework 4.8
- **Tipo de Aplicação:** Console Application

## Como Utilizar

1. **Clonar o Repositório:**
   ```bash
   git clone https://github.com/ChrigorG/AnalisadorLexico.git
  
2. **Navegue até a pasta do projeto clonado e abra o arquivo .sln no Visual Studio.**
  Executar o Projeto:

3. **Compile e execute o projeto a partir de uma IDE ou via executavel disponivel em: "...\AnalisadorLexico\bin\Release\AnalisadorLexico.exe"".**
  Vai ter um arquivo de exemplo na pasta raiz do projeto chamado "ParaTeste" só copiar o diretorio do .pas e colar no shell


O analisador irá processar o código e exibir uma tabela com a classificação de cada token.
Exemplo:
-----------------------------------------------------------------------------------------------------------------------------
|  ID  |  Token                            |  Lexema              |  Tipo               |  Descrição                         |
|------|-----------------------------------|----------------------|---------------------|------------------------------------|
|  000 |  program                          |  <program,>          |  Identificador      |  É um identificador                |
|  000 |  Exemplo                          |  <Exemplo,>          |  Identificador      |  É um identificador                |
|  000 |  SysUtils                         |  <SysUtils,>         |  Identificador      |  É um identificador                |
|  000 |  PI                               |  <PI,>               |  Identificador      |  É um identificador                |
|  000 |  3.14159                          |  <3.14159,>          |  Número             |  Valor númerico                    |
|  000 |  MAX                              |  <MAX,>              |  Identificador      |  É um identificador                |
|  000 |  100                              |  <100,>              |  Número             |  Valor númerico                    |
|  000 |  idade                            |  <idade,>            |  Identificador      |  É um identificador                |
|  000 |  altura                           |  <altura,>           |  Identificador      |  É um identificador                |
|  000 |  2CasasDecimais                   |  <2CasasDecimais,>   |  Desconhecido       |  Campo não permitido na linguagem  |
|  000 |  nome                             |  <nome,>             |  Identificador      |  É um identificador                |
|  000 |  _sobrenome                       |  <_sobrenome,>       |  Desconhecido       |  Campo não permitido na linguagem  |
|  000 |  x                                |  <x,>                |  Identificador      |  É um identificador                |
|  000 |  y                                |  <y,>                |  Identificador      |  É um identificador                |
|  000 |  MostrarMensagem                  |  <MostrarMensagem,>  |  Identificador      |  É um identificador                |
|  000 |  msg                              |  <msg,>              |  Identificador      |  É um identificador                |
|  000 |  Dobro                            |  <Dobro,>            |  Identificador      |  É um identificador                |
|  000 |  2                                |  <2,>                |  Número             |  Valor númerico                    |
|  009 |  BEGIN                            |  <BEGIN,>            |  Palavra reservada  |  begin                             |
|  017 |  CONST                            |  <CONST,>            |  Palavra reservada  |  const                             |
|  027 |  DOUBLE                           |  <DOUBLE,>           |  Palavra reservada  |  double                            |
|  030 |  END                              |  <END,>              |  Palavra reservada  |  end                               |
|  043 |  FUNCTION                         |  <FUNCTION,>         |  Palavra reservada  |  function                          |
|  052 |  INTEGER                          |  <INTEGER,>          |  Palavra reservada  |  integer                           |
|  075 |  PROPERTY                         |  <PROPERTY,>         |  Palavra reservada  |  property                          |
|  091 |  RESULT                           |  <RESULT,>           |  Palavra reservada  |  result                            |
|  104 |  STRING                           |  <STRING,>           |  Palavra reservada  |  string                            |
|  115 |  USES                             |  <USES,>             |  Palavra reservada  |  uses                              |
|  116 |  VAR                              |  <VAR,>              |  Palavra reservada  |  var                               |
|  124 |  WRITELN                          |  <WRITELN,>          |  Palavra reservada  |  writeln                           |
|  130 |  COMMA                            |  <,,>                |  Simbolo            |  comma                             |
|  131 |  SEMICOLON                        |  <;,>                |  Simbolo            |  semicolon                         |
|  132 |  COLON                            |  <:,>                |  Simbolo            |  colon                             |
|  134 |  ASSIGNMENT_OPERATOR              |  <:=,>               |  Simbolo            |  assignment_operator               |
|  138 |  LEFT_PARENTHESES                 |  <(,>                |  Simbolo            |  left_parentheses                  |
|  139 |  RIGHT_PARENTHESES                |  <),>                |  Simbolo            |  right_parentheses                 |
|  147 |  EQUAL_SIGN                       |  <=,>                |  Simbolo            |  equal_sign                        |
|  155 |  ASTERISK_OR_MULTIPLICATION_SIGN  |  <*,>                |  Simbolo            |  asterisk_or_multiplication_sign   |

