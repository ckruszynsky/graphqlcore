using GraphQL;
using GraphQL.Types;
using GraphQLDotNetCore.Contracts;
using GraphQLDotNetCore.GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDotNetCore.GraphQL.Queries
{
    /// <summary>
    /// this class inherits from the ObjectGraphType. The ownerRepository
    /// is injected inside a constructor and create field to return the result
    /// for the specific query. 
    /// </summary>
    public class AppQuery : ObjectGraphType
    {
        /// <summary>
        /// The field method accepts a GraphQL.Net representation for the 
        /// normal .NET types. 
        /// 
        /// The "owners" parameter is a field name (query from the client must match this name)
        /// and the second parameter is the result itself. 
        /// </summary>
        /// <param name="ownerRepository"></param>
        public AppQuery(IOwnerRepository ownerRepository)
        {
            Field<ListGraphType<OwnerType>>("owners", resolve: context => ownerRepository.GetAll());
            Field<OwnerType>(
                "owner",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "ownerId" }),
                resolve: context =>
                {
                    Guid id;
                    if(!Guid.TryParse(context.GetArgument<string>("ownerId"),out id))
                    {
                        context.Errors.Add(new ExecutionError("Wrong value for guid"));
                        return null;
                    }                 
                    return ownerRepository.GetById(id);
                }
           );
        }
    }
}
