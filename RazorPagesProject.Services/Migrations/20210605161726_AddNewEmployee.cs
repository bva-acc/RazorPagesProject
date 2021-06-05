using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesProject.Services.Migrations
{
    public partial class AddNewEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create procedure spAddNewEmployee
                                @Name nvarchar(100),
                                @Email nvarchar(100),
                                @PhotoPath nvarchar(100),
                                @Department int
                                as
                                Begin
                                    INSERT INTO Employees (Name, Email, PhotoPath, Department)
                                    VALUES (@Name, @Email, @PhotoPath, @Department)
                                End";
            migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Drop procedure spAddNewEmployee";
            migrationBuilder.Sql(procedure);
        }
    }
}
