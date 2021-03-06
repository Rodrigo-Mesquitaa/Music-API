using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Music_API.Data;
using System;

namespace Music_API.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("music.Models.Album", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("ArtistId")
                    .HasColumnType("int");

                b.Property<string>("ImageUrl")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("ArtistId");

                b.ToTable("Albums");
            });

            modelBuilder.Entity("music.Models.Artist", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Gender")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ImageUrl")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Artists");
            });

            modelBuilder.Entity("music.Models.Song", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int?>("AlbumId")
                    .HasColumnType("int");

                b.Property<int>("ArtistId")
                    .HasColumnType("int");

                b.Property<string>("Duration")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ImageUrl")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("IsFeatured")
                    .HasColumnType("bit");

                b.Property<string>("SongUrl")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Title")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("UploadedDate")
                    .HasColumnType("datetime2");

                b.HasKey("Id");

                b.HasIndex("AlbumId");

                b.HasIndex("ArtistId");

                b.ToTable("Songs");
            });

            modelBuilder.Entity("music.Models.Album", b =>
            {
                b.HasOne("music.Models.Artist", null)
                    .WithMany("Albums")
                    .HasForeignKey("ArtistId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("music.Models.Song", b =>
            {
                b.HasOne("music.Models.Album", null)
                    .WithMany("Songs")
                    .HasForeignKey("AlbumId");

                b.HasOne("music.Models.Artist", null)
                    .WithMany("Songs")
                    .HasForeignKey("ArtistId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("music.Models.Album", b =>
            {
                b.Navigation("Songs");
            });

            modelBuilder.Entity("music.Models.Artist", b =>
            {
                b.Navigation("Albums");

                b.Navigation("Songs");
            });
#pragma warning restore 612, 618
        }
    }
}
