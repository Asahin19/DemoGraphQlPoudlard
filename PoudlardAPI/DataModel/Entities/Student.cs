using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PoudlardAPI.DataModel.Extension;
using System;

namespace PoudlardAPI.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age => BirthDate.ToAge();
        public DateTime BirthDate { get; set; }

        public static void BuildEntityType(EntityTypeBuilder<Student> typeBuilder)
        {
            typeBuilder.HasKey(x => x.Id);
            typeBuilder.Ignore(x => x.Age);
        }
    }
}
