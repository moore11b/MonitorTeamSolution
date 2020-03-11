using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonitorTeamSolution.Data.Migrations
{
    public partial class mig33 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LogListVM",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    TimeLoggedIn = table.Column<string>(nullable: true),
                    TimeLoggedOut = table.Column<string>(nullable: true),
                    NumberOfPageViews = table.Column<string>(nullable: true),
                    SessionDuration = table.Column<string>(nullable: true),
                    PageTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogListVM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PageListVM",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TimeStamp = table.Column<string>(nullable: true),
                    PageTitle = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageListVM", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogListVM");

            migrationBuilder.DropTable(
                name: "PageListVM");
        }
    }
}
