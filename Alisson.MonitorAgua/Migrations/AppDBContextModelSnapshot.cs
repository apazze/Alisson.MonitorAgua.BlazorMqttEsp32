﻿// <auto-generated />
using System;
using Alisson.MonitorAgua;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Alisson.MonitorAgua.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Alisson.MonitorAgua.Data", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                            TimeStamp = new DateTime(2022, 1, 1, 23, 59, 59, 0, DateTimeKind.Unspecified),
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
                            SensorId = 2,
                            TimeStamp = new DateTime(2022, 1, 2, 23, 59, 59, 0, DateTimeKind.Unspecified),
                            Topic = "topic seed 2"
                        },
                        new
                        {
                            Id = 3,
                            ClientId = "clientId seed 3",
                            MessageId = 3,
                            Payload = "payload seed 3",
                            QoS = "qos seed 3",
                            RetainFlag = true,
                            SensorId = 3,
                            TimeStamp = new DateTime(2022, 1, 3, 23, 59, 59, 0, DateTimeKind.Unspecified),
                            Topic = "topic seed 3"
                        });
                });

            modelBuilder.Entity("Alisson.MonitorAgua.Regra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Valor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Regras");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TimeStamp = new DateTime(2022, 11, 26, 16, 56, 49, 90, DateTimeKind.Local).AddTicks(3499),
                            Valor = "150"
                        },
                        new
                        {
                            Id = 2,
                            TimeStamp = new DateTime(2022, 11, 26, 16, 56, 49, 91, DateTimeKind.Local).AddTicks(7232),
                            Valor = "170"
                        });
                });

            modelBuilder.Entity("Alisson.MonitorAgua.Sensor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameSensor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Sensors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NameSensor = "Vazao",
                            Type = "Encoder",
                            Unit = "L",
                            Value = 6.0499999999999998
                        },
                        new
                        {
                            Id = 2,
                            NameSensor = "Vazao",
                            Type = "Encoder",
                            Unit = "L",
                            Value = 7.2999999999999998
                        },
                        new
                        {
                            Id = 3,
                            NameSensor = "Vazao",
                            Type = "Encoder",
                            Unit = "L",
                            Value = 12.800000000000001
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
