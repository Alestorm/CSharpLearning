﻿// <auto-generated />
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviesApi.Infrastructure.Postgresql;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MoviesApi.Migrations
{
    [DbContext(typeof(PostgresDbContext))]
    [Migration("20241004000453_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MoviesApi.Domain.Movie", b =>
                {
                    b.Property<int>("IdMovie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdMovie"));

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<List<string>>("Genre")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("IdMovie");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MoviesApi.Domain.Rating", b =>
                {
                    b.Property<int>("IdRating")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdRating"));

                    b.Property<int>("IdMovie")
                        .HasColumnType("integer");

                    b.Property<int>("Rate")
                        .HasColumnType("integer");

                    b.HasKey("IdRating");

                    b.HasIndex("IdMovie");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("MoviesApi.Domain.Rating", b =>
                {
                    b.HasOne("MoviesApi.Domain.Movie", "Movie")
                        .WithMany("Ratings")
                        .HasForeignKey("IdMovie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MoviesApi.Domain.Movie", b =>
                {
                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}