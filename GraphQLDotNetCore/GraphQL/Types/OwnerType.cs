using GraphQL.DataLoader;
using GraphQL.Types;
using GraphQLDotNetCore.Contracts;
using GraphQLDotNetCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDotNetCore.GraphQL.Types
{
    /// <summary>
    /// used a replacement for the owner model inside the GraphQL API.
    /// Inherits from a generic ObjectGraphType<Owner> class which at 
    /// some point in the hierarchy implements IObjectGraphType
    /// The Field method is used to specify the fiels which represents our properties
    /// from the Owner model class.
    /// </summary>
    public class OwnerType:ObjectGraphType<Owner>
    {
        
        /// <summary>        
        /// </summary>
        /// <param name="dataLoader">
        ///  the dataLoader object helps with loading related collection by executing the 
        ///  specified query the filters only by the current owner.
        /// </param>
        /// <param name="repository"></param>
        public OwnerType(IDataLoaderContextAccessor dataLoader,IAccountRepository repository)
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id property from the owner object.");
            Field(x => x.Name).Description("Name property from the owner object.");
            Field(x => x.Address).Description("Address property from the owner object.");         
            Field<ListGraphType<AccountType>>(
                 "accounts",
                 resolve: context =>
                 {
                     var loader = dataLoader.Context.GetOrAddCollectionBatchLoader<Guid, Account>("GetAccountsByOwnerIds", repository.GetAccountsByOwnerIds);
                     return loader.LoadAsync(context.Source.Id);
                 });
        }
    }
}
