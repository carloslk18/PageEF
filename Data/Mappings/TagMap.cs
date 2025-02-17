using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PageEF.Models;

namespace PageEF.Data.Mappings{

    public class TagMap : IEntityTypeConfiguration<Tag>{
        public void Configure(EntityTypeBuilder<Tag> builder){
                       
            //table
            builder.ToTable("Tag");

            //primary key
            builder.HasKey(x => x.Id);

            //identity
            builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

            builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80);

            builder.Property(x => x.Slug)
            .IsRequired()
            .HasColumnName("Slug")
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);

            //index
            builder.HasIndex(x => x.Slug, "IX_Tag_Slug")
            .IsUnique();
        }
    }
}