﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alisson.MonitorAgua.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sensors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSensor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Datas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SensorId = table.Column<int>(type: "int", nullable: false),
                    MessageId = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Topic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Payload = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QoS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RetainFlag = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Datas_Sensors_SensorId",
                        column: x => x.SensorId,
                        principalTable: "Sensors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Sensors",
                columns: new[] { "Id", "NameSensor", "Type", "Unit", "Value" },
                values: new object[] { 1, "Temperatura", "DHT11", "C", "23.05" });

            migrationBuilder.InsertData(
                table: "Sensors",
                columns: new[] { "Id", "NameSensor", "Type", "Unit", "Value" },
                values: new object[] { 2, "Temperatura", "DHT11", "C", "27.3" });

            migrationBuilder.InsertData(
                table: "Datas",
                columns: new[] { "Id", "ClientId", "MessageId", "Payload", "QoS", "RetainFlag", "SensorId", "TimeStamp", "Topic" },
                values: new object[] { 1, "clientId seed 1", 1, "payload seed 1", "qos seed 1", true, 1, new DateTime(2022, 4, 4, 9, 31, 9, 450, DateTimeKind.Local).AddTicks(4686), "topic seed 1" });

            migrationBuilder.InsertData(
                table: "Datas",
                columns: new[] { "Id", "ClientId", "MessageId", "Payload", "QoS", "RetainFlag", "SensorId", "TimeStamp", "Topic" },
                values: new object[] { 2, "clientId seed 2", 2, "payload seed 2", "qos seed 2", true, 1, new DateTime(2022, 4, 4, 9, 31, 9, 450, DateTimeKind.Local).AddTicks(4697), "topic seed 2" });

            migrationBuilder.CreateIndex(
                name: "IX_Datas_SensorId",
                table: "Datas",
                column: "SensorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Datas");

            migrationBuilder.DropTable(
                name: "Sensors");
        }
    }
}