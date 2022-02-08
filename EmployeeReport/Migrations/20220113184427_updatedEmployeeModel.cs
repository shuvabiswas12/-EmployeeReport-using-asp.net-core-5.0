using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeReport.Migrations
{
    public partial class updatedEmployeeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UniversityCourseDuration",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "MailingAddress",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MailingAddress",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "UniversityCourseDuration",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
