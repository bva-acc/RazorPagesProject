using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesProject.Services.Migrations
{
    public partial class SpGetEmployeeById : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create procedure spGetEmployeeById
                                @Id int
                                as
                                Begin
	                                Select * from Employees
	                                Where Id = @Id
                                End";
            migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Drop procedure spGetEmployeeById";
            migrationBuilder.Sql(procedure);
        }
    }
}
