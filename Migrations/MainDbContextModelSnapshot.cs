﻿// <auto-generated />
using System;
using GridSample.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GridSample.Migrations
{
    [DbContext(typeof(MainDbContext))]
    partial class MainDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GridSample.Data.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SerialNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("GridSample.Data.TestList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnName("Category Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentlyPerforming")
                        .IsRequired()
                        .HasColumnName("Currently Performing")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TestId")
                        .HasColumnName("Test ID")
                        .HasColumnType("int");

                    b.Property<string>("TestName")
                        .IsRequired()
                        .HasColumnName("Test Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TestPrice")
                        .HasColumnName("Test Price")
                        .HasColumnType("float");

                    b.Property<string>("TestShortName")
                        .IsRequired()
                        .HasColumnName("Test Short Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TestLists");
                });

            modelBuilder.Entity("GridSample.Data.TestListDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("TestNormalValue")
                        .HasColumnName("Test Normal Value")
                        .HasColumnType("real");

                    b.Property<bool>("TestParameter")
                        .HasColumnName("Test Parameter")
                        .HasColumnType("bit");

                    b.Property<float>("TestUnit")
                        .HasColumnName("Test Unit")
                        .HasColumnType("real");

                    b.Property<DateTime>("ValidationDate")
                        .HasColumnName("Validation Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TestListDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
