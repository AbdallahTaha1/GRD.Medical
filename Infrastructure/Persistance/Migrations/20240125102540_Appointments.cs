﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Appointments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DateTimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    TimeSlotId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_TimeSlots_TimeSlotId",
                        column: x => x.TimeSlotId,
                        principalTable: "TimeSlots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Users_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointments_Users_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_TimeSlotId",
                table: "Appointments",
                column: "TimeSlotId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");
        }
    }
}
