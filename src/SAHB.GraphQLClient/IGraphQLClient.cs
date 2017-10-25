﻿using System.Threading.Tasks;
using SAHB.GraphQLClient.QueryBuilder;

namespace SAHB.GraphQLClient
{
    // ReSharper disable once InconsistentNaming
    public interface IGraphQLClient
    {
        Task<T> Get<T>(string url, string authorizationToken = null, string authorizationMethod = "Bearer", params GraphQLQueryArgument[] arguments) where T : class;
        Task<T> Mutate<T>(string url, string authorizationToken = null, string authorizationMethod = "Bearer", params GraphQLQueryArgument[] arguments) where T : class;
    }
}