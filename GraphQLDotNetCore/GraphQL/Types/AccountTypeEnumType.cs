using GraphQL.Types;
using GraphQLDotNetCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDotNetCore.GraphQL.Types
{
    public class AccountTypeEnumType:EnumerationGraphType<TypeOfAccount>
    {
        public AccountTypeEnumType()
        {
            //The Name property must match the name of the same enumeration property
            //inside our account class.
            Name = "Type";
            Description = "Enumeration for the account type object.";
        }
    }
}
