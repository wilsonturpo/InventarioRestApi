﻿// <auto-generated />
using GEN_InventarioRestApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GEN_InventarioRestApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220110050902_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GEN_InventarioRestApi.Modelos.Medida", b =>
                {
                    b.Property<int>("MEDI_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MEDI_Id"), 1L, 1);

                    b.Property<string>("MEDI_cDescripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MEDI_cTipo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MEDI_Id");

                    b.ToTable("Medidas");
                });

            modelBuilder.Entity("GEN_InventarioRestApi.Modelos.Producto", b =>
                {
                    b.Property<int>("PROD_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PROD_Id"), 1L, 1);

                    b.Property<int>("MEDI_Id")
                        .HasColumnType("int");

                    b.Property<string>("PROD_cDescripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("PROD_nPrecio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PROD_nStock")
                        .HasColumnType("int");

                    b.Property<int>("SECC_Id")
                        .HasColumnType("int");

                    b.HasKey("PROD_Id");

                    b.HasIndex("MEDI_Id");

                    b.HasIndex("SECC_Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("GEN_InventarioRestApi.Modelos.Seccion", b =>
                {
                    b.Property<int>("SECC_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SECC_Id"), 1L, 1);

                    b.Property<string>("SECC_cDescripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SECC_Id");

                    b.ToTable("Secciones");
                });

            modelBuilder.Entity("GEN_InventarioRestApi.Modelos.Producto", b =>
                {
                    b.HasOne("GEN_InventarioRestApi.Modelos.Medida", "Medida")
                        .WithMany()
                        .HasForeignKey("MEDI_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GEN_InventarioRestApi.Modelos.Seccion", "Seccion")
                        .WithMany()
                        .HasForeignKey("SECC_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medida");

                    b.Navigation("Seccion");
                });
#pragma warning restore 612, 618
        }
    }
}