﻿// <auto-generated />
using System;
using Alisson.MonitorAgua;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Alisson.MonitorAgua.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Alisson.MonitorAgua.Data", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MessageId")
                        .HasColumnType("int");

                    b.Property<string>("Payload")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QoS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("RetainFlag")
                        .HasColumnType("bit");

                    b.Property<int>("SensorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SensorId");

                    b.ToTable("Datas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClientId = "clientId seed 1",
                            MessageId = 1,
                            Payload = "payload seed 1",
                            QoS = "qos seed 1",
                            RetainFlag = true,
                            SensorId = 1,
                            TimeStamp = new DateTime(2022, 4, 4, 9, 31, 9, 450, DateTimeKind.Local).AddTicks(4686),
                            Topic = "topic seed 1"
                        },
                        new
                        {
                            Id = 2,
                            ClientId = "clientId seed 2",
                            MessageId = 2,
                            Payload = "payload seed 2",
                            QoS = "qos seed 2",
                            RetainFlag = true,
                            SensorId = 1,
                            TimeStamp = new DateTime(2022, 4, 4, 9, 31, 9, 450, DateTimeKind.Local).AddTicks(4697),
                            Topic = "topic seed 2"
                        });
                });

            modelBuilder.Entity("Alisson.MonitorAgua.Sensor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NameSensor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sensors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NameSensor = "Temperatura",
                            Type = "DHT11",
                            Unit = "C",
                            Value = "23.05"
                        },
                        new
                        {
                            Id = 2,
                            NameSensor = "Temperatura",
                            Type = "DHT11",
                            Unit = "C",
                            Value = "27.3"
                        });
                });

            modelBuilder.Entity("Alisson.MonitorAgua.Data", b =>
                {
                    b.HasOne("Alisson.MonitorAgua.Sensor", "Sensor")
                        .WithMany()
                        .HasForeignKey("SensorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sensor");
                });
#pragma warning restore 612, 618
        }
    }
}
