using GraphQL.Types;
using PoudlardAPI.Entities;

namespace PoudlardAPI.Graphql.Types
{
    public class HouseGraphType : ObjectGraphType<House>
    {
        public HouseGraphType()
        {
            Name = "House";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("House Id");
            Field(x => x.Name).Description("House's Name");
        }
    }
}
