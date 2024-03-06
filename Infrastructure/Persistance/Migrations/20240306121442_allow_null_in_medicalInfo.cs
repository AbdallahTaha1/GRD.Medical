using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class allow_null_in_medicalInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalInfos_Users_UserId",
                table: "MedicalInfos");

            migrationBuilder.AlterColumn<float>(
                name: "Wight",
                table: "MedicalInfos",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "MedicalInfos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "Smoker",
                table: "MedicalInfos",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "Hypotension",
                table: "MedicalInfos",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "Hypertension",
                table: "MedicalInfos",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<float>(
                name: "Hight",
                table: "MedicalInfos",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<bool>(
                name: "Diabetic",
                table: "MedicalInfos",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "MedicalInfos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Advices",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedOn",
                value: new DateTime(2021, 11, 28, 12, 14, 42, 228, DateTimeKind.Utc).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Advices",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedOn",
                value: new DateTime(2021, 12, 6, 12, 14, 42, 228, DateTimeKind.Utc).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "Advices",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedOn",
                value: new DateTime(2024, 2, 25, 12, 14, 42, 228, DateTimeKind.Utc).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "Advices",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishedOn",
                value: new DateTime(2021, 9, 10, 12, 14, 42, 228, DateTimeKind.Utc).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "Advices",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishedOn",
                value: new DateTime(2021, 10, 21, 12, 14, 42, 228, DateTimeKind.Utc).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "Advices",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishedOn",
                value: new DateTime(2023, 7, 15, 12, 14, 42, 228, DateTimeKind.Utc).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "Advices",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishedOn",
                value: new DateTime(2023, 2, 22, 12, 14, 42, 228, DateTimeKind.Utc).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Advices",
                keyColumn: "Id",
                keyValue: 8,
                column: "PublishedOn",
                value: new DateTime(2021, 11, 11, 12, 14, 42, 228, DateTimeKind.Utc).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "Advices",
                keyColumn: "Id",
                keyValue: 9,
                column: "PublishedOn",
                value: new DateTime(2024, 2, 23, 12, 14, 42, 229, DateTimeKind.Utc).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "Advices",
                keyColumn: "Id",
                keyValue: 10,
                column: "PublishedOn",
                value: new DateTime(2021, 7, 20, 12, 14, 42, 229, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Advices",
                keyColumn: "Id",
                keyValue: 11,
                column: "PublishedOn",
                value: new DateTime(2022, 1, 11, 12, 14, 42, 229, DateTimeKind.Utc).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Advices",
                keyColumn: "Id",
                keyValue: 12,
                column: "PublishedOn",
                value: new DateTime(2024, 1, 18, 12, 14, 42, 229, DateTimeKind.Utc).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedOn",
                value: new DateTime(2023, 12, 13, 12, 14, 42, 227, DateTimeKind.Utc).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedOn",
                value: new DateTime(2023, 3, 4, 12, 14, 42, 227, DateTimeKind.Utc).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 26, 12, 14, 42, 227, DateTimeKind.Utc).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishedOn",
                value: new DateTime(2024, 2, 28, 12, 14, 42, 228, DateTimeKind.Utc).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishedOn",
                value: new DateTime(2023, 4, 7, 12, 14, 42, 228, DateTimeKind.Utc).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishedOn",
                value: new DateTime(2021, 3, 11, 12, 14, 42, 228, DateTimeKind.Utc).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishedOn",
                value: new DateTime(2023, 9, 6, 12, 14, 42, 228, DateTimeKind.Utc).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "PublishedOn",
                value: new DateTime(2021, 5, 6, 12, 14, 42, 228, DateTimeKind.Utc).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "PublishedOn",
                value: new DateTime(2022, 6, 5, 12, 14, 42, 228, DateTimeKind.Utc).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "PublishedOn",
                value: new DateTime(2024, 2, 7, 12, 14, 42, 228, DateTimeKind.Utc).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11,
                column: "PublishedOn",
                value: new DateTime(2022, 8, 15, 12, 14, 42, 228, DateTimeKind.Utc).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 12,
                column: "PublishedOn",
                value: new DateTime(2023, 3, 22, 12, 14, 42, 228, DateTimeKind.Utc).AddTicks(4085));

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalInfos_Users_UserId",
                table: "MedicalInfos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalInfos_Users_UserId",
                table: "MedicalInfos");

            migrationBuilder.AlterColumn<float>(
                name: "Wight",
                table: "MedicalInfos",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "MedicalInfos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Smoker",
                table: "MedicalInfos",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Hypotension",
                table: "MedicalInfos",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Hypertension",
                table: "MedicalInfos",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Hight",
                table: "MedicalInfos",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Diabetic",
                table: "MedicalInfos",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "MedicalInfos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Advices",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedOn",
                value: new DateTime(2022, 11, 14, 11, 40, 5, 342, DateTimeKind.Utc).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "Advices",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 10, 11, 40, 5, 342, DateTimeKind.Utc).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Advices",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedOn",
                value: new DateTime(2023, 8, 21, 11, 40, 5, 342, DateTimeKind.Utc).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "Advices",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishedOn",
                value: new DateTime(2022, 2, 26, 11, 40, 5, 342, DateTimeKind.Utc).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "Advices",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishedOn",
                value: new DateTime(2024, 2, 14, 11, 40, 5, 342, DateTimeKind.Utc).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "Advices",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishedOn",
                value: new DateTime(2021, 9, 29, 11, 40, 5, 342, DateTimeKind.Utc).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Advices",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishedOn",
                value: new DateTime(2021, 8, 12, 11, 40, 5, 342, DateTimeKind.Utc).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "Advices",
                keyColumn: "Id",
                keyValue: 8,
                column: "PublishedOn",
                value: new DateTime(2022, 10, 29, 11, 40, 5, 342, DateTimeKind.Utc).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "Advices",
                keyColumn: "Id",
                keyValue: 9,
                column: "PublishedOn",
                value: new DateTime(2024, 1, 5, 11, 40, 5, 342, DateTimeKind.Utc).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "Advices",
                keyColumn: "Id",
                keyValue: 10,
                column: "PublishedOn",
                value: new DateTime(2022, 11, 26, 11, 40, 5, 342, DateTimeKind.Utc).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "Advices",
                keyColumn: "Id",
                keyValue: 11,
                column: "PublishedOn",
                value: new DateTime(2022, 10, 10, 11, 40, 5, 342, DateTimeKind.Utc).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Advices",
                keyColumn: "Id",
                keyValue: 12,
                column: "PublishedOn",
                value: new DateTime(2023, 1, 14, 11, 40, 5, 342, DateTimeKind.Utc).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishedOn",
                value: new DateTime(2022, 11, 10, 11, 40, 5, 341, DateTimeKind.Utc).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishedOn",
                value: new DateTime(2023, 1, 14, 11, 40, 5, 341, DateTimeKind.Utc).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishedOn",
                value: new DateTime(2021, 11, 25, 11, 40, 5, 341, DateTimeKind.Utc).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishedOn",
                value: new DateTime(2023, 12, 21, 11, 40, 5, 341, DateTimeKind.Utc).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "PublishedOn",
                value: new DateTime(2021, 4, 7, 11, 40, 5, 341, DateTimeKind.Utc).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "PublishedOn",
                value: new DateTime(2023, 3, 24, 11, 40, 5, 341, DateTimeKind.Utc).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "PublishedOn",
                value: new DateTime(2022, 10, 10, 11, 40, 5, 341, DateTimeKind.Utc).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "PublishedOn",
                value: new DateTime(2021, 9, 5, 11, 40, 5, 341, DateTimeKind.Utc).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "PublishedOn",
                value: new DateTime(2023, 10, 19, 11, 40, 5, 341, DateTimeKind.Utc).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "PublishedOn",
                value: new DateTime(2024, 2, 21, 11, 40, 5, 341, DateTimeKind.Utc).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11,
                column: "PublishedOn",
                value: new DateTime(2022, 12, 2, 11, 40, 5, 341, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 12,
                column: "PublishedOn",
                value: new DateTime(2023, 5, 19, 11, 40, 5, 341, DateTimeKind.Utc).AddTicks(9633));

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalInfos_Users_UserId",
                table: "MedicalInfos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
