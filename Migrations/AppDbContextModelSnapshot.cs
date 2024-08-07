﻿// <auto-generated />
using System;
using ControleDgn.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControleDgn.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("ControleDgn.Models.Padrao", b =>
                {
                    b.Property<int>("PadraoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Certificado")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataCal")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("Frequencia")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("ValorNominal")
                        .HasColumnType("REAL");

                    b.HasKey("PadraoId");

                    b.ToTable("Padrao");
                });
#pragma warning restore 612, 618
        }
    }
}
