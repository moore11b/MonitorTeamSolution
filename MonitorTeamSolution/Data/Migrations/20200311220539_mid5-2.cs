using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonitorTeamSolution.Data.Migrations
{
    public partial class mid52 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PageCreateVMId",
                table: "Logs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PageDeleteVMId",
                table: "Logs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PageEditVMId",
                table: "Logs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PageCreateVMId",
                table: "ApplicationUser",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PageDeleteVMId",
                table: "ApplicationUser",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PageEditVMId",
                table: "ApplicationUser",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PageCreateVM",
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
                    table.PrimaryKey("PK_PageCreateVM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PageDeleteVM",
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
                    table.PrimaryKey("PK_PageDeleteVM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PageEditVM",
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
                    table.PrimaryKey("PK_PageEditVM", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Logs_PageCreateVMId",
                table: "Logs",
                column: "PageCreateVMId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_PageDeleteVMId",
                table: "Logs",
                column: "PageDeleteVMId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_PageEditVMId",
                table: "Logs",
                column: "PageEditVMId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUser_PageCreateVMId",
                table: "ApplicationUser",
                column: "PageCreateVMId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUser_PageDeleteVMId",
                table: "ApplicationUser",
                column: "PageDeleteVMId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUser_PageEditVMId",
                table: "ApplicationUser",
                column: "PageEditVMId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUser_PageCreateVM_PageCreateVMId",
                table: "ApplicationUser",
                column: "PageCreateVMId",
                principalTable: "PageCreateVM",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUser_PageDeleteVM_PageDeleteVMId",
                table: "ApplicationUser",
                column: "PageDeleteVMId",
                principalTable: "PageDeleteVM",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUser_PageEditVM_PageEditVMId",
                table: "ApplicationUser",
                column: "PageEditVMId",
                principalTable: "PageEditVM",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_PageCreateVM_PageCreateVMId",
                table: "Logs",
                column: "PageCreateVMId",
                principalTable: "PageCreateVM",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_PageDeleteVM_PageDeleteVMId",
                table: "Logs",
                column: "PageDeleteVMId",
                principalTable: "PageDeleteVM",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_PageEditVM_PageEditVMId",
                table: "Logs",
                column: "PageEditVMId",
                principalTable: "PageEditVM",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUser_PageCreateVM_PageCreateVMId",
                table: "ApplicationUser");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUser_PageDeleteVM_PageDeleteVMId",
                table: "ApplicationUser");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUser_PageEditVM_PageEditVMId",
                table: "ApplicationUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Logs_PageCreateVM_PageCreateVMId",
                table: "Logs");

            migrationBuilder.DropForeignKey(
                name: "FK_Logs_PageDeleteVM_PageDeleteVMId",
                table: "Logs");

            migrationBuilder.DropForeignKey(
                name: "FK_Logs_PageEditVM_PageEditVMId",
                table: "Logs");

            migrationBuilder.DropTable(
                name: "PageCreateVM");

            migrationBuilder.DropTable(
                name: "PageDeleteVM");

            migrationBuilder.DropTable(
                name: "PageEditVM");

            migrationBuilder.DropIndex(
                name: "IX_Logs_PageCreateVMId",
                table: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_Logs_PageDeleteVMId",
                table: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_Logs_PageEditVMId",
                table: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUser_PageCreateVMId",
                table: "ApplicationUser");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUser_PageDeleteVMId",
                table: "ApplicationUser");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUser_PageEditVMId",
                table: "ApplicationUser");

            migrationBuilder.DropColumn(
                name: "PageCreateVMId",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "PageDeleteVMId",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "PageEditVMId",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "PageCreateVMId",
                table: "ApplicationUser");

            migrationBuilder.DropColumn(
                name: "PageDeleteVMId",
                table: "ApplicationUser");

            migrationBuilder.DropColumn(
                name: "PageEditVMId",
                table: "ApplicationUser");
        }
    }
}
