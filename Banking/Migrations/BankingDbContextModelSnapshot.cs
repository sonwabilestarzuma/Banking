﻿// <auto-generated />
using System;
using Banking.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Banking.Migrations
{
    [DbContext(typeof(BankingDbContext))]
    partial class BankingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Banking.Models.BankDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AccountNumber");

                    b.Property<int>("BranchCode");

                    b.Property<string>("DrCrIndicator");

                    b.Property<DateTime>("EffectiveDate");

                    b.Property<string>("Identifier");

                    b.Property<string>("ReferenceNumber");

                    b.Property<string>("StandardBank");

                    b.Property<double>("TransactionAmount");

                    b.Property<int>("TransactionCode");

                    b.Property<DateTime>("TransactionDate");

                    b.Property<DateTime>("TransactionTime");

                    b.HasKey("Id");

                    b.ToTable("BankDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
