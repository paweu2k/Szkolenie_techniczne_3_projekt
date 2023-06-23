﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Szkolenie_techniczne_3_projekt.Data;

namespace Szkolenie_techniczne_3_projekt.Migrations
{
    [DbContext(typeof(ProjectDbContext))]
    partial class ProjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentsTeachers", b =>
                {
                    b.Property<Guid>("Studentsid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Teachersid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Studentsid", "Teachersid");

                    b.HasIndex("Teachersid");

                    b.ToTable("StudentsTeachers");
                });

            modelBuilder.Entity("Szkolenie_techniczne_3_projekt.Models.Students", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nazwisko")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numer_domu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ulica")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Szkolenie_techniczne_3_projekt.Models.Teachers", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nazwisko")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("specjalizacja")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("StudentsTeachers", b =>
                {
                    b.HasOne("Szkolenie_techniczne_3_projekt.Models.Students", null)
                        .WithMany()
                        .HasForeignKey("Studentsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Szkolenie_techniczne_3_projekt.Models.Teachers", null)
                        .WithMany()
                        .HasForeignKey("Teachersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
