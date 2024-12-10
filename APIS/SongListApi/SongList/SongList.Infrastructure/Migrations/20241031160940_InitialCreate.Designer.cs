﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SongList.Infrastructure.MySqlDatabase;

#nullable disable

namespace SongList.Infrastructure.Migrations
{
    [DbContext(typeof(MySqlDbContext))]
    [Migration("20241031160940_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SongList.Domain.Entities.Song", b =>
                {
                    b.Property<int>("IdSong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Album")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2024, 10, 31, 12, 9, 40, 923, DateTimeKind.Local).AddTicks(3207));

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("IdSong");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("SongList.Domain.Entities.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)")
                        .HasDefaultValue(new DateTime(2024, 10, 31, 12, 9, 40, 923, DateTimeKind.Local).AddTicks(315));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdUser");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SongList.Domain.Entities.UserSong", b =>
                {
                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<int>("IdSong")
                        .HasColumnType("int");

                    b.HasKey("IdUser", "IdSong");

                    b.HasIndex("IdSong");

                    b.ToTable("UserSongs");
                });

            modelBuilder.Entity("SongList.Domain.Entities.UserSong", b =>
                {
                    b.HasOne("SongList.Domain.Entities.Song", "Song")
                        .WithMany("UserSongs")
                        .HasForeignKey("IdSong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SongList.Domain.Entities.User", "User")
                        .WithMany("UserSongs")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Song");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SongList.Domain.Entities.Song", b =>
                {
                    b.Navigation("UserSongs");
                });

            modelBuilder.Entity("SongList.Domain.Entities.User", b =>
                {
                    b.Navigation("UserSongs");
                });
#pragma warning restore 612, 618
        }
    }
}