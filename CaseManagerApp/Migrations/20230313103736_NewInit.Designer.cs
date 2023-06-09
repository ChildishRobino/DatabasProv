﻿// <auto-generated />
using System;
using CaseManagerApp.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CaseManagerApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230313103736_NewInit")]
    partial class NewInit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CaseManagerApp.MVVM.Models.CaseCommentEntity", b =>
                {
                    b.Property<int>("CaseCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CaseCommentId"));

                    b.Property<int>("CaseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Posted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CaseCommentId");

                    b.HasIndex("CaseId");

                    b.ToTable("CaseComments");
                });

            modelBuilder.Entity("CaseManagerApp.MVVM.Models.CaseEntity", b =>
                {
                    b.Property<int>("CaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CaseId"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("CaseId");

                    b.HasIndex("TenantId");

                    b.ToTable("Cases");
                });

            modelBuilder.Entity("CaseManagerApp.MVVM.Models.Entities.AddressEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("char(6)");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("CaseManagerApp.MVVM.Models.TenantEntity", b =>
                {
                    b.Property<int>("TenantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TenantId"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("char(13)");

                    b.HasKey("TenantId");

                    b.HasIndex("AddressId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("CaseManagerApp.MVVM.Models.CaseCommentEntity", b =>
                {
                    b.HasOne("CaseManagerApp.MVVM.Models.CaseEntity", "Case")
                        .WithMany("Comments")
                        .HasForeignKey("CaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Case");
                });

            modelBuilder.Entity("CaseManagerApp.MVVM.Models.CaseEntity", b =>
                {
                    b.HasOne("CaseManagerApp.MVVM.Models.TenantEntity", "Tenant")
                        .WithMany("Cases")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("CaseManagerApp.MVVM.Models.TenantEntity", b =>
                {
                    b.HasOne("CaseManagerApp.MVVM.Models.Entities.AddressEntity", "Address")
                        .WithMany("Tenants")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("CaseManagerApp.MVVM.Models.CaseEntity", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("CaseManagerApp.MVVM.Models.Entities.AddressEntity", b =>
                {
                    b.Navigation("Tenants");
                });

            modelBuilder.Entity("CaseManagerApp.MVVM.Models.TenantEntity", b =>
                {
                    b.Navigation("Cases");
                });
#pragma warning restore 612, 618
        }
    }
}
