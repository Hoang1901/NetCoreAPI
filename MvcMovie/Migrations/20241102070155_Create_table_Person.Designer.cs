﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMovie.Data;

#nullable disable

namespace MvcMovie.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241102070155_Create_table_Person")]
    partial class Create_table_Person
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("MvcMovie.Models.Person", b =>
                {
                    b.Property<string>("PersonID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("TEXT");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("QueQuan")
                        .HasColumnType("TEXT");

                    b.HasKey("PersonID");

                    b.ToTable("Person");

                    b.HasDiscriminator().HasValue("Person");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("MvcMovie.Models.Employee", b =>
                {
                    b.HasBaseType("MvcMovie.Models.Person");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("company")
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
