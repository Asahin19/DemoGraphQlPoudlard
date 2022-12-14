using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PoudlardAPI.DataModel.Extension;
using System;
using System.Collections.Generic;

namespace PoudlardAPI.Entities
{
    public class House
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public IEnumerable<Student>? Students { get; set; }

        public static void BuildEntityType(EntityTypeBuilder<House> typeBuilder)
        {
            typeBuilder.HasKey(x => x.Id);
        }
    }
}
