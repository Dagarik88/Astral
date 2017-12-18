﻿// <auto-generated />
using AstralNew.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AstralNew.DAL.Migrations
{
    [DbContext(typeof(AstralNewContext))]
    [Migration("20171217153950_AstralDb_1")]
    partial class AstralDb_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AstralNew.DAL.Models.Vacancy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Currency");

                    b.Property<string>("Employer");

                    b.Property<string>("Name");

                    b.Property<string>("Requirement");

                    b.Property<string>("Responsibility");

                    b.Property<decimal>("SalaryFrom");

                    b.Property<decimal>("SalaryTo");

                    b.HasKey("Id");

                    b.ToTable("Vacancy");
                });
#pragma warning restore 612, 618
        }
    }
}
