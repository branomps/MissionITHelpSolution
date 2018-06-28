using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MissionIT.WebHelp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblSections",
                columns: table => new
                {
                    SectionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SectionName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSections", x => x.SectionID);
                });

            migrationBuilder.CreateTable(
                name: "tblArticles",
                columns: table => new
                {
                    ArticleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArticleDescription = table.Column<string>(maxLength: 10000, nullable: false),
                    ArticleImageUrl = table.Column<string>(nullable: false),
                    ArticleName = table.Column<string>(maxLength: 100, nullable: false),
                    SectionID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblArticles", x => x.ArticleID);
                    table.ForeignKey(
                        name: "FK_tblArticles_tblSections_SectionID",
                        column: x => x.SectionID,
                        principalTable: "tblSections",
                        principalColumn: "SectionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblArticles_SectionID",
                table: "tblArticles",
                column: "SectionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblArticles");

            migrationBuilder.DropTable(
                name: "tblSections");
        }
    }
}
