﻿// <auto-generated />
using IntegraI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace IntegraI.Migrations
{
    [DbContext(typeof(CelebracionContext))]
    partial class CelebracionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Integra_I.Models.Celebracion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Asistentes");

                    b.Property<string>("Cedula");

                    b.Property<string>("Celular");

                    b.Property<string>("Correo");

                    b.Property<string>("Detalles");

                    b.Property<string>("Direccion");

                    b.Property<DateTime>("Fecha");

                    b.Property<string>("Necesidades");

                    b.Property<string>("Nombre");

                    b.Property<string>("TipoEvento");

                    b.HasKey("Id");

                    b.ToTable("Celebracion");
                });
#pragma warning restore 612, 618
        }
    }
}
