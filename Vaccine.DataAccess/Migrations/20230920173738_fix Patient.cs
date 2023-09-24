using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vaccine.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class fixPatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Vaccines_VaccineId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_VaccineId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "VaccinationDate",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "VaccineId",
                table: "Patients");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "VaccinationDate",
                table: "Patients",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "VaccineId",
                table: "Patients",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_VaccineId",
                table: "Patients",
                column: "VaccineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Vaccines_VaccineId",
                table: "Patients",
                column: "VaccineId",
                principalTable: "Vaccines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
