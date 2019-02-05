using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalMessenger.Migrations
{
    public partial class AddedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorId", "Age", "ImageUrl", "MiddleName", "Name", "Position", "Surname" },
                values: new object[] { 1, 30, "https://localhost:5001/Images/doktor.jpg", "Иванович", "Иван", "Хирург", "Иванов" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "DoctorId", "Age", "ImageUrl", "MiddleName", "Name", "Position", "Surname" },
                values: new object[] { 2, 35, "https://localhost:5001/Images/doktor.jpg", "Петрович", "Петр", "Хирург", "Петров" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "DoctorId",
                keyValue: 2);
        }
    }
}
