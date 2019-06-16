﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLPM.DAO;

namespace QLPM.Migrations
{
    [DbContext(typeof(DbQLPMContext))]
    partial class DbQLPMContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QLPM.Models.DANGKYTIETHOC", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CABATDAU");

                    b.Property<string>("GHICHU");

                    b.Property<string>("MADM");

                    b.Property<string>("MAGV");

                    b.Property<string>("MALOP");

                    b.Property<string>("MAPHONG");

                    b.HasKey("ID");

                    b.HasIndex("MADM");

                    b.HasIndex("MAGV");

                    b.HasIndex("MALOP");

                    b.HasIndex("MAPHONG");

                    b.ToTable("DANGKYTIETHOC");
                });

            modelBuilder.Entity("QLPM.Models.DAYMAY", b =>
                {
                    b.Property<string>("MADM")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MATT");

                    b.HasKey("MADM");

                    b.HasIndex("MATT");

                    b.ToTable("DAYMAY");
                });

            modelBuilder.Entity("QLPM.Models.GIANGVIEN", b =>
                {
                    b.Property<string>("MAGV")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EMAIL");

                    b.Property<string>("SDT");

                    b.Property<string>("TEN");

                    b.HasKey("MAGV");

                    b.ToTable("GIANGVIEN");
                });

            modelBuilder.Entity("QLPM.Models.LOP", b =>
                {
                    b.Property<string>("MALOP")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TENLOP");

                    b.HasKey("MALOP");

                    b.ToTable("LOP");
                });

            modelBuilder.Entity("QLPM.Models.MAYTINH", b =>
                {
                    b.Property<int>("MAMT")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MADM");

                    b.Property<string>("MATT");

                    b.Property<string>("TENMT");

                    b.HasKey("MAMT");

                    b.HasIndex("MADM");

                    b.HasIndex("MATT");

                    b.ToTable("MAYTINH");
                });

            modelBuilder.Entity("QLPM.Models.PHONG", b =>
                {
                    b.Property<string>("MAPHONG")
                        .ValueGeneratedOnAdd();

                    b.HasKey("MAPHONG");

                    b.ToTable("PHONG");
                });

            modelBuilder.Entity("QLPM.Models.TRANGTHAI", b =>
                {
                    b.Property<string>("MATT")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TENTT");

                    b.HasKey("MATT");

                    b.ToTable("TRANGTHAI");
                });

            modelBuilder.Entity("QLPM.Models.DANGKYTIETHOC", b =>
                {
                    b.HasOne("QLPM.Models.DAYMAY", "DAYMAY")
                        .WithMany("DANGKYTIETHOCs")
                        .HasForeignKey("MADM");

                    b.HasOne("QLPM.Models.GIANGVIEN", "GIANGVIEN")
                        .WithMany("DANGKYTIETHOCs")
                        .HasForeignKey("MAGV");

                    b.HasOne("QLPM.Models.LOP", "LOP")
                        .WithMany("DANGKYTIETHOCs")
                        .HasForeignKey("MALOP");

                    b.HasOne("QLPM.Models.PHONG", "PHONG")
                        .WithMany("DANGKYTIETHOCs")
                        .HasForeignKey("MAPHONG");
                });

            modelBuilder.Entity("QLPM.Models.DAYMAY", b =>
                {
                    b.HasOne("QLPM.Models.TRANGTHAI", "TRANGTHAI")
                        .WithMany("DAYMAYs")
                        .HasForeignKey("MATT");
                });

            modelBuilder.Entity("QLPM.Models.MAYTINH", b =>
                {
                    b.HasOne("QLPM.Models.DAYMAY", "DAYMAY")
                        .WithMany("MAYTINHs")
                        .HasForeignKey("MADM");

                    b.HasOne("QLPM.Models.TRANGTHAI", "TRANGTHAI")
                        .WithMany("MAYTINHs")
                        .HasForeignKey("MATT");
                });
#pragma warning restore 612, 618
        }
    }
}