﻿// <auto-generated />
using FileUpload.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FileUpload.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220822070234_Files")]
    partial class Files
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FileUpload.Models.DbFile", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("files")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("imageid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Files");
                });
#pragma warning restore 612, 618
        }
    }
}