﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Yolcu360.Data;

#nullable disable

namespace Yolcu360.Data.Migrations
{
    [DbContext(typeof(Yolcu360DbContext))]
    [Migration("20230731185818_featConfigurationsTable")]
    partial class featConfigurationsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Yolcu360.Core.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Yolcu360.Core.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<decimal?>("CancelationPrice")
                        .HasColumnType("money");

                    b.Property<decimal>("DepozitPrice")
                        .HasColumnType("money");

                    b.Property<int>("FuelType")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsFreeCancelation")
                        .HasColumnType("bit");

                    b.Property<int>("MinDriverAge")
                        .HasColumnType("int");

                    b.Property<int>("MinDriverLisanseDay")
                        .HasColumnType("int");

                    b.Property<int>("MinYoungDriverAge")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("OfficeId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<decimal>("PriceFor3Days")
                        .HasColumnType("money");

                    b.Property<decimal>("TotalMillage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Transmission")
                        .HasColumnType("int");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("OfficeId");

                    b.HasIndex("TypeId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Yolcu360.Core.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Yolcu360.Core.Entities.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OpenTimes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("Yolcu360.Core.Entities.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("Yolcu360.Core.Entities.Car", b =>
                {
                    b.HasOne("Yolcu360.Core.Entities.Brand", "Brand")
                        .WithMany("Cars")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Yolcu360.Core.Entities.Office", "Office")
                        .WithMany("Cars")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("Yolcu360.Core.Entities.Type", "Type")
                        .WithMany("Cars")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Brand");

                    b.Navigation("Office");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Yolcu360.Core.Entities.Office", b =>
                {
                    b.HasOne("Yolcu360.Core.Entities.City", "City")
                        .WithMany("Offices")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("City");
                });

            modelBuilder.Entity("Yolcu360.Core.Entities.Brand", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Yolcu360.Core.Entities.City", b =>
                {
                    b.Navigation("Offices");
                });

            modelBuilder.Entity("Yolcu360.Core.Entities.Office", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Yolcu360.Core.Entities.Type", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
