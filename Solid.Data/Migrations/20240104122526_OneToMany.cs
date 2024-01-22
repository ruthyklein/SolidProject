using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solid.Data.Migrations
{
    public partial class OneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "PatientList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentId",
                table: "DoctorList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PatientList_AppointmentId",
                table: "PatientList",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorList_AppointmentId",
                table: "DoctorList",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorList_AppointmentList_AppointmentId",
                table: "DoctorList",
                column: "AppointmentId",
                principalTable: "AppointmentList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientList_AppointmentList_AppointmentId",
                table: "PatientList",
                column: "AppointmentId",
                principalTable: "AppointmentList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorList_AppointmentList_AppointmentId",
                table: "DoctorList");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientList_AppointmentList_AppointmentId",
                table: "PatientList");

            migrationBuilder.DropIndex(
                name: "IX_PatientList_AppointmentId",
                table: "PatientList");

            migrationBuilder.DropIndex(
                name: "IX_DoctorList_AppointmentId",
                table: "DoctorList");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "PatientList");

            migrationBuilder.DropColumn(
                name: "AppointmentId",
                table: "DoctorList");
        }
    }
}
