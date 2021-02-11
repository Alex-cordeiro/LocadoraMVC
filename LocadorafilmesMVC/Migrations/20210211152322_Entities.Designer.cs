﻿// <auto-generated />
using System;
using LocadorafilmesMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocadorafilmesMVC.Migrations
{
    [DbContext(typeof(LocadorafilmesMVCContext))]
    [Migration("20210211152322_Entities")]
    partial class Entities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LocadorafilmesMVC.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<int>("Idade");

                    b.Property<string>("Nome");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("LocadorafilmesMVC.Models.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Genero");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.ToTable("Filme");
                });

            modelBuilder.Entity("LocadorafilmesMVC.Models.Locacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteId");

                    b.Property<DateTime>("DataDevolucao");

                    b.Property<DateTime>("DataLocacao");

                    b.Property<int?>("FilmeId");

                    b.Property<int?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FilmeId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Locacao");
                });

            modelBuilder.Entity("LocadorafilmesMVC.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<int>("NivelAcesso");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("LocadorafilmesMVC.Models.Locacao", b =>
                {
                    b.HasOne("LocadorafilmesMVC.Models.Cliente")
                        .WithMany("Locacoes")
                        .HasForeignKey("ClienteId");

                    b.HasOne("LocadorafilmesMVC.Models.Filme")
                        .WithMany("Locacoes")
                        .HasForeignKey("FilmeId");

                    b.HasOne("LocadorafilmesMVC.Models.Usuario")
                        .WithMany("Locacoes")
                        .HasForeignKey("UsuarioId");
                });
#pragma warning restore 612, 618
        }
    }
}
