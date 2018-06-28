using Microsoft.EntityFrameworkCore.Migrations;

namespace MissionIT.WebHelp.Migrations
{
    public partial class SeedingSectionAndArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tblSections",
                columns: new[] { "SectionID", "SectionName" },
                values: new object[,]
                {
                    { 1, "Introduction" },
                    { 24, "Documents" },
                    { 23, "Accounts" },
                    { 22, "Messaging" },
                    { 21, "All DBS Application" },
                    { 20, "Scheduling" },
                    { 19, "Work Shop" },
                    { 18, "Provider" },
                    { 17, "Vehicle" },
                    { 16, "Attendent" },
                    { 15, "Driver" },
                    { 14, "Passenger" },
                    { 13, "Exception" },
                    { 12, "Route" },
                    { 11, "Venue" },
                    { 10, "Lists" },
                    { 9, "Add New" },
                    { 8, "Jobs" },
                    { 7, "Quick Change" },
                    { 6, "Audit Trial" },
                    { 5, "User Diary" },
                    { 4, "My Favourites" },
                    { 3, "Customer Service" },
                    { 2, "Time Line" },
                    { 25, "Utilities" },
                    { 26, "How to use Help" }
                });

            migrationBuilder.InsertData(
                table: "tblArticles",
                columns: new[] { "ArticleID", "ArticleDescription", "ArticleImageUrl", "ArticleName", "SectionID" },
                values: new object[,]
                {
                    { 1, "werwwwwwwwwwwwwwwwwwwwwwwwwewrwerwerwerwe", "010001.jpg", "Menu", 1 },
                    { 2, "werwwwwwwwwwwwwwwwwwwwwwwwwewrwerwerwerwe", "010002.jpg", "Routes", 2 },
                    { 3, "werwwwwwwwwwwwwwwwwwwwwwwwwewrwerwerwerwe", "010003.jpg", "Drivers", 2 },
                    { 4, "wssssssssssssssssssssssssssssssssssss", "020004.jpg", "Vehicles", 3 },
                    { 5, "eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee", "020005.jpg", "Drivers", 3 },
                    { 6, "werwwwwwwwwwwwwwwwwwwwwwwwwewrwerwerwerwe", "050006.jpg", "Audit Trial", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tblArticles",
                keyColumn: "ArticleID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tblArticles",
                keyColumn: "ArticleID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tblArticles",
                keyColumn: "ArticleID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tblArticles",
                keyColumn: "ArticleID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tblArticles",
                keyColumn: "ArticleID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "tblArticles",
                keyColumn: "ArticleID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "tblSections",
                keyColumn: "SectionID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "tblSections",
                keyColumn: "SectionID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "tblSections",
                keyColumn: "SectionID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "tblSections",
                keyColumn: "SectionID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "tblSections",
                keyColumn: "SectionID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "tblSections",
                keyColumn: "SectionID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "tblSections",
                keyColumn: "SectionID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "tblSections",
                keyColumn: "SectionID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "tblSections",
                keyColumn: "SectionID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "tblSections",
                keyColumn: "SectionID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "tblSections",
                keyColumn: "SectionID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "tblSections",
                keyColumn: "SectionID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "tblSections",
                keyColumn: "SectionID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "tblSections",
                keyColumn: "SectionID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "tblSections",
                keyColumn: "SectionID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "tblSections",
                keyColumn: "SectionID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "tblSections",
                keyColumn: "SectionID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "tblSections",
                keyColumn: "SectionID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "tblSections",
                keyColumn: "SectionID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "tblSections",
                keyColumn: "SectionID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "tblSections",
                keyColumn: "SectionID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "tblSections",
                keyColumn: "SectionID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "tblSections",
                keyColumn: "SectionID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tblSections",
                keyColumn: "SectionID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tblSections",
                keyColumn: "SectionID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tblSections",
                keyColumn: "SectionID",
                keyValue: 4);
        }
    }
}
