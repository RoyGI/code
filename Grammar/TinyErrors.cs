﻿// ***********************************************************************
// <copyright file="TinyErrors.cs" company="Mobilize">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Mobilize.Grammar
{
    using System.Collections.Generic;
    using System.IO;

    using Antlr4.Runtime;

    /// <summary>
    ///     Class TinyErrors.
    /// </summary>
    /// <seealso cref="Antlr4.Runtime.BaseErrorListener" />
    public class TinyErrors : BaseErrorListener, IAntlrErrorListener<int>
    {
        /// <summary>
        ///     The errors
        /// </summary>
        private readonly List<Error> errors;

        /// <summary>
        ///     Initializes a new instance of the <see cref="TinyErrors" /> class.
        /// </summary>
        public TinyErrors()
        {
            this.errors = new List<Error>();
        }

        /// <summary>
        ///     Gets the errors.
        /// </summary>
        /// <value>The errors.</value>
        public IEnumerable<Error> Errors => this.errors;

        /// <summary>
        /// Upon syntax error, notify any interested parties.
        /// </summary>
        /// <param name="output">Where the error should be written.</param>
        /// <param name="recognizer">What parser got the error. From this
        /// object, you can access the context as well
        /// as the input stream.</param>
        /// <param name="offendingSymbol">The offending token in the input token
        /// stream, unless recognizer is a lexer (then it's null). If
        /// no viable alternative error,
        /// <paramref name="e" />
        /// has token at which we
        /// started production for the decision.</param>
        /// <param name="line">The line number in the input where the error occurred.</param>
        /// <param name="charPositionInLine">The character position within that line where the error occurred.</param>
        /// <param name="msg">The message to emit.</param>
        /// <param name="e">The exception generated by the parser that led to
        /// the reporting of an error. It is null in the case where
        /// the parser was able to recover in line without exiting the
        /// surrounding rule.</param>
        /// <remarks>Upon syntax error, notify any interested parties. This is not how to
        /// recover from errors or compute error messages.
        /// <see cref="T:Antlr4.Runtime.IAntlrErrorStrategy" />
        /// specifies how to recover from syntax errors and how to compute error
        /// messages. This listener's job is simply to emit a computed message,
        /// though it has enough information to create its own message in many cases.
        /// <p>The
        /// <see cref="T:Antlr4.Runtime.RecognitionException" />
        /// is non-null for all syntax errors except
        /// when we discover mismatched token errors that we can recover from
        /// in-line, without returning from the surrounding rule (via the single
        /// token insertion and deletion mechanism).</p></remarks>
        public void SyntaxError(
            TextWriter output,
            IRecognizer recognizer,
            int offendingSymbol,
            int line,
            int charPositionInLine,
            string msg,
            RecognitionException e) => this.errors.Add(
                new Error
                {
                    CharLine = charPositionInLine,
                    Line = line,
                    Message = msg,
                    Source = $"{recognizer.GrammarFileName} {recognizer.InputStream.SourceName}"
                });

        /// <summary>
        ///     Upon syntax error, notify any interested parties.
        /// </summary>
        /// <param name="recognizer">
        ///     What parser got the error. From this
        ///     object, you can access the context as well
        ///     as the input stream.
        /// </param>
        /// <param name="offendingSymbol">
        ///     The offending token in the input token
        ///     stream, unless recognizer is a lexer (then it's null). If
        ///     no viable alternative error,
        ///     <paramref name="e" />
        ///     has token at which we
        ///     started production for the decision.
        /// </param>
        /// <param name="line">The line number in the input where the error occurred.</param>
        /// <param name="charPositionInLine">The character position within that line where the error occurred.</param>
        /// <param name="msg">The message to emit.</param>
        /// <param name="e">
        ///     The exception generated by the parser that led to
        ///     the reporting of an error. It is null in the case where
        ///     the parser was able to recover in line without exiting the
        ///     surrounding rule.
        /// </param>
        /// <remarks>
        ///     Upon syntax error, notify any interested parties. This is not how to
        ///     recover from errors or compute error messages.
        ///     <see cref="T:Antlr4.Runtime.IAntlrErrorStrategy" />
        ///     specifies how to recover from syntax errors and how to compute error
        ///     messages. This listener's job is simply to emit a computed message,
        ///     though it has enough information to create its own message in many cases.
        ///     <p>
        ///         The
        ///         <see cref="T:Antlr4.Runtime.RecognitionException" />
        ///         is non-null for all syntax errors except
        ///         when we discover mismatched token errors that we can recover from
        ///         in-line, without returning from the surrounding rule (via the single
        ///         token insertion and deletion mechanism).
        ///     </p>
        /// </remarks>
        public void SyntaxError(
            IRecognizer recognizer,
            int offendingSymbol,
            int line,
            int charPositionInLine,
            string msg,
            RecognitionException e) => this.errors.Add(
                new Error
                {
                    CharLine = charPositionInLine,
                    Line = line,
                    Message = msg,
                    Source = $"{recognizer.GrammarFileName} {recognizer.InputStream.SourceName}"
                });
    }
}