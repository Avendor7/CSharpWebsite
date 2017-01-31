using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSharpWebsite.Migrations
{
    public partial class maybefixthings5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IpAddresses",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGeneratedOnAdd", true),
                    container = table.Column<bool>(nullable: false),
                    description = table.Column<string>(nullable: false),
                    docker = table.Column<bool>(nullable: false),
                    hostname = table.Column<string>(maxLength: 255, nullable: false),
                    ipv4 = table.Column<string>(maxLength: 21, nullable: true),
                    ipv6 = table.Column<string>(maxLength: 45, nullable: true),
                    operating_system = table.Column<string>(nullable: false),
                    vm = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IpAddresses", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IpAddresses");
        }
    }
}
