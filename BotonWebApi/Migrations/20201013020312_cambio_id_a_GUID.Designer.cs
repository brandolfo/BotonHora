﻿// <auto-generated />
using System;
using BotonWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BotonWebApi.Migrations
{
    [DbContext(typeof(Buttondb))]
    [Migration("20201013020312_cambio_id_a_GUID")]
    partial class cambio_id_a_GUID
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BotonWebApi.Models.Button", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("TimeClick")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Buttons");
                });
#pragma warning restore 612, 618
        }
    }
}
