using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PageEF.Models;

namespace PageEF.Data.Mappings{

    public class CategoryMap : IEntityTypeConfiguration<Category>{
        public void Configure(EntityTypeBuilder<Category> builder){
                       
            //table
            builder.ToTable("Category");

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
            builder.HasIndex(x => x.Slug, "IX_Category_Slug")
            .IsUnique();
        }
    }
}