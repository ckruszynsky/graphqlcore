using GraphQL;
using GraphQL.Types;
using GraphQLDotNetCore.GraphQL.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDotNetCore.GraphQL
{
    public class AppSchema:Schema
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="resolver">
        /// helps resolve Query, Mutation, or Subscription objects
        /// </param>
        public AppSchema(IDependencyResolver resolver):base(resolver)
        {
            Query = resolver.Resolve<AppQuery>();
        }
    }
}
