﻿// <auto-generated />
using System;
using Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infra.Migrations
{
    [DbContext(typeof(ClientContext))]
    partial class ClientContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Domain.ClientModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<long>("AccountCode")
                        .HasColumnType("bigint")
                        .HasColumnName("NUMERO_CONTA");

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasColumnName("ATIVO");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ENDERECO");

                    b.Property<int>("Age")
                        .HasColumnType("int")
                        .HasColumnName("IDADE");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CODIGO_POSTAL");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CIDADE");

                    b.Property<string>("Complement")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("COMPLEMENTO");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PAIS");

                    b.Property<int>("Gender")
                        .HasColumnType("int")
                        .HasColumnName("GENERO");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NOME");

                    b.Property<string>("Neighbourhood")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("BAIRRO");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NUMERO");

                    b.Property<int>("PersonType")
                        .HasColumnType("int")
                        .HasColumnName("TIPO_PESSOA");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UF");

                    b.HasKey("Id");

                    b.ToTable("CLIENTE");
                });
#pragma warning restore 612, 618
        }
    }
}
