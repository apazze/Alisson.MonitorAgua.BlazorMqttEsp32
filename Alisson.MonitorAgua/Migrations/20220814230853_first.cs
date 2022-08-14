using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Alisson.MonitorAgua.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Regras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sensors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSensor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
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
                table: "Regras",
                columns: new[] { "Id", "TimeStamp", "Valor" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 8, 14, 20, 8, 53, 196, DateTimeKind.Local).AddTicks(1273), "150" },
                    { 2, new DateTime(2022, 8, 14, 20, 8, 53, 197, DateTimeKind.Local).AddTicks(1264), "170" }
                });

            migrationBuilder.InsertData(
                table: "Sensors",
                columns: new[] { "Id", "NameSensor", "Type", "Unit", "Value" },
                values: new object[,]
                {
                    { 1, "Vazao", "Encoder", "L", 6.0499999999999998 },
                    { 2, "Vazao", "Encoder", "L", 7.2999999999999998 },
                    { 3, "Vazao", "Encoder", "L", 12.800000000000001 }
                });

            migrationBuilder.InsertData(
                table: "Datas",
                columns: new[] { "Id", "ClientId", "MessageId", "Payload", "QoS", "RetainFlag", "SensorId", "TimeStamp", "Topic" },
                values: new object[] { 1, "clientId seed 1", 1, "payload seed 1", "qos seed 1", true, 1, new DateTime(2022, 1, 1, 23, 59, 59, 0, DateTimeKind.Unspecified), "topic seed 1" });

            migrationBuilder.InsertData(
                table: "Datas",
                columns: new[] { "Id", "ClientId", "MessageId", "Payload", "QoS", "RetainFlag", "SensorId", "TimeStamp", "Topic" },
                values: new object[] { 2, "clientId seed 2", 2, "payload seed 2", "qos seed 2", true, 2, new DateTime(2022, 1, 2, 23, 59, 59, 0, DateTimeKind.Unspecified), "topic seed 2" });

            migrationBuilder.InsertData(
                table: "Datas",
                columns: new[] { "Id", "ClientId", "MessageId", "Payload", "QoS", "RetainFlag", "SensorId", "TimeStamp", "Topic" },
                values: new object[] { 3, "clientId seed 3", 3, "payload seed 3", "qos seed 3", true, 3, new DateTime(2022, 1, 3, 23, 59, 59, 0, DateTimeKind.Unspecified), "topic seed 3" });

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
                name: "Regras");

            migrationBuilder.DropTable(
                name: "Sensors");
        }
    }
}
