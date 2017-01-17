using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CSharpWebsite.Models;

namespace CSharpWebsite.Migrations
{
    [DbContext(typeof(IpAddressContext))]
    [Migration("20170114093208_IpAddress")]
    partial class IpAddress
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CSharpWebsite.Models.IpAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("container");

                    b.Property<string>("description")
                        .IsRequired();

                    b.Property<bool>("docker");

                    b.Property<string>("ipv4")
                        .HasAnnotation("MaxLength", 21);

                    b.Property<string>("ipv6")
                        .HasAnnotation("MaxLength", 45);

                    b.Property<string>("operating_system")
                        .IsRequired();

                    b.Property<bool>("vm");

                    b.HasKey("Id");

                    b.ToTable("IpAddresses");
                });
        }
    }
}
