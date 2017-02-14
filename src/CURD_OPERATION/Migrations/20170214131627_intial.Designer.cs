using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CURD_OPERATION.Models;

namespace CURD_OPERATION.Migrations
{
    [DbContext(typeof(StudentDBContext))]
    [Migration("20170214131627_intial")]
    partial class intial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CURD_OPERATION.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 10);

                    b.HasKey("ID");

                    b.ToTable("Students");
                });
        }
    }
}
