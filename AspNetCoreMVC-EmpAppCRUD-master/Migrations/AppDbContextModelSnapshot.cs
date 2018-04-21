﻿// <auto-generated />
using EmpApp.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace EmpApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmpApp.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Designation");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmpApp.Models.Leave", b =>
                {
                    b.Property<int>("LeaveId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApprovalStatus");

                    b.Property<int?>("EmployeeId");

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("LeaveId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Leaves");
                });

            modelBuilder.Entity("EmpApp.Models.Leave", b =>
                {
                    b.HasOne("EmpApp.Models.Employee")
                        .WithMany("Leaves")
                        .HasForeignKey("EmployeeId");
                });
#pragma warning restore 612, 618
        }
    }
}