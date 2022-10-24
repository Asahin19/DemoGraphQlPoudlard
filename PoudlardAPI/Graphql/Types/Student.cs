using GraphQL.Types;
using PoudlardAPI.Entities;

namespace PoudlardAPI.Graphql.Types
{
    public class StudentGraphType : ObjectGraphType<Student>
    {
        public StudentGraphType()
        {
            Name = "Student";
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Student Id");
            Field(x => x.FirstName).Description("Student's First Name");
            Field(x => x.LastName).Description("Student's Last Name");
            Field(x => x.BirthDate).Description("Student's birth date");
            Field(x => x.Age).Description("Student's Age");
        }
    }
}
