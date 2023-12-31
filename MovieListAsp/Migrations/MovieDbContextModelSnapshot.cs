﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieListAsp.Models;

#nullable disable

namespace MovieListAsp.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    partial class MovieDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MovieListAsp.Models.GenreModel", b =>
                {
                    b.Property<string>("GenreID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreID");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreID = "A",
                            GenreName = "Action"
                        },
                        new
                        {
                            GenreID = "C",
                            GenreName = "Comedy"
                        },
                        new
                        {
                            GenreID = "D",
                            GenreName = "Drama"
                        },
                        new
                        {
                            GenreID = "H",
                            GenreName = "Horror"
                        },
                        new
                        {
                            GenreID = "M",
                            GenreName = "Musical"
                        },
                        new
                        {
                            GenreID = "R",
                            GenreName = "RomCom"
                        },
                        new
                        {
                            GenreID = "S",
                            GenreName = "SciFi"
                        });
                });

            modelBuilder.Entity("MovieListAsp.Models.MovieModel", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieID"), 1L, 1);

                    b.Property<string>("GenreID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Rating")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Year")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("MovieID");

                    b.HasIndex("GenreID");

                    b.ToTable("MoviesNew");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            GenreID = "D",
                            MovieName = "Casablanca",
                            Rating = 5,
                            Year = 1942
                        },
                        new
                        {
                            MovieID = 2,
                            GenreID = "H",
                            MovieName = "Wonder Woman",
                            Rating = 3,
                            Year = 2017
                        },
                        new
                        {
                            MovieID = 3,
                            GenreID = "H",
                            MovieName = "Moonstruck",
                            Rating = 4,
                            Year = 1988
                        });
                });

            modelBuilder.Entity("MovieListAsp.Models.MovieModel", b =>
                {
                    b.HasOne("MovieListAsp.Models.GenreModel", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });
#pragma warning restore 612, 618
        }
    }
}
