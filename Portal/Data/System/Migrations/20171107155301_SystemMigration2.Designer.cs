﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Portal.Data.System;
using System;

namespace Portal.Data.System.Migrations
{
    [DbContext(typeof(SystemContext))]
    [Migration("20171107155301_SystemMigration2")]
    partial class SystemMigration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("system")
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Portal.Domain.System.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Portal.Domain.System.Entities.RoleEnrolment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("RoleId");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("RoleEnrolments");
                });

            modelBuilder.Entity("Portal.Domain.System.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("PasswordHash");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Portal.Domain.System.Entities.RoleEnrolment", b =>
                {
                    b.HasOne("Portal.Domain.System.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("Portal.Domain.System.Entities.User")
                        .WithMany("RoleEnrolments")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}