﻿// <auto-generated />
using System;
using ClubGolf.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClubGolf.Migrations
{
    [DbContext(typeof(ClubContext))]
    [Migration("20220908071807_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClubGolf.Models.Membership", b =>
                {
                    b.Property<int>("MembershipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MembershipId"), 1L, 1);

                    b.Property<decimal>("AnnualCost")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Balance")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("MembershipActive")
                        .HasColumnType("bit");

                    b.Property<int>("MembershipTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("MonthlyCost")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("MembershipId");

                    b.HasIndex("MembershipTypeId");

                    b.HasIndex("PersonId");

                    b.ToTable("Memberships");
                });

            modelBuilder.Entity("ClubGolf.Models.MembershipType", b =>
                {
                    b.Property<int>("MembershipTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MembershipTypeId"), 1L, 1);

                    b.Property<decimal?>("AnnualCost")
                        .IsRequired()
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MembershipTypeId");

                    b.ToTable("MembershipTypes");
                });

            modelBuilder.Entity("ClubGolf.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"), 1L, 1);

                    b.Property<DateTime>("DateJoined")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("ClubGolf.Models.Membership", b =>
                {
                    b.HasOne("ClubGolf.Models.MembershipType", "MembershipType")
                        .WithMany("Memberships")
                        .HasForeignKey("MembershipTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClubGolf.Models.Person", "Person")
                        .WithMany("Memberships")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MembershipType");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("ClubGolf.Models.MembershipType", b =>
                {
                    b.Navigation("Memberships");
                });

            modelBuilder.Entity("ClubGolf.Models.Person", b =>
                {
                    b.Navigation("Memberships");
                });
#pragma warning restore 612, 618
        }
    }
}
