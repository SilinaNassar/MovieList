﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieListAsp.Models;

#nullable disable

namespace MovieListAsp.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20230324075319_initialNew")]
    partial class initialNew
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MovieListAsp.Models.MovieModel", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieID"), 1L, 1);

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

                    b.ToTable("MoviesNew");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            MovieName = "Casablanca",
                            Rating = 5,
                            Year = 1942
                        },
                        new
                        {
                            MovieID = 2,
                            MovieName = "Wonder Woman",
                            Rating = 3,
                            Year = 2017
                        },
                        new
                        {
                            MovieID = 3,
                            MovieName = "Moonstruck",
                            Rating = 4,
                            Year = 1988
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
