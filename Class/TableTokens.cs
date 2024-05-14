using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnalisadorLexico.Model
{
    class TableTokens
    {
        public Dictionary<string, Tokens> table = new Dictionary<string, Tokens>();

        public readonly int end = -1;
        public readonly string Identify = "Identificador";
        public readonly string KeyWord = "Palavra reservada";
        public readonly string Simbol = "Simbolo";
        public readonly string Literal = "Literal";
        public readonly string Number = "Número";
        public readonly string Undefined = "Desconhecido";

        public static byte ABSOLUTE;
        public static byte ABSTRACT;
        public static byte ANSICHAR;
        public static byte ANSISTRING;
        public static byte ARRAY;
        public static byte AS;
        public static byte ASM;
        public static byte ASSEMBLER;
        public static byte AUTOMATED;
        public static byte BEGIN;
        public static byte BOOLEAN;
        public static byte BREAK;
        public static byte BYTE;
        public static byte CASE;
        public static byte CDECL;
        public static byte CHAR;
        public static byte CLASS;
        public static byte CONST;
        public static byte CONSTRUCTOR;
        public static byte CONTINUE;
        public static byte CURRENCY;
        public static byte DEFAULT;
        public static byte DEPRECATED;
        public static byte DESTRUCTOR;
        public static byte DISPOSE;
        public static byte DIV;
        public static byte DO;
        public static byte DOUBLE;
        public static byte DOWNTO;
        public static byte ELSE;
        public static byte END;
        public static byte EXIT;
        public static byte EXPORT;
        public static byte EXTENDED;
        public static byte EXTERNAL;
        public static byte FALSE;
        public static byte FAR;
        public static byte FILE;
        public static byte FINALIZATION;
        public static byte FINALIZED;
        public static byte FINALLY;
        public static byte FOR;
        public static byte FORWARD;
        public static byte FUNCTION;
        public static byte GOTO;
        public static byte IF;
        public static byte IMPLEMENTATION;
        public static byte IN;
        public static byte INHERITED;
        public static byte INITIALIZATION;
        public static byte INLINE;
        public static byte INT64;
        public static byte INTEGER;
        public static byte INTERFACE;
        public static byte INTERRUPT;
        public static byte IS;
        public static byte LABEL;
        public static byte LIBRARY;
        public static byte LONGINT;
        public static byte LONGWORD;
        public static byte MESSAGE;
        public static byte MOD;
        public static byte NEAR;
        public static byte NEW;
        public static byte NIL;
        public static byte NODEFAULT;
        public static byte OBJECT;
        public static byte OF;
        public static byte OPERATOR;
        public static byte OVERLOAD;
        public static byte OVERRIDE;
        public static byte PACKED;
        public static byte PASCAL;
        public static byte PLATFORM;
        public static byte PRIVATE;
        public static byte PROCEDURE;
        public static byte PROGRAM;
        public static byte PROPERTY;
        public static byte PROTECTED;
        public static byte PUBLIC;
        public static byte PUBLISHED;
        public static byte RAISE;
        public static byte READ;
        public static byte READONLY;
        public static byte REAL;
        public static byte RECORD;
        public static byte REGISTER;
        public static byte REINTRODUCE;
        public static byte REPEAT;
        public static byte REQUIRES;
        public static byte RESIDENT;
        public static byte RESOURCESTRING;
        public static byte SAFECALL;
        public static byte SEALED;
        public static byte SELF;
        public static byte SET;
        public static byte SHL;
        public static byte SHORTINT;
        public static byte SHORTSTRING;
        public static byte SHR;
        public static byte SINGLE;
        public static byte SMALLINT;
        public static byte STDCALL;
        public static byte STRICT;
        public static byte STRING;
        public static byte THEN;
        public static byte THREADVAR;
        public static byte TO;
        public static byte TRUE;
        public static byte TRY;
        public static byte TYPE;
        public static byte UINT64;
        public static byte UNICODESTRING;
        public static byte UNIT;
        public static byte UNTIL;
        public static byte USES;
        public static byte VAR;
        public static byte VARARGS;
        public static byte VIRTUAL;
        public static byte WHILE;
        public static byte WIDECHAR;
        public static byte WIDESTRING;
        public static byte WITH;
        public static byte WORD;
        public static byte WRITE;
        public static byte XOR;

        public static byte AND;
        public static byte OR;
        public static byte NOT;

        public static byte DOT; // .
        public static byte COMMA; // ,
        public static byte SEMICOLON; // ;
        public static byte COLON; // :
        public static byte DOUBLECOLON; // ::
        public static byte ASSIGNMENT_OPERATOR; // :=
        public static byte DOUBLE_DOT; // ..
        public static byte SINGLE_QUOTE; // '
        public static byte DOUBLE_QUOTE; // "
        public static byte LEFT_PARENTHESES; // (
        public static byte RIGHT_PARENTHESES; // )
        public static byte LEFT_AND_RIGHT_PARENTHESES; // ()
        public static byte LEFT_BRACKETS; // [
        public static byte RIGHT_BRACKETS; // ]
        public static byte LEFT_AND_RIGHT_BRACKETS; // []
        public static byte LEFT_BRACES; // {
        public static byte RIGHT_BRACES; // }
        public static byte LEFT_AND_RIGHT_BRACES; // {}
        public static byte EQUAL_SIGN; // =
        public static byte GREATER_THAN_SIGN; // >
        public static byte LESS_THAN_SIGN; // <
        public static byte GREATER_THAN_OR_EQUAL_TO_SIGN; // >=
        public static byte LESS_THAN_OR_EQUAL_TO_SIGN; // <=
        public static byte NOT_EQUAL_TO_SIGN; // <>
        public static byte PLUS_SIGN; // +
        public static byte MINUS_SIGN; // -
        public static byte ASTERISK_OR_MULTIPLICATION_SIGN; // *
        public static byte FORWARD_SLASH_OR_DIVISION_SIGN; // /
        public static byte CARET_OR_EXPONENTIATION_SIGN; // ^
        public static byte PERCENT_SIGN; // %


        public TableTokens()
        {
            // Contrutor do Tokens solicita =>  string token, string lexeme, string type, string description, byte address

            table.Add(nameof(ABSOLUTE).ToLower(), new Tokens(nameof(ABSOLUTE), $"<{nameof(ABSOLUTE)},>", KeyWord, nameof(ABSOLUTE).ToLower(), ++end));
            table.Add(nameof(ABSTRACT).ToLower(), new Tokens(nameof(ABSTRACT), $"<{nameof(ABSTRACT)},>", KeyWord, nameof(ABSTRACT).ToLower(), ++end));
            
            table.Add(nameof(ANSICHAR).ToLower(), new Tokens(nameof(ANSICHAR), $"<{nameof(ANSICHAR)},>", KeyWord, nameof(ANSICHAR).ToLower(), ++end));
            table.Add(nameof(ANSISTRING).ToLower(), new Tokens(nameof(ANSISTRING), $"<{nameof(ANSISTRING)},>", KeyWord, nameof(ANSISTRING).ToLower(), ++end));
            table.Add(nameof(ARRAY).ToLower(), new Tokens(nameof(ARRAY), $"<{nameof(ARRAY)},>", KeyWord, nameof(ARRAY).ToLower(), ++end));
            table.Add(nameof(AS).ToLower(), new Tokens(nameof(AS), $"<{nameof(AS)},>", KeyWord, nameof(AS).ToLower(), ++end));
            table.Add(nameof(ASM).ToLower(), new Tokens(nameof(ASM), $"<{nameof(ASM)},>", KeyWord, nameof(ASM).ToLower(), ++end));
            table.Add(nameof(ASSEMBLER).ToLower(), new Tokens(nameof(ASSEMBLER), $"<{nameof(ASSEMBLER)},>", KeyWord, nameof(ASSEMBLER).ToLower(), ++end));
            table.Add(nameof(AUTOMATED).ToLower(), new Tokens(nameof(AUTOMATED), $"<{nameof(AUTOMATED)},>", KeyWord, nameof(AUTOMATED).ToLower(), ++end));
            table.Add(nameof(BEGIN).ToLower(), new Tokens(nameof(BEGIN), $"<{nameof(BEGIN)},>", KeyWord, nameof(BEGIN).ToLower(), ++end));
            table.Add(nameof(BOOLEAN).ToLower(), new Tokens(nameof(BOOLEAN), $"<{nameof(BOOLEAN)},>", KeyWord, nameof(BOOLEAN).ToLower(), ++end));
            table.Add(nameof(BREAK).ToLower(), new Tokens(nameof(BREAK), $"<{nameof(BREAK)},>", KeyWord, nameof(BREAK).ToLower(), ++end));
            table.Add(nameof(BYTE).ToLower(), new Tokens(nameof(BYTE), $"<{nameof(BYTE)},>", KeyWord, nameof(BYTE).ToLower(), ++end));
            table.Add(nameof(CASE).ToLower(), new Tokens(nameof(CASE), $"<{nameof(CASE)},>", KeyWord, nameof(CASE).ToLower(), ++end));
            table.Add(nameof(CDECL).ToLower(), new Tokens(nameof(CDECL), $"<{nameof(CDECL)},>", KeyWord, nameof(CDECL).ToLower(), ++end));
            table.Add(nameof(CHAR).ToLower(), new Tokens(nameof(CHAR), $"<{nameof(CHAR)},>", KeyWord, nameof(CHAR).ToLower(), ++end));
            table.Add(nameof(CLASS).ToLower(), new Tokens(nameof(CLASS), $"<{nameof(CLASS)},>", KeyWord, nameof(CLASS).ToLower(), ++end));
            table.Add(nameof(CONST).ToLower(), new Tokens(nameof(CONST), $"<{nameof(CONST)},>", KeyWord, nameof(CONST).ToLower(), ++end));
            table.Add(nameof(CONSTRUCTOR).ToLower(), new Tokens(nameof(CONSTRUCTOR), $"<{nameof(CONSTRUCTOR)},>", KeyWord, nameof(CONSTRUCTOR).ToLower(), ++end));
            table.Add(nameof(CONTINUE).ToLower(), new Tokens(nameof(CONTINUE), $"<{nameof(CONTINUE)},>", KeyWord, nameof(CONTINUE).ToLower(), ++end));
            table.Add(nameof(CURRENCY).ToLower(), new Tokens(nameof(CURRENCY), $"<{nameof(CURRENCY)},>", KeyWord, nameof(CURRENCY).ToLower(), ++end));
            table.Add(nameof(DEFAULT).ToLower(), new Tokens(nameof(DEFAULT), $"<{nameof(DEFAULT)},>", KeyWord, nameof(DEFAULT).ToLower(), ++end));
            table.Add(nameof(DEPRECATED).ToLower(), new Tokens(nameof(DEPRECATED), $"<{nameof(DEPRECATED)},>", KeyWord, nameof(DEPRECATED).ToLower(), ++end));
            table.Add(nameof(DESTRUCTOR).ToLower(), new Tokens(nameof(DESTRUCTOR), $"<{nameof(DESTRUCTOR)},>", KeyWord, nameof(DESTRUCTOR).ToLower(), ++end));
            table.Add(nameof(DISPOSE).ToLower(), new Tokens(nameof(DISPOSE), $"<{nameof(DISPOSE)},>", KeyWord, nameof(DISPOSE).ToLower(), ++end));
            table.Add(nameof(DIV).ToLower(), new Tokens(nameof(DIV), $"<{nameof(DIV)},>", KeyWord, nameof(DIV).ToLower(), ++end));
            table.Add(nameof(DO).ToLower(), new Tokens(nameof(DO), $"<{nameof(DO)},>", KeyWord, nameof(DO).ToLower(), ++end));
            table.Add(nameof(DOUBLE).ToLower(), new Tokens(nameof(DOUBLE), $"<{nameof(DOUBLE)},>", KeyWord, nameof(DOUBLE).ToLower(), ++end));
            table.Add(nameof(DOWNTO).ToLower(), new Tokens(nameof(DOWNTO), $"<{nameof(DOWNTO)},>", KeyWord, nameof(DOWNTO).ToLower(), ++end));
            table.Add(nameof(ELSE).ToLower(), new Tokens(nameof(ELSE), $"<{nameof(ELSE)},>", KeyWord, nameof(ELSE).ToLower(), ++end));
            table.Add(nameof(END).ToLower(), new Tokens(nameof(END), $"<{nameof(END)},>", KeyWord, nameof(END).ToLower(), ++end));
            table.Add(nameof(EXIT).ToLower(), new Tokens(nameof(EXIT), $"<{nameof(EXIT)},>", KeyWord, nameof(EXIT).ToLower(), ++end));
            table.Add(nameof(EXPORT).ToLower(), new Tokens(nameof(EXPORT), $"<{nameof(EXPORT)},>", KeyWord, nameof(EXPORT).ToLower(), ++end));
            table.Add(nameof(EXTENDED).ToLower(), new Tokens(nameof(EXTENDED), $"<{nameof(EXTENDED)},>", KeyWord, nameof(EXTENDED).ToLower(), ++end));
            table.Add(nameof(EXTERNAL).ToLower(), new Tokens(nameof(EXTERNAL), $"<{nameof(EXTERNAL)},>", KeyWord, nameof(EXTERNAL).ToLower(), ++end));
            table.Add(nameof(FALSE).ToLower(), new Tokens(nameof(FALSE), $"<{nameof(FALSE)},>", KeyWord, nameof(FALSE).ToLower(), ++end));
            table.Add(nameof(FAR).ToLower(), new Tokens(nameof(FAR), $"<{nameof(FAR)},>", KeyWord, nameof(FAR).ToLower(), ++end));
            table.Add(nameof(FILE).ToLower(), new Tokens(nameof(FILE), $"<{nameof(FILE)},>", KeyWord, nameof(FILE).ToLower(), ++end));
            table.Add(nameof(FINALIZATION).ToLower(), new Tokens(nameof(FINALIZATION), $"<{nameof(FINALIZATION)},>", KeyWord, nameof(FINALIZATION).ToLower(), ++end));
            table.Add(nameof(FINALIZED).ToLower(), new Tokens(nameof(FINALIZED), $"<{nameof(FINALIZED)},>", KeyWord, nameof(FINALIZED).ToLower(), ++end));
            table.Add(nameof(FINALLY).ToLower(), new Tokens(nameof(FINALLY), $"<{nameof(FINALLY)},>", KeyWord, nameof(FINALLY).ToLower(), ++end));
            table.Add(nameof(FOR).ToLower(), new Tokens(nameof(FOR), $"<{nameof(FOR)},>", KeyWord, nameof(FOR).ToLower(), ++end));
            table.Add(nameof(FORWARD).ToLower(), new Tokens(nameof(FORWARD), $"<{nameof(FORWARD)},>", KeyWord, nameof(FORWARD).ToLower(), ++end));
            table.Add(nameof(FUNCTION).ToLower(), new Tokens(nameof(FUNCTION), $"<{nameof(FUNCTION)},>", KeyWord, nameof(FUNCTION).ToLower(), ++end));
            table.Add(nameof(GOTO).ToLower(), new Tokens(nameof(GOTO), $"<{nameof(GOTO)},>", KeyWord, nameof(GOTO).ToLower(), ++end));
            table.Add(nameof(IF).ToLower(), new Tokens(nameof(IF), $"<{nameof(IF)},>", KeyWord, nameof(IF).ToLower(), ++end));
            table.Add(nameof(IMPLEMENTATION).ToLower(), new Tokens(nameof(IMPLEMENTATION), $"<{nameof(IMPLEMENTATION)},>", KeyWord, nameof(IMPLEMENTATION).ToLower(), ++end));
            table.Add(nameof(IN).ToLower(), new Tokens(nameof(IN), $"<{nameof(IN)},>", KeyWord, nameof(IN).ToLower(), ++end));
            table.Add(nameof(INHERITED).ToLower(), new Tokens(nameof(INHERITED), $"<{nameof(INHERITED)},>", KeyWord, nameof(INHERITED).ToLower(), ++end));
            table.Add(nameof(INITIALIZATION).ToLower(), new Tokens(nameof(INITIALIZATION), $"<{nameof(INITIALIZATION)},>", KeyWord, nameof(INITIALIZATION).ToLower(), ++end));
            table.Add(nameof(INLINE).ToLower(), new Tokens(nameof(INLINE), $"<{nameof(INLINE)},>", KeyWord, nameof(INLINE).ToLower(), ++end));
            table.Add(nameof(INT64).ToLower(), new Tokens(nameof(INT64), $"<{nameof(INT64)},>", KeyWord, nameof(INT64).ToLower(), ++end));
            table.Add(nameof(INTEGER).ToLower(), new Tokens(nameof(INTEGER), $"<{nameof(INTEGER)},>", KeyWord, nameof(INTEGER).ToLower(), ++end));
            table.Add(nameof(INTERFACE).ToLower(), new Tokens(nameof(INTERFACE), $"<{nameof(INTERFACE)},>", KeyWord, nameof(INTERFACE).ToLower(), ++end));
            table.Add(nameof(INTERRUPT).ToLower(), new Tokens(nameof(INTERRUPT), $"<{nameof(INTERRUPT)},>", KeyWord, nameof(INTERRUPT).ToLower(), ++end));
            table.Add(nameof(IS).ToLower(), new Tokens(nameof(IS), $"<{nameof(IS)},>", KeyWord, nameof(IS).ToLower(), ++end));
            table.Add(nameof(LABEL).ToLower(), new Tokens(nameof(LABEL), $"<{nameof(LABEL)},>", KeyWord, nameof(LABEL).ToLower(), ++end));
            table.Add(nameof(LIBRARY).ToLower(), new Tokens(nameof(LIBRARY), $"<{nameof(LIBRARY)},>", KeyWord, nameof(LIBRARY).ToLower(), ++end));
            table.Add(nameof(LONGINT).ToLower(), new Tokens(nameof(LONGINT), $"<{nameof(LONGINT)},>", KeyWord, nameof(LONGINT).ToLower(), ++end));
            table.Add(nameof(LONGWORD).ToLower(), new Tokens(nameof(LONGWORD), $"<{nameof(LONGWORD)},>", KeyWord, nameof(LONGWORD).ToLower(), ++end));
            table.Add(nameof(MESSAGE).ToLower(), new Tokens(nameof(MESSAGE), $"<{nameof(MESSAGE)},>", KeyWord, nameof(MESSAGE).ToLower(), ++end));
            table.Add(nameof(MOD).ToLower(), new Tokens(nameof(MOD), $"<{nameof(MOD)},>", KeyWord, nameof(MOD).ToLower(), ++end));
            table.Add(nameof(NEAR).ToLower(), new Tokens(nameof(NEAR), $"<{nameof(NEAR)},>", KeyWord, nameof(NEAR).ToLower(), ++end));
            table.Add(nameof(NEW).ToLower(), new Tokens(nameof(NEW), $"<{nameof(NEW)},>", KeyWord, nameof(NEW).ToLower(), ++end));
            table.Add(nameof(NIL).ToLower(), new Tokens(nameof(NIL), $"<{nameof(NIL)},>", KeyWord, nameof(NIL).ToLower(), ++end));
            table.Add(nameof(NODEFAULT).ToLower(), new Tokens(nameof(NODEFAULT), $"<{nameof(NODEFAULT)},>", KeyWord, nameof(NODEFAULT).ToLower(), ++end));
            table.Add(nameof(OBJECT).ToLower(), new Tokens(nameof(OBJECT), $"<{nameof(OBJECT)},>", KeyWord, nameof(OBJECT).ToLower(), ++end));
            table.Add(nameof(OF).ToLower(), new Tokens(nameof(OF), $"<{nameof(OF)},>", KeyWord, nameof(OF).ToLower(), ++end));
            table.Add(nameof(OPERATOR).ToLower(), new Tokens(nameof(OPERATOR), $"<{nameof(OPERATOR)},>", KeyWord, nameof(OPERATOR).ToLower(), ++end));
            table.Add(nameof(OVERLOAD).ToLower(), new Tokens(nameof(OVERLOAD), $"<{nameof(OVERLOAD)},>", KeyWord, nameof(OVERLOAD).ToLower(), ++end));
            table.Add(nameof(OVERRIDE).ToLower(), new Tokens(nameof(OVERRIDE), $"<{nameof(OVERRIDE)},>", KeyWord, nameof(OVERRIDE).ToLower(), ++end));
            table.Add(nameof(PACKED).ToLower(), new Tokens(nameof(PACKED), $"<{nameof(PACKED)},>", KeyWord, nameof(PACKED).ToLower(), ++end));
            table.Add(nameof(PASCAL).ToLower(), new Tokens(nameof(PASCAL), $"<{nameof(PASCAL)},>", KeyWord, nameof(PASCAL).ToLower(), ++end));
            table.Add(nameof(PLATFORM).ToLower(), new Tokens(nameof(PLATFORM), $"<{nameof(PLATFORM)},>", KeyWord, nameof(PLATFORM).ToLower(), ++end));
            table.Add(nameof(PRIVATE).ToLower(), new Tokens(nameof(PRIVATE), $"<{nameof(PRIVATE)},>", KeyWord, nameof(PRIVATE).ToLower(), ++end));
            table.Add(nameof(PROCEDURE).ToLower(), new Tokens(nameof(PROPERTY), $"<{nameof(PROPERTY)},>", KeyWord, nameof(PROPERTY).ToLower(), ++end));
            table.Add(nameof(PROTECTED).ToLower(), new Tokens(nameof(PROTECTED), $"<{nameof(PROTECTED)},>", KeyWord, nameof(PROTECTED).ToLower(), ++end));
            table.Add(nameof(PUBLIC).ToLower(), new Tokens(nameof(PUBLIC), $"<{nameof(PUBLIC)},>", KeyWord, nameof(PUBLIC).ToLower(), ++end));
            table.Add(nameof(PUBLISHED).ToLower(), new Tokens(nameof(PUBLISHED), $"<{nameof(PUBLISHED)},>", KeyWord, nameof(PUBLISHED).ToLower(), ++end));
            table.Add(nameof(RAISE).ToLower(), new Tokens(nameof(RAISE), $"<{nameof(RAISE)},>", KeyWord, nameof(RAISE).ToLower(), ++end));
            table.Add(nameof(READ).ToLower(), new Tokens(nameof(READ), $"<{nameof(READ)},>", KeyWord, nameof(READ).ToLower(), ++end));
            table.Add(nameof(READONLY).ToLower(), new Tokens(nameof(READONLY), $"<{nameof(READONLY)},>", KeyWord, nameof(READONLY).ToLower(), ++end));
            table.Add(nameof(REAL).ToLower(), new Tokens(nameof(REAL), $"<{nameof(REAL)},>", KeyWord, nameof(REAL).ToLower(), ++end));
            table.Add(nameof(RECORD).ToLower(), new Tokens(nameof(RECORD), $"<{nameof(RECORD)},>", KeyWord, nameof(RECORD).ToLower(), ++end));
            table.Add(nameof(REGISTER).ToLower(), new Tokens(nameof(REGISTER), $"<{nameof(REGISTER)},>", KeyWord, nameof(REGISTER).ToLower(), ++end));
            table.Add(nameof(REINTRODUCE).ToLower(), new Tokens(nameof(REINTRODUCE), $"<{nameof(REINTRODUCE)},>", KeyWord, nameof(REINTRODUCE).ToLower(), ++end));
            table.Add(nameof(REPEAT).ToLower(), new Tokens(nameof(REPEAT), $"<{nameof(REPEAT)},>", KeyWord, nameof(REPEAT).ToLower(), ++end));
            table.Add(nameof(REQUIRES).ToLower(), new Tokens(nameof(REQUIRES), $"<{nameof(REQUIRES)},>", KeyWord, nameof(REQUIRES).ToLower(), ++end));
            table.Add(nameof(RESIDENT).ToLower(), new Tokens(nameof(RESIDENT), $"<{nameof(RESIDENT)},>", KeyWord, nameof(RESIDENT).ToLower(), ++end));
            table.Add(nameof(RESOURCESTRING).ToLower(), new Tokens(nameof(RESOURCESTRING), $"<{nameof(RESOURCESTRING)},>", KeyWord, nameof(RESOURCESTRING).ToLower(), ++end));
            table.Add(nameof(SAFECALL).ToLower(), new Tokens(nameof(SAFECALL), $"<{nameof(SAFECALL)},>", KeyWord, nameof(SAFECALL).ToLower(), ++end));
            table.Add(nameof(SEALED).ToLower(), new Tokens(nameof(SEALED), $"<{nameof(SEALED)},>", KeyWord, nameof(SEALED).ToLower(), ++end));
            table.Add(nameof(SELF).ToLower(), new Tokens(nameof(SELF), $"<{nameof(SELF)},>", KeyWord, nameof(SELF).ToLower(), ++end));
            table.Add(nameof(SET).ToLower(), new Tokens(nameof(SET), $"<{nameof(SET)},>", KeyWord, nameof(SET).ToLower(), ++end));
            table.Add(nameof(SHL).ToLower(), new Tokens(nameof(SHL), $"<{nameof(SHL)},>", KeyWord, nameof(SHL).ToLower(), ++end));
            table.Add(nameof(SHORTINT).ToLower(), new Tokens(nameof(SHORTINT), $"<{nameof(SHORTINT)},>", KeyWord, nameof(SHORTINT).ToLower(), ++end));
            table.Add(nameof(SHORTSTRING).ToLower(), new Tokens(nameof(SHORTSTRING), $"<{nameof(SHORTSTRING)},>", KeyWord, nameof(SHORTSTRING).ToLower(), ++end));
            table.Add(nameof(SHR).ToLower(), new Tokens(nameof(SHR), $"<{nameof(SHR)},>", KeyWord, nameof(SHR).ToLower(), ++end));
            table.Add(nameof(SINGLE).ToLower(), new Tokens(nameof(SINGLE), $"<{nameof(SINGLE)},>", KeyWord, nameof(SINGLE).ToLower(), ++end));
            table.Add(nameof(SMALLINT).ToLower(), new Tokens(nameof(SMALLINT), $"<{nameof(SMALLINT)},>", KeyWord, nameof(SMALLINT).ToLower(), ++end));
            table.Add(nameof(STDCALL).ToLower(), new Tokens(nameof(STDCALL), $"<{nameof(STDCALL)},>", KeyWord, nameof(STDCALL).ToLower(), ++end));
            table.Add(nameof(STRICT).ToLower(), new Tokens(nameof(STRICT), $"<{nameof(STRICT)},>", KeyWord, nameof(STRICT).ToLower(), ++end));
            table.Add(nameof(STRING).ToLower(), new Tokens(nameof(STRING), $"<{nameof(STRING)},>", KeyWord, nameof(STRING).ToLower(), ++end));
            table.Add(nameof(THEN).ToLower(), new Tokens(nameof(THEN), $"<{nameof(THEN)},>", KeyWord, nameof(THEN).ToLower(), ++end));
            table.Add(nameof(THREADVAR).ToLower(), new Tokens(nameof(THREADVAR), $"<{nameof(THREADVAR)},>", KeyWord, nameof(THREADVAR).ToLower(), ++end));
            table.Add(nameof(TO).ToLower(), new Tokens(nameof(TO), $"<{nameof(TO)},>", KeyWord, nameof(TO).ToLower(), ++end));
            table.Add(nameof(TRUE).ToLower(), new Tokens(nameof(TRUE), $"<{nameof(TRUE)},>", KeyWord, nameof(TRUE).ToLower(), ++end));
            table.Add(nameof(TRY).ToLower(), new Tokens(nameof(TRY), $"<{nameof(TRY)},>", KeyWord, nameof(TRY).ToLower(), ++end));
            table.Add(nameof(TYPE).ToLower(), new Tokens(nameof(TYPE), $"<{nameof(TYPE)},>", KeyWord, nameof(TYPE).ToLower(), ++end));
            table.Add(nameof(UINT64).ToLower(), new Tokens(nameof(UINT64), $"<{nameof(UINT64)},>", KeyWord, nameof(UINT64).ToLower(), ++end));
            table.Add(nameof(UNICODESTRING).ToLower(), new Tokens(nameof(UNICODESTRING), $"<{nameof(UNICODESTRING)},>", KeyWord, nameof(UNICODESTRING).ToLower(), ++end));
            table.Add(nameof(UNIT).ToLower(), new Tokens(nameof(UNIT), $"<{nameof(UNIT)},>", KeyWord, nameof(UNIT).ToLower(), ++end));
            table.Add(nameof(UNTIL).ToLower(), new Tokens(nameof(UNTIL), $"<{nameof(UNTIL)},>", KeyWord, nameof(UNTIL).ToLower(), ++end));
            table.Add(nameof(USES).ToLower(), new Tokens(nameof(USES), $"<{nameof(USES)},>", KeyWord, nameof(USES).ToLower(), ++end));
            table.Add(nameof(VAR).ToLower(), new Tokens(nameof(VAR), $"<{nameof(VAR)},>", KeyWord, nameof(VAR).ToLower(), ++end));
            table.Add(nameof(VARARGS).ToLower(), new Tokens(nameof(VARARGS), $"<{nameof(VARARGS)},>", KeyWord, nameof(VARARGS).ToLower(), ++end));
            table.Add(nameof(VIRTUAL).ToLower(), new Tokens(nameof(VIRTUAL), $"<{nameof(VIRTUAL)},>", KeyWord, nameof(VIRTUAL).ToLower(), ++end));
            table.Add(nameof(WHILE).ToLower(), new Tokens(nameof(WHILE), $"<{nameof(WHILE)},>", KeyWord, nameof(WHILE).ToLower(), ++end));
            table.Add(nameof(WIDECHAR).ToLower(), new Tokens(nameof(WIDECHAR), $"<{nameof(WIDECHAR)},>", KeyWord, nameof(WIDECHAR).ToLower(), ++end));
            table.Add(nameof(WIDESTRING).ToLower(), new Tokens(nameof(WIDESTRING), $"<{nameof(WIDESTRING)},>", KeyWord, nameof(WIDESTRING).ToLower(), ++end));
            table.Add(nameof(WITH).ToLower(), new Tokens(nameof(WITH), $"<{nameof(WITH)},>", KeyWord, nameof(WITH).ToLower(), ++end));
            table.Add(nameof(WRITE).ToLower(), new Tokens(nameof(WRITE), $"<{nameof(WRITE)},>", KeyWord, nameof(WRITE).ToLower(), ++end));
            table.Add(nameof(XOR).ToLower(), new Tokens(nameof(XOR), $"<{nameof(XOR)},>", KeyWord, nameof(XOR).ToLower(), ++end));

            // Lista dos operadores Logicos
            table.Add(nameof(OR).ToLower(), new Tokens(nameof(OR), $"<{nameof(OR)},>", KeyWord, nameof(OR).ToLower(), ++end));
            table.Add(nameof(AND).ToLower(), new Tokens(nameof(AND), $"<{nameof(AND)},>", KeyWord, nameof(AND).ToLower(), ++end));
            table.Add(nameof(NOT).ToLower(), new Tokens(nameof(NOT), $"<{nameof(NOT)},>", KeyWord, nameof(NOT).ToLower(), ++end));

            // Lista
            table.Add(".", new Tokens(nameof(DOT), "<.,>", Simbol, nameof(DOT).ToLower(), ++end));
            table.Add(",", new Tokens(nameof(COMMA), "<,,>", Simbol, nameof(COMMA).ToLower(), ++end));
            table.Add(";", new Tokens(nameof(SEMICOLON), "<;,>", Simbol, nameof(SEMICOLON).ToLower(), ++end));
            table.Add(":", new Tokens(nameof(COLON), "<:,>", Simbol, nameof(COLON).ToLower(), ++end));
            table.Add("::", new Tokens(nameof(DOUBLECOLON), "<::,>", Simbol, nameof(DOUBLECOLON).ToLower(), ++end));
            table.Add(":=", new Tokens(nameof(ASSIGNMENT_OPERATOR), "<:=,>", Simbol, nameof(ASSIGNMENT_OPERATOR).ToLower(), ++end));
            table.Add("..", new Tokens(nameof(DOUBLE_DOT), "<..,>", Simbol, nameof(DOUBLE_DOT).ToLower(), ++end));
            table.Add("'", new Tokens(nameof(SINGLE_QUOTE), "<',>", Simbol, nameof(SINGLE_QUOTE).ToLower(), ++end));
            table.Add("\"", new Tokens(nameof(DOUBLE_QUOTE), "<\",>", Simbol, nameof(DOUBLE_QUOTE).ToLower(), ++end));
            table.Add("(", new Tokens(nameof(LEFT_PARENTHESES), "<(,>", Simbol, nameof(LEFT_PARENTHESES).ToLower(), ++end));
            table.Add(")", new Tokens(nameof(RIGHT_PARENTHESES), "<),>", Simbol, nameof(RIGHT_PARENTHESES).ToLower(), ++end));
            table.Add("()", new Tokens(nameof(LEFT_AND_RIGHT_PARENTHESES), "<(),>", Simbol, nameof(LEFT_AND_RIGHT_PARENTHESES).ToLower(), ++end));
            table.Add("[", new Tokens(nameof(LEFT_BRACKETS), "<[,>", Simbol, nameof(LEFT_BRACKETS).ToLower(), ++end));
            table.Add("]", new Tokens(nameof(RIGHT_BRACKETS), "<],>", Simbol, nameof(RIGHT_BRACKETS).ToLower(), ++end));
            table.Add("[]", new Tokens(nameof(LEFT_AND_RIGHT_BRACKETS), "<[],>", Simbol, nameof(LEFT_AND_RIGHT_BRACKETS).ToLower(), ++end));
            table.Add("{", new Tokens(nameof(LEFT_BRACES), "<{,>", Simbol, nameof(LEFT_BRACES).ToLower(), ++end));
            table.Add("}", new Tokens(nameof(RIGHT_BRACES), "<},>", Simbol, nameof(RIGHT_BRACES).ToLower(), ++end));
            table.Add("{}", new Tokens(nameof(LEFT_AND_RIGHT_BRACES), "<{},>", Simbol, nameof(LEFT_AND_RIGHT_BRACES).ToLower(), ++end));
            table.Add("=", new Tokens(nameof(EQUAL_SIGN), $"<=,>", Simbol, nameof(EQUAL_SIGN).ToLower(), ++end));
            table.Add(">", new Tokens(nameof(GREATER_THAN_SIGN), $"<>,>", Simbol, nameof(GREATER_THAN_SIGN).ToLower(), ++end));
            table.Add("<", new Tokens(nameof(LESS_THAN_SIGN), $"<<,>", Simbol, nameof(LESS_THAN_SIGN).ToLower(), ++end));
            table.Add(">=", new Tokens(nameof(GREATER_THAN_OR_EQUAL_TO_SIGN), $"<>=,>", Simbol, nameof(GREATER_THAN_OR_EQUAL_TO_SIGN).ToLower(), ++end));
            table.Add("<=", new Tokens(nameof(LESS_THAN_OR_EQUAL_TO_SIGN), $"<<=,>", Simbol, nameof(LESS_THAN_OR_EQUAL_TO_SIGN).ToLower(), ++end));
            table.Add("<>", new Tokens(nameof(NOT_EQUAL_TO_SIGN), $"<<>,>", Simbol, nameof(NOT_EQUAL_TO_SIGN).ToLower(), ++end));
            table.Add("+", new Tokens(nameof(PLUS_SIGN), $"<+,>", Simbol, nameof(PLUS_SIGN).ToLower(), ++end));
            table.Add("-", new Tokens(nameof(MINUS_SIGN), $"<-,>", Simbol, nameof(MINUS_SIGN).ToLower(), ++end));
            table.Add("*", new Tokens(nameof(ASTERISK_OR_MULTIPLICATION_SIGN), $"<*,>", Simbol, nameof(ASTERISK_OR_MULTIPLICATION_SIGN).ToLower(), ++end));
            table.Add("/", new Tokens(nameof(FORWARD_SLASH_OR_DIVISION_SIGN), $"</,>", Simbol, nameof(FORWARD_SLASH_OR_DIVISION_SIGN).ToLower(), ++end));
            table.Add("^", new Tokens(nameof(CARET_OR_EXPONENTIATION_SIGN), $"<^,>", Simbol, nameof(CARET_OR_EXPONENTIATION_SIGN).ToLower(), ++end));
            table.Add("%", new Tokens(nameof(PERCENT_SIGN), $"<%,>", Simbol, nameof(PERCENT_SIGN).ToLower(), ++end));
        }
    }
}
