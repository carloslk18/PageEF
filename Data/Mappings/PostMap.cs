using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PageEF.Models;

namespace PageEF.Data.Mappings{
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            //table
            builder.ToTable(name: "Post");

            //primary key
            builder.HasKey(x => x.Id);

            //identity
            builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

            builder.Property(x => x.Title);
            builder.Property(x => x.Summary);
            builder.Property(x => x.Body);
            builder.Property(x => x.Slug);

            builder.Property(x => x.CreateDate)
            .IsRequired()
            .HasColumnName("CreateDate")
            .HasColumnType("SMALLDATETIME")
            //roda o comando no SQL
            .HasDefaultValueSql("GETDATA()"); 
            // roda o comando no .NET
            //.HasDefaultValue(DateTime.Now.ToUniversalTime); 

            builder.Property(x => x.LastUpdateDate)
            .IsRequired()
            .HasColumnName("LastUpdateDate")
            .HasColumnType("SMALLDATETIME")
            //roda o comando no SQL
            .HasDefaultValueSql("GETDATA()"); 
            //roda o comando no SQL
            // .HasDefaultValue(DateTime.Now.ToUniversalTime); // roda o comando no .NET

            builder.HasIndex(x => x.Slug, "IX_Post_Slug")
            .IsUnique();

            //Relationship
            //one to many
            builder.HasOne(x => x.Author)
            .WithMany(x => x.Posts)
            .HasConstraintName("FK_Post_Author");
            
            builder.HasOne(x => x.Category)
            .WithMany(x => x.Posts)
            .HasConstraintName("FK_Post_Category");

            //many to many
            builder.HasMany(x => x.Tags)
            .WithMany(x=> x.Posts)
            .UsingEntity<Dictionary<string, object>>(
                "PostTag",
                post => post.HasOne<Tag>()
                .WithMany()
                .HasForeignKey("PostId")
                .HasConstraintName("FK_PostTag_PostId"),
                tag => tag.HasOne<Post>()
                .WithMany()
                .HasForeignKey("TagId")
                .HasConstraintName("FK_PostTag_Id")
            );
        }
    }
}