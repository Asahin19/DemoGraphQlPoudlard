using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PoudlardAPI.DataModel.Extension;
using System;

namespace PoudlardAPI.Entities
{
    public class House
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Points { get; set; }

        public static void BuildEntityType(EntityTypeBuilder<House> typeBuilder)
        {
            typeBuilder.HasKey(x => x.Id);
        }
    }
}
