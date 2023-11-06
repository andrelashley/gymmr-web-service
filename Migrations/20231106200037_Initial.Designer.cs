﻿// <auto-generated />
using System;
using Gymmr.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Gymmr.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231106200037_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Gymmr.Models.Photo", b =>
                {
                    b.Property<int>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PhotoId"));

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsMain")
                        .HasColumnType("boolean");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PhotoId");

                    b.ToTable("Photos");
                });
#pragma warning restore 612, 618
        }
    }
}