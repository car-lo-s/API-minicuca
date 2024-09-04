﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReceitaAPI.Context;

#nullable disable

namespace ReceitaAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240725114026_inicioReceita")]
    partial class inicioReceita
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ReceitaAPI.Models.Receita", b =>
                {
                    b.Property<int>("ReceitaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ReceitaId"));

                    b.Property<int?>("UsuarioUserId")
                        .HasColumnType("int");

                    b.HasKey("ReceitaId");

                    b.HasIndex("UsuarioUserId");

                    b.ToTable("Receitas");
                });

            modelBuilder.Entity("ReceitaAPI.Models.Usuario", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("email")
                        .HasColumnType("longtext");

                    b.Property<string>("foto")
                        .HasColumnType("longtext");

                    b.Property<string>("nome")
                        .HasColumnType("longtext");

                    b.Property<string>("password")
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ReceitaAPI.Models.Receita", b =>
                {
                    b.HasOne("ReceitaAPI.Models.Usuario", null)
                        .WithMany("Receitas")
                        .HasForeignKey("UsuarioUserId");
                });

            modelBuilder.Entity("ReceitaAPI.Models.Usuario", b =>
                {
                    b.Navigation("Receitas");
                });
#pragma warning restore 612, 618
        }
    }
}
