using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CSharpWebsite.Migrations
{
    public partial class IpAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IpAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    container = table.Column<bool>(nullable: false),
                    description = table.Column<string>(nullable: false),
                    docker = table.Column<bool>(nullable: false),
                    ipv4 = table.Column<string>(maxLength: 21, nullable: true),
                    ipv6 = table.Column<string>(maxLength: 45, nullable: true),
                    operating_system = table.Column<string>(nullable: false),
                    vm = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IpAddresses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IpAddresses");
        }
    }
}
