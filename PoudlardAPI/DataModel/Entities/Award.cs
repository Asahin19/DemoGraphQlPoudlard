using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PoudlardAPI.DataModel.Extension;
using System;

namespace PoudlardAPI.Entities
{
    public class Award
    {
        public int Id { get; set; }
        public int HouseId { get; set; }
        public int ProfessorId { get; set; }

        public House House { get; set; }
        public Professor Professor { get; set; }


        public static void BuildEntityType(EntityTypeBuilder<Award> typeBuilder)
        {
            typeBuilder.HasKey(x => x.Id);

            typeBuilder
                .HasOne(x => x.House)
                .WithMany()
                .HasForeignKey(x => x.HouseId);

            typeBuilder
                .HasOne(x => x.Professor)
                .WithMany()
                .HasForeignKey(x => x.ProfessorId);
        }
    }
}
