﻿// <auto-generated />
using CoreDepartment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoreDepartment.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230409210236_deneme1")]
    partial class deneme1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CoreDepartment.Models.departments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("departmanAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("CoreDepartment.Models.personel", b =>
                {
                    b.Property<int>("perid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("perid"));

                    b.Property<string>("ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("departId")
                        .HasColumnType("int");

                    b.Property<string>("sehir")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("perid");

                    b.HasIndex("departId");

                    b.ToTable("personel");
                });

            modelBuilder.Entity("CoreDepartment.Models.personel", b =>
                {
                    b.HasOne("CoreDepartment.Models.departments", "depart")
                        .WithMany("personels")
                        .HasForeignKey("departId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("depart");
                });

            modelBuilder.Entity("CoreDepartment.Models.departments", b =>
                {
                    b.Navigation("personels");
                });
#pragma warning restore 612, 618
        }
    }
}
