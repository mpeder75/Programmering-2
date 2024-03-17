﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Session_7___Aflevering___DA;

#nullable disable

namespace Session_7___Aflevering___DA.Migrations
{
    [DbContext(typeof(VaregruppeDbContext))]
    [Migration("20240317203846_UpdatProject")]
    partial class UpdatProject
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Session_7___Aflevering___Models.Vare", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("StockAmount")
                        .HasColumnType("int");

                    b.Property<int>("VaregruppeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VaregruppeId");

                    b.ToTable("Varer");
                });

            modelBuilder.Entity("Session_7___Aflevering___Models.Varegruppe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Varegrupper");
                });

            modelBuilder.Entity("Session_7___Aflevering___Models.Vare", b =>
                {
                    b.HasOne("Session_7___Aflevering___Models.Varegruppe", "Varegruppe")
                        .WithMany("Varer")
                        .HasForeignKey("VaregruppeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Varegruppe");
                });

            modelBuilder.Entity("Session_7___Aflevering___Models.Varegruppe", b =>
                {
                    b.Navigation("Varer");
                });
#pragma warning restore 612, 618
        }
    }
}
