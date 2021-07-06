﻿// <auto-generated />
using App;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("App.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CourseName")
                        .HasColumnType("TEXT");

                    b.Property<double>("GradeVal")
                        .HasColumnType("REAL");

                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Grades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseName = "407 Shark Metabolism",
                            GradeVal = 0.78000000000000003,
                            StudentId = 1
                        },
                        new
                        {
                            Id = 2,
                            CourseName = "411 Anemone Poisons",
                            GradeVal = 0.88,
                            StudentId = 1
                        },
                        new
                        {
                            Id = 3,
                            CourseName = "420 Reef Pollution",
                            GradeVal = 0.96999999999999997,
                            StudentId = 1
                        },
                        new
                        {
                            Id = 4,
                            CourseName = "103 Agave Chemistry",
                            GradeVal = 0.87,
                            StudentId = 2
                        },
                        new
                        {
                            Id = 5,
                            CourseName = "101 Accounting",
                            GradeVal = 0.97999999999999998,
                            StudentId = 2
                        },
                        new
                        {
                            Id = 6,
                            CourseName = "107 Music",
                            GradeVal = 0.79000000000000004,
                            StudentId = 2
                        },
                        new
                        {
                            Id = 7,
                            CourseName = "203 English Literature",
                            GradeVal = 0.87,
                            StudentId = 3
                        },
                        new
                        {
                            Id = 8,
                            CourseName = "219 College Algebra",
                            GradeVal = 0.97999999999999998,
                            StudentId = 3
                        },
                        new
                        {
                            Id = 9,
                            CourseName = "275 Industrial Arts",
                            GradeVal = 0.81000000000000005,
                            StudentId = 3
                        });
                });

            modelBuilder.Entity("App.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<int>("GrYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 53,
                            FirstName = "Phillipe",
                            GrYear = 3,
                            LastName = "Cousteau"
                        },
                        new
                        {
                            Id = 2,
                            Age = 25,
                            FirstName = "Don",
                            GrYear = 0,
                            LastName = "Julio"
                        },
                        new
                        {
                            Id = 3,
                            Age = 37,
                            FirstName = "Susan",
                            GrYear = 1,
                            LastName = "Lawrence"
                        });
                });

            modelBuilder.Entity("App.Grade", b =>
                {
                    b.HasOne("App.Student", null)
                        .WithMany("ListOfGrades")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("App.Student", b =>
                {
                    b.Navigation("ListOfGrades");
                });
#pragma warning restore 612, 618
        }
    }
}
