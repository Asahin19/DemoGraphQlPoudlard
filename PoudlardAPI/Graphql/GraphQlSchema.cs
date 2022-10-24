using GraphQL;
using GraphQL.Types;
using PoudlardAPI.Graphql.Query;

namespace PoudlardAPI.Graphql
{
    public class GraphQlSchema : Schema
    {
        public GraphQlSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<StudentQuery>();
        }
    }
}