﻿// <auto-generated />
using System;
using DrVendasWebMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DrVendasWebMVC.Migrations
{
    [DbContext(typeof(DrVendasWebMVCContext))]
    partial class DrVendasWebMVCContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DrVendasWebMVC.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("DrVendasWebMVC.Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataVenda");

                    b.Property<int>("Status");

                    b.Property<double>("ValorTotal");

                    b.Property<int?>("VendedorId");

                    b.HasKey("Id");

                    b.HasIndex("VendedorId");

                    b.ToTable("Venda");
                });

            modelBuilder.Entity("DrVendasWebMVC.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataNascimento");

                    b.Property<int>("DepartamentoId");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<double>("SalarioBase");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("DrVendasWebMVC.Models.Venda", b =>
                {
                    b.HasOne("DrVendasWebMVC.Models.Vendedor", "Vendedor")
                        .WithMany("Vendas")
                        .HasForeignKey("VendedorId");
                });

            modelBuilder.Entity("DrVendasWebMVC.Models.Vendedor", b =>
                {
                    b.HasOne("DrVendasWebMVC.Models.Departamento", "Departamento")
                        .WithMany("Vendedores")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
