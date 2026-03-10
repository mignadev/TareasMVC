using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"IF NOT EXISTS(Select Id from AspNetRoles where Id = '55df06eb-75cf-47fe-b889-0ccfd491742c')
            BEGIN
	            INSERT AspNetRoles (Id, [Name], [NormalizedName])
	            VALUES ('55df06eb-75cf-47fe-b889-0ccfd491742c', 'admin', 'ADMIN')
            END");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE AspNetRoles Where Id = '55df06eb-75cf-47fe-b889-0ccfd491742c'");
        }
    }
}
