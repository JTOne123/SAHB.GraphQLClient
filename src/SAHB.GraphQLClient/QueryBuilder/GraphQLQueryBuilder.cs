﻿using System;
using SAHB.GraphQLClient.FieldBuilder;

namespace SAHB.GraphQLClient.QueryBuilder
{
    // ReSharper disable once InconsistentNaming
    /// <inheritdoc cref="IGraphQLQueryBuilder" />
    public class GraphQLQueryBuilder : GraphQLQueryBuilderFromFields, IGraphQLQueryBuilder, IGraphQLQueryBuilderFromFields
    {
        private readonly IGraphQLFieldBuilder _graphQlFieldBuilder;

        public GraphQLQueryBuilder(IGraphQLFieldBuilder graphQlFieldBuilder)
        {
            _graphQlFieldBuilder = graphQlFieldBuilder;
        }

        /// <inheritdoc />
        public string GetQuery(Type type, params GraphQLQueryArgument[] arguments)
        {
            return GetQuery(_graphQlFieldBuilder.GetFields(type), arguments);
        }

        /// <inheritdoc />
        public string GetMutation(Type type, params GraphQLQueryArgument[] arguments)
        {
            return GetMutation(_graphQlFieldBuilder.GetFields(type), arguments);
        }
    }
}
