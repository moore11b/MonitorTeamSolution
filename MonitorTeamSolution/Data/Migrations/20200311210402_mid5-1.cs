using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonitorTeamSolution.Data.Migrations
{
    public partial class mid51 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PageListVMId",
                table: "Logs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PageListVMId",
                table: "ApplicationUser",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LogCreateVM",
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
                    table.PrimaryKey("PK_LogCreateVM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogDeleteVM",
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
                    table.PrimaryKey("PK_LogDeleteVM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogEditVM",
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
                    table.PrimaryKey("PK_LogEditVM", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Logs_PageListVMId",
                table: "Logs",
                column: "PageListVMId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUser_PageListVMId",
                table: "ApplicationUser",
                column: "PageListVMId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUser_PageListVM_PageListVMId",
                table: "ApplicationUser",
                column: "PageListVMId",
                principalTable: "PageListVM",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_PageListVM_PageListVMId",
                table: "Logs",
                column: "PageListVMId",
                principalTable: "PageListVM",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUser_PageListVM_PageListVMId",
                table: "ApplicationUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Logs_PageListVM_PageListVMId",
                table: "Logs");

            migrationBuilder.DropTable(
                name: "LogCreateVM");

            migrationBuilder.DropTable(
                name: "LogDeleteVM");

            migrationBuilder.DropTable(
                name: "LogEditVM");

            migrationBuilder.DropIndex(
                name: "IX_Logs_PageListVMId",
                table: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUser_PageListVMId",
                table: "ApplicationUser");

            migrationBuilder.DropColumn(
                name: "PageListVMId",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "PageListVMId",
                table: "ApplicationUser");
        }
    }
}
