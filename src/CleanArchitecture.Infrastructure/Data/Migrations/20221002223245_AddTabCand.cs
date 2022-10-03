using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Data.Migrations
{
    public partial class AddTabCand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataApauracao",
                table: "UrlStatusHistories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Candidatos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    seq = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sqcand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    n = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    e = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    st = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dvt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pvap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataApauracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidatos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidatos");

            migrationBuilder.DropColumn(
                name: "DataApauracao",
                table: "UrlStatusHistories");
        }
    }
}
