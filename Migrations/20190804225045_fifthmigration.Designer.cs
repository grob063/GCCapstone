﻿// <auto-generated />
using System;
using GrandCircusUniversity.GrandCircusUniversity2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GrandCircusUniversity.Migrations
{
    [DbContext(typeof(ContextClass))]
    [Migration("20190804225045_fifthmigration")]
    partial class fifthmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GrandCircusUniversity.GrandCircusUniversity2.Administrator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Administrator");
                });

            modelBuilder.Entity("GrandCircusUniversity.GrandCircusUniversity2.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdministratorId");

                    b.Property<string>("CourseName");

                    b.Property<bool>("isFullTime");

                    b.Property<bool>("isPartTime");

                    b.HasKey("CourseId");

                    b.HasIndex("AdministratorId");

                    b.ToTable("Course");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            CourseName = "C#",
                            isFullTime = true,
                            isPartTime = false
                        },
                        new
                        {
                            CourseId = 2,
                            CourseName = "JavaScript",
                            isFullTime = false,
                            isPartTime = true
                        },
                        new
                        {
                            CourseId = 3,
                            CourseName = ".Net Core",
                            isFullTime = true,
                            isPartTime = false
                        });
                });

            modelBuilder.Entity("GrandCircusUniversity.GrandCircusUniversity2.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdministratorId");

                    b.Property<string>("CourseName");

                    b.Property<string>("StudentFirstName");

                    b.Property<string>("StudentLastName");

                    b.HasKey("StudentId");

                    b.HasIndex("AdministratorId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("GrandCircusUniversity.GrandCircusUniversity2.StudentCourse", b =>
                {
                    b.Property<int>("StudentCourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdministratorId");

                    b.Property<int?>("CourseId");

                    b.Property<int>("StudentId");

                    b.HasKey("StudentCourseId");

                    b.HasIndex("AdministratorId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentCourse");
                });

            modelBuilder.Entity("GrandCircusUniversity.GrandCircusUniversity2.Course", b =>
                {
                    b.HasOne("GrandCircusUniversity.GrandCircusUniversity2.Administrator")
                        .WithMany("Course")
                        .HasForeignKey("AdministratorId");
                });

            modelBuilder.Entity("GrandCircusUniversity.GrandCircusUniversity2.Student", b =>
                {
                    b.HasOne("GrandCircusUniversity.GrandCircusUniversity2.Administrator", "Administrator")
                        .WithMany("Students")
                        .HasForeignKey("AdministratorId");
                });

            modelBuilder.Entity("GrandCircusUniversity.GrandCircusUniversity2.StudentCourse", b =>
                {
                    b.HasOne("GrandCircusUniversity.GrandCircusUniversity2.Administrator")
                        .WithMany("StudentCourses")
                        .HasForeignKey("AdministratorId");

                    b.HasOne("GrandCircusUniversity.GrandCircusUniversity2.Course", "Course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CourseId");

                    b.HasOne("GrandCircusUniversity.GrandCircusUniversity2.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
