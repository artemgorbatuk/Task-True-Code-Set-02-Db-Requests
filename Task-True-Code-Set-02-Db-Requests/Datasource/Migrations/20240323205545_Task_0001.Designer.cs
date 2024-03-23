﻿// <auto-generated />
using System;
using Datasource.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Datasource.Migrations
{
    [DbContext(typeof(DbContextTrueCode))]
    [Migration("20240323205545_Task_0001")]
    partial class Task_0001
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dto")
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Datasource.Domain.Tag", b =>
                {
                    b.Property<Guid>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Domain")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagId");

                    b.ToTable("Tags", "dto");
                });

            modelBuilder.Entity("Datasource.Domain.TagToUser", b =>
                {
                    b.Property<Guid>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EntityId");

                    b.HasIndex("TagId");

                    b.HasIndex("UserId");

                    b.ToTable("TagToUser", "dto");
                });

            modelBuilder.Entity("Datasource.Domain.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Domain")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users", "dto");
                });

            modelBuilder.Entity("Datasource.Domain.TagToUser", b =>
                {
                    b.HasOne("Datasource.Domain.Tag", "Tag")
                        .WithMany("TagToUsers")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Datasource.Domain.User", "User")
                        .WithMany("TagToUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tag");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Datasource.Domain.Tag", b =>
                {
                    b.Navigation("TagToUsers");
                });

            modelBuilder.Entity("Datasource.Domain.User", b =>
                {
                    b.Navigation("TagToUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
