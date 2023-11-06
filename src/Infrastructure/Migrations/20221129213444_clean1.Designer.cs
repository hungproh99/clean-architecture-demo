﻿// <auto-generated />
using System;
using Infrastructure.Content.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221129213444_clean1")]
    partial class clean1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            NpgsqlModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Brand", b =>
                {
                    b.Property<int>("Brand_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    NpgsqlPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Brand_Id"));

                    b.Property<string>("Brand_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Brand_Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Domain.Product", b =>
                {
                    b.Property<int>("Product_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    NpgsqlPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Product_Id"));

                    b.Property<int?>("Brand_Id")
                        .HasColumnType("int");

                    b.Property<string>("Product_Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product_Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double?>("Product_Price")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("float");

                    b.Property<int?>("Product_Quantity")
                        .HasColumnType("int");

                    b.HasKey("Product_Id");

                    b.HasIndex("Brand_Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Domain.Product", b =>
                {
                    b.HasOne("Domain.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("Brand_Id");

                    b.Navigation("Brand");
                });
#pragma warning restore 612, 618
        }
    }
}
