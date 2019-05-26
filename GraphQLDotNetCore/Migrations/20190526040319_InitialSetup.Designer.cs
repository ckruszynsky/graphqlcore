﻿// <auto-generated />
using System;
using GraphQLDotNetCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GraphQLDotNetCore.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20190526040319_InitialSetup")]
    partial class InitialSetup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GraphQLDotNetCore.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<Guid>("OwnerId");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4f54c953-fdcf-46fb-a54c-92d09f0fd110"),
                            Description = "Cash account for our users",
                            OwnerId = new Guid("69ca07a7-f07b-459e-9390-ec4fe5b9b284"),
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("34bc7191-5622-466a-9373-2a9f7486c9ec"),
                            Description = "Savings account for our users",
                            OwnerId = new Guid("69ebe912-61dc-4caf-95fc-765ec5e3ef72"),
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("20bff8ae-2620-48ca-a2bb-bc71fd4235af"),
                            Description = "Income account for our users",
                            OwnerId = new Guid("69ebe912-61dc-4caf-95fc-765ec5e3ef72"),
                            Type = 3
                        });
                });

            modelBuilder.Entity("GraphQLDotNetCore.Entities.Owner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            Id = new Guid("69ca07a7-f07b-459e-9390-ec4fe5b9b284"),
                            Address = "John Doe's address",
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = new Guid("69ebe912-61dc-4caf-95fc-765ec5e3ef72"),
                            Address = "Jane Doe's address",
                            Name = "Jane Doe"
                        });
                });

            modelBuilder.Entity("GraphQLDotNetCore.Entities.Account", b =>
                {
                    b.HasOne("GraphQLDotNetCore.Entities.Owner", "Owner")
                        .WithMany("Accounts")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
