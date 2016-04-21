using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using Travel_Blog.Models;

namespace TravelBlog.Migrations
{
    [DbContext(typeof(TravelBlogDbContext))]
    [Migration("20160421164036_MakeTableNamesPlural")]
    partial class MakeTableNamesPlural
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Travel_Blog.Models.Experience", b =>
                {
                    b.Property<int>("ExperienceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("LocationId");

                    b.HasKey("ExperienceId");

                    b.HasAnnotation("Relational:TableName", "Experiences");
                });

            modelBuilder.Entity("Travel_Blog.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("LocationId");

                    b.HasAnnotation("Relational:TableName", "Locations");
                });

            modelBuilder.Entity("Travel_Blog.Models.People", b =>
                {
                    b.Property<int>("PeopleId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ExperienceId");

                    b.Property<string>("Name");

                    b.HasKey("PeopleId");

                    b.HasAnnotation("Relational:TableName", "Peoples");
                });

            modelBuilder.Entity("Travel_Blog.Models.Experience", b =>
                {
                    b.HasOne("Travel_Blog.Models.Location")
                        .WithMany()
                        .HasForeignKey("LocationId");
                });

            modelBuilder.Entity("Travel_Blog.Models.People", b =>
                {
                    b.HasOne("Travel_Blog.Models.Experience")
                        .WithMany()
                        .HasForeignKey("ExperienceId");
                });
        }
    }
}
