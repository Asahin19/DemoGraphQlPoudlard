using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PoudlardAPI.DataModel.Extension;
using System;

namespace PoudlardAPI.Entities
{
    public class Professor
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public static void BuildEntityType(EntityTypeBuilder<Professor> typeBuilder)
        {
            typeBuilder.HasKey(x => x.Id);
        }
    }
}
