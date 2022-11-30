﻿// <auto-generated />
using System;
using CEDPAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CEDPAPI.Migrations
{
    [DbContext(typeof(CEdpApiContext))]
    [Migration("20221130003918_InitialCreation")]
    partial class InitialCreation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CEDPAPI.Models.CourseEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Nome do Curso");

                    b.Property<string>("Requisite")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Requisitos");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Valor");

                    b.Property<int?>("Workload")
                        .HasMaxLength(150)
                        .HasColumnType("int")
                        .HasColumnName("Carga Horária");

                    b.HasKey("Id");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("CEDPAPI.Models.GradeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Data de Término");

                    b.Property<int>("IdCourse")
                        .HasColumnType("int")
                        .HasColumnName("Id do Curso");

                    b.Property<int>("IdInstructor")
                        .HasColumnType("int")
                        .HasColumnName("Id do Instrutor");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Data de Início");

                    b.Property<int?>("Workload")
                        .HasColumnType("int")
                        .HasColumnName("Carga Horária");

                    b.HasKey("Id");

                    b.HasIndex("IdCourse");

                    b.HasIndex("IdInstructor");

                    b.ToTable("Turmos");
                });

            modelBuilder.Entity("CEDPAPI.Models.InstructorEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Certificate")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Certificados");

                    b.Property<decimal>("CostTime")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Valor por hora");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("E-mail");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Nome");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Instrutores");
                });

            modelBuilder.Entity("CEDPAPI.Models.RegistrationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdGrade")
                        .HasColumnType("int")
                        .HasColumnName("Id da Turma");

                    b.Property<int>("IdStudent")
                        .HasColumnType("int")
                        .HasColumnName("Id do Estudante");

                    b.Property<DateTime?>("RegisterDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Data de Matrícula");

                    b.HasKey("Id");

                    b.ToTable("Matrículas");
                });

            modelBuilder.Entity("CEDPAPI.Models.StudentEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Birthdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("Data de nascimento");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("CPF");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("E-mail");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Cliente");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)")
                        .HasColumnName("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("CEDPAPI.Models.GradeEntity", b =>
                {
                    b.HasOne("CEDPAPI.Models.CourseEntity", "CourseEntity")
                        .WithMany()
                        .HasForeignKey("IdCourse")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CEDPAPI.Models.InstructorEntity", "InstructorEntity")
                        .WithMany()
                        .HasForeignKey("IdInstructor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseEntity");

                    b.Navigation("InstructorEntity");
                });
#pragma warning restore 612, 618
        }
    }
}