﻿// <auto-generated />
using LitWebSite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LitWebSite.Migrations
{
    [DbContext(typeof(SensorDBContext))]
    [Migration("20190311091906_sensors-mig-1")]
    partial class sensorsmig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LitWebSite.Models.Sensors", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CO");

                    b.Property<double>("CO2");

                    b.Property<double>("NO2");

                    b.Property<double>("PM25");

                    b.HasKey("Id");

                    b.ToTable("SensorsData");
                });
#pragma warning restore 612, 618
        }
    }
}
