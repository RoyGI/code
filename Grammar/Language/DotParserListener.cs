// ***********************************************************************
// <copyright file="DotParserListener.cs" company="Mobilize">
//     Copyright �  2017
// </copyright>
// <summary></summary>
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
    using Antlr4.Runtime.Misc;
    using Antlr4.Runtime.Tree;

    /// <summary>
    /// This interface defines a complete listener for a parse tree produced by
    /// <see cref="DotParser"/>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
    [System.CLSCompliant(false)]
    public interface IDotParserListener : IParseTreeListener
    {
        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.a_list"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterA_list([NotNull] DotParser.A_listContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.attribute_list"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterAttribute_list([NotNull] DotParser.Attribute_listContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.attribute_statement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterAttribute_statement([NotNull] DotParser.Attribute_statementContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.edge_operation"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterEdge_operation([NotNull] DotParser.Edge_operationContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.edge_statement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterEdge_statement([NotNull] DotParser.Edge_statementContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.edgeRHS"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterEdgeRHS([NotNull] DotParser.EdgeRHSContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.graph"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterGraph([NotNull] DotParser.GraphContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.id"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterId([NotNull] DotParser.IdContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.node_id"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterNode_id([NotNull] DotParser.Node_idContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.node_statement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterNode_statement([NotNull] DotParser.Node_statementContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.port"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterPort([NotNull] DotParser.PortContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.statement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterStatement([NotNull] DotParser.StatementContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.statement_list"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterStatement_list([NotNull] DotParser.Statement_listContext context);

        /// <summary>
        /// Enter a parse tree produced by <see cref="DotParser.subgraph"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void EnterSubgraph([NotNull] DotParser.SubgraphContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.a_list"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitA_list([NotNull] DotParser.A_listContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.attribute_list"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitAttribute_list([NotNull] DotParser.Attribute_listContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.attribute_statement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitAttribute_statement([NotNull] DotParser.Attribute_statementContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.edge_operation"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitEdge_operation([NotNull] DotParser.Edge_operationContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.edge_statement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitEdge_statement([NotNull] DotParser.Edge_statementContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.edgeRHS"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitEdgeRHS([NotNull] DotParser.EdgeRHSContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.graph"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitGraph([NotNull] DotParser.GraphContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.id"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitId([NotNull] DotParser.IdContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.node_id"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitNode_id([NotNull] DotParser.Node_idContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.node_statement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitNode_statement([NotNull] DotParser.Node_statementContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.port"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitPort([NotNull] DotParser.PortContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.statement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitStatement([NotNull] DotParser.StatementContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.statement_list"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitStatement_list([NotNull] DotParser.Statement_listContext context);

        /// <summary>
        /// Exit a parse tree produced by <see cref="DotParser.subgraph"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        void ExitSubgraph([NotNull] DotParser.SubgraphContext context);
    }
} // namespace Mobilize.Grammar.Language