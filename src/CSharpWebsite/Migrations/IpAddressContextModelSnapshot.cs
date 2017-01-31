using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CSharpWebsite.Models;

namespace CSharpWebsite.Migrations
{
    [DbContext(typeof(IpAddressContext))]
    partial class IpAddressContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1");

            modelBuilder.Entity("CSharpWebsite.Models.IpAddress", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("container");

                    b.Property<string>("description")
                        .IsRequired();

                    b.Property<bool>("docker");

                    b.Property<string>("hostname")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("ipv4")
                        .HasAnnotation("MaxLength", 21);

                    b.Property<string>("ipv6")
                        .HasAnnotation("MaxLength", 45);

                    b.Property<string>("operating_system")
                        .IsRequired();

                    b.Property<bool>("vm");

                    b.HasKey("id");

                    b.ToTable("IpAddresses");
                });
        }
    }
}
