// ***********************************************************************
// <copyright file="DotLexer.cs" company="Mobilize">
//     Copyright �  2017
// </copyright>
// <summary></summary
// ***********************************************************************
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Mobilize.Grammar.Language
{
    using System;
    using System.IO;

    using Antlr4.Runtime;
    using Antlr4.Runtime.Atn;
    using Antlr4.Runtime.Dfa;
    using Antlr4.Runtime.Misc;

    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
    [CLSCompliant(false)]
    public class DotLexer : Lexer
    {
        public const int STRICT = 1;

        public const int GRAPH = 2;

        public const int DIGRAPH = 3;

        public const int NODE = 4;

        public const int EDGE = 5;

        public const int SUBGRAPH = 6;

        public const int LPAREN = 7;

        public const int RPAREN = 8;

        public const int LBRACE = 9;

        public const int RBRACE = 10;

        public const int LBRACK = 11;

        public const int RBRACK = 12;

        public const int SEMI = 13;

        public const int COMMA = 14;

        public const int DOT = 15;

        public const int COLON = 16;

        public const int ASSIGN = 17;

        public const int ARROW = 18;

        public const int OPTION = 19;

        public const int NUMBER = 20;

        public const int STRING = 21;

        public const int ID = 22;

        public const int HTML_STRING = 23;

        public const int COMMENT = 24;

        public const int LINE_COMMENT = 25;

        public const int PREPROC = 26;

        public const int WS = 27;

        private static readonly char[] _serializedATN =
            {
                '\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', '\x5964', '\x2', '\x1D',
                '\xF4', '\b', '\x1', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4',
                '\x4', '\x5', '\t', '\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b',
                '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', '\t', '\v', '\x4', '\f', '\t', '\f',
                '\x4', '\r', '\t', '\r', '\x4', '\xE', '\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t',
                '\x10', '\x4', '\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', '\x13', '\x4',
                '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', '\x16', '\t', '\x16', '\x4', '\x17', '\t',
                '\x17', '\x4', '\x18', '\t', '\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4',
                '\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', '\x1D', '\x4', '\x1E', '\t',
                '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3',
                '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3',
                '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3',
                '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6',
                '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3',
                '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3',
                '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3',
                '\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\x10', '\x3', '\x10',
                '\x3', '\x11', '\x3', '\x11', '\x3', '\x12', '\x3', '\x12', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13',
                '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x15', '\x5', '\x15', '\x85', '\n', '\x15', '\x3',
                '\x15', '\x3', '\x15', '\x6', '\x15', '\x89', '\n', '\x15', '\r', '\x15', '\xE', '\x15', '\x8A', '\x3',
                '\x15', '\x6', '\x15', '\x8E', '\n', '\x15', '\r', '\x15', '\xE', '\x15', '\x8F', '\x3', '\x15', '\x3',
                '\x15', '\a', '\x15', '\x94', '\n', '\x15', '\f', '\x15', '\xE', '\x15', '\x97', '\v', '\x15', '\x5',
                '\x15', '\x99', '\n', '\x15', '\x5', '\x15', '\x9B', '\n', '\x15', '\x3', '\x16', '\x3', '\x16', '\x3',
                '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\a', '\x17', '\xA3', '\n', '\x17', '\f', '\x17',
                '\xE', '\x17', '\xA6', '\v', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x18', '\x3', '\x18', '\x3',
                '\x18', '\a', '\x18', '\xAD', '\n', '\x18', '\f', '\x18', '\xE', '\x18', '\xB0', '\v', '\x18', '\x3',
                '\x19', '\x3', '\x19', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\a', '\x1A', '\xB7', '\n', '\x1A',
                '\f', '\x1A', '\xE', '\x1A', '\xBA', '\v', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1B', '\x3',
                '\x1B', '\a', '\x1B', '\xC0', '\n', '\x1B', '\f', '\x1B', '\xE', '\x1B', '\xC3', '\v', '\x1B', '\x3',
                '\x1B', '\x3', '\x1B', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\a', '\x1C', '\xCB',
                '\n', '\x1C', '\f', '\x1C', '\xE', '\x1C', '\xCE', '\v', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3',
                '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\a',
                '\x1D', '\xD9', '\n', '\x1D', '\f', '\x1D', '\xE', '\x1D', '\xDC', '\v', '\x1D', '\x3', '\x1D', '\x5',
                '\x1D', '\xDF', '\n', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1E',
                '\x3', '\x1E', '\a', '\x1E', '\xE7', '\n', '\x1E', '\f', '\x1E', '\xE', '\x1E', '\xEA', '\v', '\x1E',
                '\x3', '\x1E', '\x3', '\x1E', '\x3', '\x1F', '\x6', '\x1F', '\xEF', '\n', '\x1F', '\r', '\x1F', '\xE',
                '\x1F', '\xF0', '\x3', '\x1F', '\x3', '\x1F', '\x6', '\xA4', '\xC1', '\xCC', '\xDA', '\x2', ' ', '\x3',
                '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', '\t', '\x11', '\n',
                '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11',
                '!', '\x12', '#', '\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x2', '-', '\x17', '/', '\x18',
                '\x31', '\x2', '\x33', '\x19', '\x35', '\x2', '\x37', '\x1A', '\x39', '\x1B', ';', '\x1C', '=', '\x1D',
                '\x3', '\x2', '\x16', '\x4', '\x2', 'U', 'U', 'u', 'u', '\x4', '\x2', 'V', 'V', 'v', 'v', '\x4', '\x2',
                'T', 'T', 't', 't', '\x4', '\x2', 'K', 'K', 'k', 'k', '\x4', '\x2', '\x45', '\x45', '\x65', '\x65',
                '\x4', '\x2', 'I', 'I', 'i', 'i', '\x4', '\x2', '\x43', '\x43', '\x63', '\x63', '\x4', '\x2', 'R', 'R',
                'r', 'r', '\x4', '\x2', 'J', 'J', 'j', 'j', '\x4', '\x2', '\x46', '\x46', '\x66', '\x66', '\x4', '\x2',
                'P', 'P', 'p', 'p', '\x4', '\x2', 'Q', 'Q', 'q', 'q', '\x4', '\x2', 'G', 'G', 'g', 'g', '\x4', '\x2',
                'W', 'W', 'w', 'w', '\x4', '\x2', '\x44', '\x44', '\x64', '\x64', '\x3', '\x2', '\x32', ';', '\x6',
                '\x2', '\x43', '\\', '\x61', '\x61', '\x63', '|', '\x82', '\x101', '\x4', '\x2', '>', '>', '@', '@',
                '\x4', '\x2', '\f', '\f', '\xF', '\xF', '\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', '\x2',
                '\x102', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2',
                '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2',
                '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', '\x2',
                '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3',
                '\x2', '\x2', '\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2',
                '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x2',
                '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2',
                '\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', '\x2', '\x2', '\x2',
                ')', '\x3', '\x2', '\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', '/', '\x3', '\x2',
                '\x2', '\x2', '\x2', '\x33', '\x3', '\x2', '\x2', '\x2', '\x2', '\x37', '\x3', '\x2', '\x2', '\x2',
                '\x2', '\x39', '\x3', '\x2', '\x2', '\x2', '\x2', ';', '\x3', '\x2', '\x2', '\x2', '\x2', '=', '\x3',
                '\x2', '\x2', '\x2', '\x3', '?', '\x3', '\x2', '\x2', '\x2', '\x5', '\x46', '\x3', '\x2', '\x2', '\x2',
                '\a', 'L', '\x3', '\x2', '\x2', '\x2', '\t', 'T', '\x3', '\x2', '\x2', '\x2', '\v', 'Y', '\x3', '\x2',
                '\x2', '\x2', '\r', '^', '\x3', '\x2', '\x2', '\x2', '\xF', 'g', '\x3', '\x2', '\x2', '\x2', '\x11',
                'i', '\x3', '\x2', '\x2', '\x2', '\x13', 'k', '\x3', '\x2', '\x2', '\x2', '\x15', 'm', '\x3', '\x2',
                '\x2', '\x2', '\x17', 'o', '\x3', '\x2', '\x2', '\x2', '\x19', 'q', '\x3', '\x2', '\x2', '\x2', '\x1B',
                's', '\x3', '\x2', '\x2', '\x2', '\x1D', 'u', '\x3', '\x2', '\x2', '\x2', '\x1F', 'w', '\x3', '\x2',
                '\x2', '\x2', '!', 'y', '\x3', '\x2', '\x2', '\x2', '#', '{', '\x3', '\x2', '\x2', '\x2', '%', '}',
                '\x3', '\x2', '\x2', '\x2', '\'', '\x80', '\x3', '\x2', '\x2', '\x2', ')', '\x84', '\x3', '\x2', '\x2',
                '\x2', '+', '\x9C', '\x3', '\x2', '\x2', '\x2', '-', '\x9E', '\x3', '\x2', '\x2', '\x2', '/', '\xA9',
                '\x3', '\x2', '\x2', '\x2', '\x31', '\xB1', '\x3', '\x2', '\x2', '\x2', '\x33', '\xB3', '\x3', '\x2',
                '\x2', '\x2', '\x35', '\xBD', '\x3', '\x2', '\x2', '\x2', '\x37', '\xC6', '\x3', '\x2', '\x2', '\x2',
                '\x39', '\xD4', '\x3', '\x2', '\x2', '\x2', ';', '\xE4', '\x3', '\x2', '\x2', '\x2', '=', '\xEE', '\x3',
                '\x2', '\x2', '\x2', '?', '@', '\t', '\x2', '\x2', '\x2', '@', '\x41', '\t', '\x3', '\x2', '\x2',
                '\x41', '\x42', '\t', '\x4', '\x2', '\x2', '\x42', '\x43', '\t', '\x5', '\x2', '\x2', '\x43', '\x44',
                '\t', '\x6', '\x2', '\x2', '\x44', '\x45', '\t', '\x3', '\x2', '\x2', '\x45', '\x4', '\x3', '\x2',
                '\x2', '\x2', '\x46', 'G', '\t', '\a', '\x2', '\x2', 'G', 'H', '\t', '\x4', '\x2', '\x2', 'H', 'I',
                '\t', '\b', '\x2', '\x2', 'I', 'J', '\t', '\t', '\x2', '\x2', 'J', 'K', '\t', '\n', '\x2', '\x2', 'K',
                '\x6', '\x3', '\x2', '\x2', '\x2', 'L', 'M', '\t', '\v', '\x2', '\x2', 'M', 'N', '\t', '\x5', '\x2',
                '\x2', 'N', 'O', '\t', '\a', '\x2', '\x2', 'O', 'P', '\t', '\x4', '\x2', '\x2', 'P', 'Q', '\t', '\b',
                '\x2', '\x2', 'Q', 'R', '\t', '\t', '\x2', '\x2', 'R', 'S', '\t', '\n', '\x2', '\x2', 'S', '\b', '\x3',
                '\x2', '\x2', '\x2', 'T', 'U', '\t', '\f', '\x2', '\x2', 'U', 'V', '\t', '\r', '\x2', '\x2', 'V', 'W',
                '\t', '\v', '\x2', '\x2', 'W', 'X', '\t', '\xE', '\x2', '\x2', 'X', '\n', '\x3', '\x2', '\x2', '\x2',
                'Y', 'Z', '\t', '\xE', '\x2', '\x2', 'Z', '[', '\t', '\v', '\x2', '\x2', '[', '\\', '\t', '\a', '\x2',
                '\x2', '\\', ']', '\t', '\xE', '\x2', '\x2', ']', '\f', '\x3', '\x2', '\x2', '\x2', '^', '_', '\t',
                '\x2', '\x2', '\x2', '_', '`', '\t', '\xF', '\x2', '\x2', '`', '\x61', '\t', '\x10', '\x2', '\x2',
                '\x61', '\x62', '\t', '\a', '\x2', '\x2', '\x62', '\x63', '\t', '\x4', '\x2', '\x2', '\x63', '\x64',
                '\t', '\b', '\x2', '\x2', '\x64', '\x65', '\t', '\t', '\x2', '\x2', '\x65', '\x66', '\t', '\n', '\x2',
                '\x2', '\x66', '\xE', '\x3', '\x2', '\x2', '\x2', 'g', 'h', '\a', '*', '\x2', '\x2', 'h', '\x10', '\x3',
                '\x2', '\x2', '\x2', 'i', 'j', '\a', '+', '\x2', '\x2', 'j', '\x12', '\x3', '\x2', '\x2', '\x2', 'k',
                'l', '\a', '}', '\x2', '\x2', 'l', '\x14', '\x3', '\x2', '\x2', '\x2', 'm', 'n', '\a', '\x7F', '\x2',
                '\x2', 'n', '\x16', '\x3', '\x2', '\x2', '\x2', 'o', 'p', '\a', ']', '\x2', '\x2', 'p', '\x18', '\x3',
                '\x2', '\x2', '\x2', 'q', 'r', '\a', '_', '\x2', '\x2', 'r', '\x1A', '\x3', '\x2', '\x2', '\x2', 's',
                't', '\a', '=', '\x2', '\x2', 't', '\x1C', '\x3', '\x2', '\x2', '\x2', 'u', 'v', '\a', '.', '\x2',
                '\x2', 'v', '\x1E', '\x3', '\x2', '\x2', '\x2', 'w', 'x', '\a', '\x30', '\x2', '\x2', 'x', ' ', '\x3',
                '\x2', '\x2', '\x2', 'y', 'z', '\a', '<', '\x2', '\x2', 'z', '\"', '\x3', '\x2', '\x2', '\x2', '{', '|',
                '\a', '?', '\x2', '\x2', '|', '$', '\x3', '\x2', '\x2', '\x2', '}', '~', '\a', '/', '\x2', '\x2', '~',
                '\x7F', '\a', '@', '\x2', '\x2', '\x7F', '&', '\x3', '\x2', '\x2', '\x2', '\x80', '\x81', '\a', '/',
                '\x2', '\x2', '\x81', '\x82', '\a', '/', '\x2', '\x2', '\x82', '(', '\x3', '\x2', '\x2', '\x2', '\x83',
                '\x85', '\a', '/', '\x2', '\x2', '\x84', '\x83', '\x3', '\x2', '\x2', '\x2', '\x84', '\x85', '\x3',
                '\x2', '\x2', '\x2', '\x85', '\x9A', '\x3', '\x2', '\x2', '\x2', '\x86', '\x88', '\a', '\x30', '\x2',
                '\x2', '\x87', '\x89', '\x5', '+', '\x16', '\x2', '\x88', '\x87', '\x3', '\x2', '\x2', '\x2', '\x89',
                '\x8A', '\x3', '\x2', '\x2', '\x2', '\x8A', '\x88', '\x3', '\x2', '\x2', '\x2', '\x8A', '\x8B', '\x3',
                '\x2', '\x2', '\x2', '\x8B', '\x9B', '\x3', '\x2', '\x2', '\x2', '\x8C', '\x8E', '\x5', '+', '\x16',
                '\x2', '\x8D', '\x8C', '\x3', '\x2', '\x2', '\x2', '\x8E', '\x8F', '\x3', '\x2', '\x2', '\x2', '\x8F',
                '\x8D', '\x3', '\x2', '\x2', '\x2', '\x8F', '\x90', '\x3', '\x2', '\x2', '\x2', '\x90', '\x98', '\x3',
                '\x2', '\x2', '\x2', '\x91', '\x95', '\a', '\x30', '\x2', '\x2', '\x92', '\x94', '\x5', '+', '\x16',
                '\x2', '\x93', '\x92', '\x3', '\x2', '\x2', '\x2', '\x94', '\x97', '\x3', '\x2', '\x2', '\x2', '\x95',
                '\x93', '\x3', '\x2', '\x2', '\x2', '\x95', '\x96', '\x3', '\x2', '\x2', '\x2', '\x96', '\x99', '\x3',
                '\x2', '\x2', '\x2', '\x97', '\x95', '\x3', '\x2', '\x2', '\x2', '\x98', '\x91', '\x3', '\x2', '\x2',
                '\x2', '\x98', '\x99', '\x3', '\x2', '\x2', '\x2', '\x99', '\x9B', '\x3', '\x2', '\x2', '\x2', '\x9A',
                '\x86', '\x3', '\x2', '\x2', '\x2', '\x9A', '\x8D', '\x3', '\x2', '\x2', '\x2', '\x9B', '*', '\x3',
                '\x2', '\x2', '\x2', '\x9C', '\x9D', '\t', '\x11', '\x2', '\x2', '\x9D', ',', '\x3', '\x2', '\x2',
                '\x2', '\x9E', '\xA4', '\a', '$', '\x2', '\x2', '\x9F', '\xA0', '\a', '^', '\x2', '\x2', '\xA0', '\xA3',
                '\a', '$', '\x2', '\x2', '\xA1', '\xA3', '\v', '\x2', '\x2', '\x2', '\xA2', '\x9F', '\x3', '\x2', '\x2',
                '\x2', '\xA2', '\xA1', '\x3', '\x2', '\x2', '\x2', '\xA3', '\xA6', '\x3', '\x2', '\x2', '\x2', '\xA4',
                '\xA5', '\x3', '\x2', '\x2', '\x2', '\xA4', '\xA2', '\x3', '\x2', '\x2', '\x2', '\xA5', '\xA7', '\x3',
                '\x2', '\x2', '\x2', '\xA6', '\xA4', '\x3', '\x2', '\x2', '\x2', '\xA7', '\xA8', '\a', '$', '\x2',
                '\x2', '\xA8', '.', '\x3', '\x2', '\x2', '\x2', '\xA9', '\xAE', '\x5', '\x31', '\x19', '\x2', '\xAA',
                '\xAD', '\x5', '\x31', '\x19', '\x2', '\xAB', '\xAD', '\x5', '+', '\x16', '\x2', '\xAC', '\xAA', '\x3',
                '\x2', '\x2', '\x2', '\xAC', '\xAB', '\x3', '\x2', '\x2', '\x2', '\xAD', '\xB0', '\x3', '\x2', '\x2',
                '\x2', '\xAE', '\xAC', '\x3', '\x2', '\x2', '\x2', '\xAE', '\xAF', '\x3', '\x2', '\x2', '\x2', '\xAF',
                '\x30', '\x3', '\x2', '\x2', '\x2', '\xB0', '\xAE', '\x3', '\x2', '\x2', '\x2', '\xB1', '\xB2', '\t',
                '\x12', '\x2', '\x2', '\xB2', '\x32', '\x3', '\x2', '\x2', '\x2', '\xB3', '\xB8', '\a', '>', '\x2',
                '\x2', '\xB4', '\xB7', '\x5', '\x35', '\x1B', '\x2', '\xB5', '\xB7', '\n', '\x13', '\x2', '\x2', '\xB6',
                '\xB4', '\x3', '\x2', '\x2', '\x2', '\xB6', '\xB5', '\x3', '\x2', '\x2', '\x2', '\xB7', '\xBA', '\x3',
                '\x2', '\x2', '\x2', '\xB8', '\xB6', '\x3', '\x2', '\x2', '\x2', '\xB8', '\xB9', '\x3', '\x2', '\x2',
                '\x2', '\xB9', '\xBB', '\x3', '\x2', '\x2', '\x2', '\xBA', '\xB8', '\x3', '\x2', '\x2', '\x2', '\xBB',
                '\xBC', '\a', '@', '\x2', '\x2', '\xBC', '\x34', '\x3', '\x2', '\x2', '\x2', '\xBD', '\xC1', '\a', '>',
                '\x2', '\x2', '\xBE', '\xC0', '\v', '\x2', '\x2', '\x2', '\xBF', '\xBE', '\x3', '\x2', '\x2', '\x2',
                '\xC0', '\xC3', '\x3', '\x2', '\x2', '\x2', '\xC1', '\xC2', '\x3', '\x2', '\x2', '\x2', '\xC1', '\xBF',
                '\x3', '\x2', '\x2', '\x2', '\xC2', '\xC4', '\x3', '\x2', '\x2', '\x2', '\xC3', '\xC1', '\x3', '\x2',
                '\x2', '\x2', '\xC4', '\xC5', '\a', '@', '\x2', '\x2', '\xC5', '\x36', '\x3', '\x2', '\x2', '\x2',
                '\xC6', '\xC7', '\a', '\x31', '\x2', '\x2', '\xC7', '\xC8', '\a', ',', '\x2', '\x2', '\xC8', '\xCC',
                '\x3', '\x2', '\x2', '\x2', '\xC9', '\xCB', '\v', '\x2', '\x2', '\x2', '\xCA', '\xC9', '\x3', '\x2',
                '\x2', '\x2', '\xCB', '\xCE', '\x3', '\x2', '\x2', '\x2', '\xCC', '\xCD', '\x3', '\x2', '\x2', '\x2',
                '\xCC', '\xCA', '\x3', '\x2', '\x2', '\x2', '\xCD', '\xCF', '\x3', '\x2', '\x2', '\x2', '\xCE', '\xCC',
                '\x3', '\x2', '\x2', '\x2', '\xCF', '\xD0', '\a', ',', '\x2', '\x2', '\xD0', '\xD1', '\a', '\x31',
                '\x2', '\x2', '\xD1', '\xD2', '\x3', '\x2', '\x2', '\x2', '\xD2', '\xD3', '\b', '\x1C', '\x2', '\x2',
                '\xD3', '\x38', '\x3', '\x2', '\x2', '\x2', '\xD4', '\xD5', '\a', '\x31', '\x2', '\x2', '\xD5', '\xD6',
                '\a', '\x31', '\x2', '\x2', '\xD6', '\xDA', '\x3', '\x2', '\x2', '\x2', '\xD7', '\xD9', '\v', '\x2',
                '\x2', '\x2', '\xD8', '\xD7', '\x3', '\x2', '\x2', '\x2', '\xD9', '\xDC', '\x3', '\x2', '\x2', '\x2',
                '\xDA', '\xDB', '\x3', '\x2', '\x2', '\x2', '\xDA', '\xD8', '\x3', '\x2', '\x2', '\x2', '\xDB', '\xDE',
                '\x3', '\x2', '\x2', '\x2', '\xDC', '\xDA', '\x3', '\x2', '\x2', '\x2', '\xDD', '\xDF', '\a', '\xF',
                '\x2', '\x2', '\xDE', '\xDD', '\x3', '\x2', '\x2', '\x2', '\xDE', '\xDF', '\x3', '\x2', '\x2', '\x2',
                '\xDF', '\xE0', '\x3', '\x2', '\x2', '\x2', '\xE0', '\xE1', '\a', '\f', '\x2', '\x2', '\xE1', '\xE2',
                '\x3', '\x2', '\x2', '\x2', '\xE2', '\xE3', '\b', '\x1D', '\x2', '\x2', '\xE3', ':', '\x3', '\x2',
                '\x2', '\x2', '\xE4', '\xE8', '\a', '%', '\x2', '\x2', '\xE5', '\xE7', '\n', '\x14', '\x2', '\x2',
                '\xE6', '\xE5', '\x3', '\x2', '\x2', '\x2', '\xE7', '\xEA', '\x3', '\x2', '\x2', '\x2', '\xE8', '\xE6',
                '\x3', '\x2', '\x2', '\x2', '\xE8', '\xE9', '\x3', '\x2', '\x2', '\x2', '\xE9', '\xEB', '\x3', '\x2',
                '\x2', '\x2', '\xEA', '\xE8', '\x3', '\x2', '\x2', '\x2', '\xEB', '\xEC', '\b', '\x1E', '\x2', '\x2',
                '\xEC', '<', '\x3', '\x2', '\x2', '\x2', '\xED', '\xEF', '\t', '\x15', '\x2', '\x2', '\xEE', '\xED',
                '\x3', '\x2', '\x2', '\x2', '\xEF', '\xF0', '\x3', '\x2', '\x2', '\x2', '\xF0', '\xEE', '\x3', '\x2',
                '\x2', '\x2', '\xF0', '\xF1', '\x3', '\x2', '\x2', '\x2', '\xF1', '\xF2', '\x3', '\x2', '\x2', '\x2',
                '\xF2', '\xF3', '\b', '\x1F', '\x2', '\x2', '\xF3', '>', '\x3', '\x2', '\x2', '\x2', '\x15', '\x2',
                '\x84', '\x8A', '\x8F', '\x95', '\x98', '\x9A', '\xA2', '\xA4', '\xAC', '\xAE', '\xB6', '\xB8', '\xC1',
                '\xCC', '\xDA', '\xDE', '\xE8', '\xF0', '\x3', '\b', '\x2', '\x2'
            };

        public static readonly ATN _ATN = new ATNDeserializer().Deserialize(_serializedATN);

        private static readonly string[] _LiteralNames =
            {
                null, null, null, null, null, null, null, "'('", "')'", "'{'", "'}'", "'['", "']'", "';'", "','", "'.'",
                "':'", "'='", "'->'", "'--'"
            };

        private static readonly string[] _SymbolicNames =
            {
                null, "STRICT", "GRAPH", "DIGRAPH", "NODE", "EDGE", "SUBGRAPH", "LPAREN", "RPAREN", "LBRACE", "RBRACE",
                "LBRACK", "RBRACK", "SEMI", "COMMA", "DOT", "COLON", "ASSIGN", "ARROW", "OPTION", "NUMBER", "STRING",
                "ID", "HTML_STRING", "COMMENT", "LINE_COMMENT", "PREPROC", "WS"
            };

        public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

        public static readonly string[] ruleNames =
            {
                "STRICT", "GRAPH", "DIGRAPH", "NODE", "EDGE", "SUBGRAPH", "LPAREN", "RPAREN", "LBRACE", "RBRACE",
                "LBRACK", "RBRACK", "SEMI", "COMMA", "DOT", "COLON", "ASSIGN", "ARROW", "OPTION", "NUMBER", "DIGIT",
                "STRING", "ID", "LETTER", "HTML_STRING", "TAG", "COMMENT", "LINE_COMMENT", "PREPROC", "WS"
            };

        public static string[] channelNames = { "DEFAULT_TOKEN_CHANNEL", "HIDDEN" };

        public static string[] modeNames = { "DEFAULT_MODE" };

        protected static DFA[] decisionToDFA;

        protected static PredictionContextCache sharedContextCache = new PredictionContextCache();

        static DotLexer()
        {
            decisionToDFA = new DFA[_ATN.NumberOfDecisions];
            for (var i = 0; i < _ATN.NumberOfDecisions; i++)
            {
                decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
            }
        }

        public DotLexer(ICharStream input)
            : this(input, Console.Out, Console.Error)
        {
        }

        public DotLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
            : base(input, output, errorOutput)
        {
            this.Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
        }

        public override string[] ChannelNames
        {
            get
            {
                return channelNames;
            }
        }

        public override string GrammarFileName
        {
            get
            {
                return "DotLexer.g4";
            }
        }

        public override string[] ModeNames
        {
            get
            {
                return modeNames;
            }
        }

        public override string[] RuleNames
        {
            get
            {
                return ruleNames;
            }
        }

        public override string SerializedAtn
        {
            get
            {
                return new string(_serializedATN);
            }
        }

        [NotNull]
        public override IVocabulary Vocabulary
        {
            get
            {
                return DefaultVocabulary;
            }
        }
    }
} // namespace Mobilize.Grammar.Language