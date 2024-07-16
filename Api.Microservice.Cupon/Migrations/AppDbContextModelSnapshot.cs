﻿// <auto-generated />
using System;
using Api.Microservice.Cupon.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api.Microservice.Cupon.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Api.Microservice.Cupon.Models.Cupon", b =>
                {
                    b.Property<int>("CuponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CuponId"));

                    b.Property<string>("CuponCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DescuentoMinimo")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<double>("PorcentajeDescuento")
                        .HasColumnType("float");

                    b.HasKey("CuponId");

                    b.ToTable("Cupons");
                });
#pragma warning restore 612, 618
        }
    }
}
