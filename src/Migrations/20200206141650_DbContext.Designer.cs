﻿// <auto-generated />
using System;
using Bitly;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace bitly.Migrations
{
    [DbContext(typeof(UrlDbContext))]
    [Migration("20200206141650_DbContext")]
    partial class DbContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Bitly.Models.Url", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("GeneratedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("LongUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ShortUrl")
                        .IsRequired()
                        .HasColumnType("character(8)")
                        .IsFixedLength(true)
                        .HasMaxLength(8);

                    b.HasKey("Id");

                    b.ToTable("url");
                });
#pragma warning restore 612, 618
        }
    }
}
