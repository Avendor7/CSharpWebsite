using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSharpWebsite.Migrations
{
    public partial class removefk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IpAddress_AspNetUsers_ApplicationUserID",
                table: "IpAddress");

            migrationBuilder.AddForeignKey(
                name: "FK_IpAddress_AspNetUsers_ApplicationUserId",
                table: "IpAddress",
                column: "ApplicationUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.RenameColumn(
                name: "ApplicationUserID",
                table: "IpAddress",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_IpAddress_ApplicationUserID",
                table: "IpAddress",
                newName: "IX_IpAddress_ApplicationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IpAddress_AspNetUsers_ApplicationUserId",
                table: "IpAddress");

            migrationBuilder.AddForeignKey(
                name: "FK_IpAddress_AspNetUsers_ApplicationUserID",
                table: "IpAddress",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "IpAddress",
                newName: "ApplicationUserID");

            migrationBuilder.RenameIndex(
                name: "IX_IpAddress_ApplicationUserId",
                table: "IpAddress",
                newName: "IX_IpAddress_ApplicationUserID");
        }
    }
}
