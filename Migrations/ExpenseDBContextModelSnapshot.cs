﻿// <auto-generated />
using System;
using ExpanseTrackerspro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExpanseTrackerspro.Migrations
{
    [DbContext(typeof(ExpenseDBContext))]
    partial class ExpenseDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExpanseTrackerspro.Models.ExpenseReport", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(10, 2)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpenseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemId");

                    b.ToTable("ExpenseReport");
                });
#pragma warning restore 612, 618
        }
    }
}
