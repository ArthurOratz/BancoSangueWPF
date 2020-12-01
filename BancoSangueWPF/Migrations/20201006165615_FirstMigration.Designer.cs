﻿// <auto-generated />
using System;
using BancoSangueWPF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BancoSangueWPF.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20201006165615_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BancoSangueWPF.Models.Coleta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DoadorId")
                        .HasColumnType("int");

                    b.Property<int?>("FuncionarioId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int?>("TipoSanguineoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DoadorId");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("TipoSanguineoId");

                    b.ToTable("Coleta");
                });

            modelBuilder.Entity("BancoSangueWPF.Models.Doador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Peso")
                        .HasColumnType("float");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TipoSanguineoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoSanguineoId");

                    b.ToTable("Doador");
                });

            modelBuilder.Entity("BancoSangueWPF.Models.EstoqueSangue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int?>("TipoSanguineoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoSanguineoId");

                    b.ToTable("EstoqueSangue");
                });

            modelBuilder.Entity("BancoSangueWPF.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("BancoSangueWPF.Models.Hospital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeResponsavel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hospital");
                });

            modelBuilder.Entity("BancoSangueWPF.Models.Retirada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HospitalId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int?>("TipoSanguineoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HospitalId");

                    b.HasIndex("TipoSanguineoId");

                    b.ToTable("Retirada");
                });

            modelBuilder.Entity("BancoSangueWPF.Models.TipoSanguineo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fator_RH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo_sanguineo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tipo_Sanguineo");
                });

            modelBuilder.Entity("BancoSangueWPF.Models.Coleta", b =>
                {
                    b.HasOne("BancoSangueWPF.Models.Doador", "Doador")
                        .WithMany("ListaColetas")
                        .HasForeignKey("DoadorId");

                    b.HasOne("BancoSangueWPF.Models.Funcionario", "Funcionario")
                        .WithMany("ListaColetas")
                        .HasForeignKey("FuncionarioId");

                    b.HasOne("BancoSangueWPF.Models.TipoSanguineo", "TipoSanguineo")
                        .WithMany()
                        .HasForeignKey("TipoSanguineoId");
                });

            modelBuilder.Entity("BancoSangueWPF.Models.Doador", b =>
                {
                    b.HasOne("BancoSangueWPF.Models.TipoSanguineo", "TipoSanguineo")
                        .WithMany()
                        .HasForeignKey("TipoSanguineoId");
                });

            modelBuilder.Entity("BancoSangueWPF.Models.EstoqueSangue", b =>
                {
                    b.HasOne("BancoSangueWPF.Models.TipoSanguineo", "TipoSanguineo")
                        .WithMany()
                        .HasForeignKey("TipoSanguineoId");
                });

            modelBuilder.Entity("BancoSangueWPF.Models.Retirada", b =>
                {
                    b.HasOne("BancoSangueWPF.Models.Hospital", "Hospital")
                        .WithMany("ListaRetiradas")
                        .HasForeignKey("HospitalId");

                    b.HasOne("BancoSangueWPF.Models.TipoSanguineo", "TipoSanguineo")
                        .WithMany()
                        .HasForeignKey("TipoSanguineoId");
                });
#pragma warning restore 612, 618
        }
    }
}
