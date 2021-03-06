﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Music_Store.Models;

namespace Music_Store.Migrations
{
    [DbContext(typeof(DbContextDemo))]
    partial class DbContextDemoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Music_Store.Models.Album", b =>
                {
                    b.Property<int>("AlbumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameAlbum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlbumID");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("Music_Store.Models.Singer", b =>
                {
                    b.Property<int>("SingerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BirthDay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SingerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SingerID");

                    b.ToTable("Singers");
                });

            modelBuilder.Entity("Music_Store.Models.SingerSong", b =>
                {
                    b.Property<int>("SingerID")
                        .HasColumnType("int");

                    b.Property<int>("SongID")
                        .HasColumnType("int");

                    b.HasKey("SingerID", "SongID");

                    b.HasIndex("SongID");

                    b.ToTable("SingerSongs");
                });

            modelBuilder.Entity("Music_Store.Models.Song", b =>
                {
                    b.Property<int>("SongID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumID")
                        .HasColumnType("int");

                    b.Property<string>("SongName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SongID");

                    b.HasIndex("AlbumID");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("Music_Store.Models.SingerSong", b =>
                {
                    b.HasOne("Music_Store.Models.Singer", "Singer")
                        .WithMany("singerSongs")
                        .HasForeignKey("SingerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Music_Store.Models.Song", "Song")
                        .WithMany("singerSongs")
                        .HasForeignKey("SongID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Music_Store.Models.Song", b =>
                {
                    b.HasOne("Music_Store.Models.Album", "Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
