﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskAPI.DataAccess;

namespace TaskAPI.DataAccess.Migrations
{
    [DbContext(typeof(TodoDBContext))]
    [Migration("20230106070106_JobroleFieldAddedtoAuthor")]
    partial class JobroleFieldAddedtoAuthor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TaskAPI.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressNo")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("JobRole")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Street")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressNo = "1",
                            City = "Colombo 1",
                            FullName = "Senith",
                            JobRole = "Developer",
                            Street = "Street 1"
                        },
                        new
                        {
                            Id = 2,
                            AddressNo = "2",
                            City = "Colombo 2",
                            FullName = "Dilitha",
                            JobRole = "System Engineer",
                            Street = "Street 2"
                        },
                        new
                        {
                            Id = 3,
                            AddressNo = "3",
                            City = "Colombo 3",
                            FullName = "Sumashi",
                            JobRole = "Manager",
                            Street = "Street 3"
                        },
                        new
                        {
                            Id = 4,
                            AddressNo = "4",
                            City = "Colombo 4",
                            FullName = "Hansani",
                            JobRole = "Developer",
                            Street = "Street 4"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("Due")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Created = new DateTime(2023, 1, 6, 12, 31, 5, 928, DateTimeKind.Local).AddTicks(8878),
                            Description = "Get some text books for school DB",
                            Due = new DateTime(2023, 1, 8, 12, 31, 5, 930, DateTimeKind.Local).AddTicks(8447),
                            Status = 0,
                            Title = "Get books for school from DB"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            Created = new DateTime(2023, 1, 6, 12, 31, 5, 930, DateTimeKind.Local).AddTicks(9988),
                            Description = "Need some groceries from super market DB",
                            Due = new DateTime(2023, 1, 11, 12, 31, 5, 930, DateTimeKind.Local).AddTicks(9994),
                            Status = 0,
                            Title = "Need some groceries from DB"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            Created = new DateTime(2023, 1, 6, 12, 31, 5, 931, DateTimeKind.Local).AddTicks(33),
                            Description = "Purchase Camera from super market DB",
                            Due = new DateTime(2023, 1, 9, 12, 31, 5, 931, DateTimeKind.Local).AddTicks(35),
                            Status = 0,
                            Title = "Purchase Camera from DB"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.HasOne("TaskAPI.Models.Author", "Author")
                        .WithMany("Todos")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("TaskAPI.Models.Author", b =>
                {
                    b.Navigation("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}
