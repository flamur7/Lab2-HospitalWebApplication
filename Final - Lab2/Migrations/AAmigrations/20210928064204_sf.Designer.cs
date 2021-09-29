﻿// <auto-generated />
using System;
using Final___Lab2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Final___Lab2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210928064204_sf")]
    partial class sf
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Final___Lab2.Models.Analizat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Emri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KategoriaAnalizaveId")
                        .HasColumnType("int");

                    b.Property<string>("Pershkerimi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KategoriaAnalizaveId");

                    b.ToTable("Analizats");
                });

            modelBuilder.Entity("Final___Lab2.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("AppointmentId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Final___Lab2.Models.Detajet", b =>
                {
                    b.Property<int>("DetajetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Arsyja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FeedBackId")
                        .HasColumnType("int");

                    b.Property<string>("Sherbimet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Vlersimi")
                        .HasColumnType("smallint");

                    b.HasKey("DetajetId");

                    b.HasIndex("FeedBackId");

                    b.ToTable("Detajets");
                });

            modelBuilder.Entity("Final___Lab2.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Mbiemri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NrPersonal")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Specalizimi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DoctorId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("Final___Lab2.Models.Faktura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Completed")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NrPersonal")
                        .HasColumnType("int");

                    b.Property<int>("PagesaId")
                        .HasColumnType("int");

                    b.Property<int>("Shuma")
                        .HasColumnType("int");

                    b.Property<string>("Valuta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fakturas");
                });

            modelBuilder.Entity("Final___Lab2.Models.FeedBack", b =>
                {
                    b.Property<int>("FeedBackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Field")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FeedBackId");

                    b.ToTable("FeedBacks");
                });

            modelBuilder.Entity("Final___Lab2.Models.KategoriaAnalizave", b =>
                {
                    b.Property<int>("KategoriaAnalizaveId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Lloji")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rendesia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategoriaAnalizaveId");

                    b.ToTable("KategoriaAnalizaves");
                });

            modelBuilder.Entity("Final___Lab2.Models.KontrollaMjeksore", b =>
                {
                    b.Property<int>("KontrollaMjesoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("Pershkrimi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TerapiId")
                        .HasColumnType("int");

                    b.HasKey("KontrollaMjesoreId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("TerapiId");

                    b.ToTable("KontrollaMjeksores");
                });

            modelBuilder.Entity("Final___Lab2.Models.Nurse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Analizat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Mbiemri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NrPersonal")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int?>("OrariPuneId")
                        .HasColumnType("int");

                    b.Property<string>("OrariPushimit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profesioni")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrariPuneId");

                    b.ToTable("Nurses");
                });

            modelBuilder.Entity("Final___Lab2.Models.OrariPune", b =>
                {
                    b.Property<int>("OrariPuneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Dita")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Java")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Koha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TechnicalId")
                        .HasColumnType("int");

                    b.HasKey("OrariPuneId");

                    b.HasIndex("TechnicalId");

                    b.ToTable("OrariPunes");
                });

            modelBuilder.Entity("Final___Lab2.Models.Pacient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnalizatId")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int?>("KontrollaMjeksoreKontrollaMjesoreId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NrPersonal")
                        .HasColumnType("int");

                    b.Property<int?>("PagesaId")
                        .HasColumnType("int");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AnalizatId");

                    b.HasIndex("KontrollaMjeksoreKontrollaMjesoreId");

                    b.HasIndex("PagesaId");

                    b.ToTable("Pacients");
                });

            modelBuilder.Entity("Final___Lab2.Models.Pagesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CardHolder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CardNumber")
                        .HasColumnType("int");

                    b.Property<bool>("Confirmation")
                        .HasColumnType("bit");

                    b.Property<int?>("ReceptionistId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReceptionistId");

                    b.ToTable("Pagesas");
                });

            modelBuilder.Entity("Final___Lab2.Models.Receptionist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Mbiemri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NrPersonal")
                        .HasColumnType("int");

                    b.Property<int>("NrTermineve")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int?>("OrariPuneId")
                        .HasColumnType("int");

                    b.Property<string>("OrariPushimit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profesioni")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrariPuneId");

                    b.ToTable("Receptionists");
                });

            modelBuilder.Entity("Final___Lab2.Models.Technical", b =>
                {
                    b.Property<int>("TechnicalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Emri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Mbiemri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NrPersonal")
                        .HasColumnType("int");

                    b.Property<string>("Pervoja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shkollimi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TechnicalId");

                    b.ToTable("Technicals");
                });

            modelBuilder.Entity("Final___Lab2.Models.Terapi", b =>
                {
                    b.Property<int>("TerapiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Barnat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kohezgjatja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PacientiId")
                        .HasColumnType("int");

                    b.Property<string>("Semundje")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TerapiId");

                    b.HasIndex("PacientiId");

                    b.ToTable("Terapis");
                });

            modelBuilder.Entity("Final___Lab2.Models.Analizat", b =>
                {
                    b.HasOne("Final___Lab2.Models.KategoriaAnalizave", "KategoriaAnalizave")
                        .WithMany("Analizats")
                        .HasForeignKey("KategoriaAnalizaveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Final___Lab2.Models.Appointment", b =>
                {
                    b.HasOne("Final___Lab2.Models.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Final___Lab2.Models.Detajet", b =>
                {
                    b.HasOne("Final___Lab2.Models.FeedBack", "FeedBack")
                        .WithMany("Detajets")
                        .HasForeignKey("FeedBackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Final___Lab2.Models.KontrollaMjeksore", b =>
                {
                    b.HasOne("Final___Lab2.Models.Doctor", "Doctor")
                        .WithMany("KontrollaMjeksores")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Final___Lab2.Models.Terapi", "Terapi")
                        .WithMany("KontrollaMjeksores")
                        .HasForeignKey("TerapiId");
                });

            modelBuilder.Entity("Final___Lab2.Models.Nurse", b =>
                {
                    b.HasOne("Final___Lab2.Models.OrariPune", null)
                        .WithMany("Nurses")
                        .HasForeignKey("OrariPuneId");
                });

            modelBuilder.Entity("Final___Lab2.Models.OrariPune", b =>
                {
                    b.HasOne("Final___Lab2.Models.Technical", "Technical")
                        .WithMany("OrariPunes")
                        .HasForeignKey("TechnicalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Final___Lab2.Models.Pacient", b =>
                {
                    b.HasOne("Final___Lab2.Models.Analizat", "Analizat")
                        .WithMany()
                        .HasForeignKey("AnalizatId");

                    b.HasOne("Final___Lab2.Models.KontrollaMjeksore", "KontrollaMjeksore")
                        .WithMany()
                        .HasForeignKey("KontrollaMjeksoreKontrollaMjesoreId");

                    b.HasOne("Final___Lab2.Models.Pagesa", "Pagesa")
                        .WithMany()
                        .HasForeignKey("PagesaId");
                });

            modelBuilder.Entity("Final___Lab2.Models.Pagesa", b =>
                {
                    b.HasOne("Final___Lab2.Models.Receptionist", null)
                        .WithMany("Pagesas")
                        .HasForeignKey("ReceptionistId");
                });

            modelBuilder.Entity("Final___Lab2.Models.Receptionist", b =>
                {
                    b.HasOne("Final___Lab2.Models.OrariPune", null)
                        .WithMany("Receptionists")
                        .HasForeignKey("OrariPuneId");
                });

            modelBuilder.Entity("Final___Lab2.Models.Terapi", b =>
                {
                    b.HasOne("Final___Lab2.Models.Pacient", "Pacient")
                        .WithMany("Terapis")
                        .HasForeignKey("PacientiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
