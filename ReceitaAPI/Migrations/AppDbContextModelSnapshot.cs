﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReceitaAPI.Context;

#nullable disable

namespace ReceitaAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("ReceitaName")
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioUserId")
                        .HasColumnType("int");

                    b.Property<string>("ingredientes")
                        .HasColumnType("longtext");

                    b.Property<string>("instrucao")
                        .HasColumnType("longtext");

                    b.Property<string>("receitaimg")
                        .HasColumnType("longtext");

                    b.Property<string>("tempo")
                        .HasColumnType("longtext");

                    b.Property<string>("tipo")
                        .HasColumnType("longtext");

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
                    b.HasOne("ReceitaAPI.Models.Usuario", "Usuario")
                        .WithMany("Receitas")
                        .HasForeignKey("UsuarioUserId");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ReceitaAPI.Models.Usuario", b =>
                {
                    b.Navigation("Receitas");
                });
#pragma warning restore 612, 618
        }
    }
}
