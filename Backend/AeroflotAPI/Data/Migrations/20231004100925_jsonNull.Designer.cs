﻿// <auto-generated />
using System;
using AeroflotAPI.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AeroflotAPI.Data.Migrations
{
    [DbContext(typeof(ReportContext))]
    [Migration("20231004100925_jsonNull")]
    partial class jsonNull
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AeroflotAPI.Models.ReportZone", b =>
                {
                    b.Property<int>("IdReportZone")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdReportZone"));

                    b.Property<string>("BadEquipJson")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("DateTimeFinishGroup")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("DateTimeStartGroup")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("IdPlane")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IdZone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ZoneName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdReportZone");

                    b.HasIndex("IdReportZone")
                        .IsUnique();

                    b.ToTable("ReportZones");
                });
#pragma warning restore 612, 618
        }
    }
}
