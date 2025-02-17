
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PageEF.Models;

namespace PageEF.Data.Mappings{

    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //table
            builder.ToTable("User");

            //primary key
            builder.HasKey("Id");

            //identity
            builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

            builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80);

            builder.Property(x => x.Email)
            .IsRequired()
            .HasColumnName("Email")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80);

            builder.Property(x => x.PasswordHash);
            builder.Property(x => x.Bio);
            builder.Property(x => x.Image);
            builder.Property(x => x.Slug);

            //index
            builder.HasIndex(x => x.Slug, "IX_User_Slug")
            .IsUnique();
            
            //relationship
            //many to many
            builder.HasMany(x => x.Roles)
            .WithMany(x => x.Users)
            .UsingEntity<Dictionary<string, object>>(
                "UserRole",
                role => role.HasOne<Role>()
                .WithMany()
                .HasForeignKey("RoleId")
                .HasConstraintName("FK_UserRole_RoleId"),
                user => user.HasOne<User>()
                .WithMany()
                .HasForeignKey("UserId")
                .HasConstraintName("FK_UserRole_UserId")
            );
        }
    }
}