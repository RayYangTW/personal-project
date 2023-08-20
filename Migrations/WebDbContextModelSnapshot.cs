﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using personal_project.Data;

#nullable disable

namespace personal_project.Migrations
{
    [DbContext(typeof(WebDbContext))]
    partial class WebDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("personal_project.Models.Domain.Booking", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.Property<DateTime>("bookingTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("courseId")
                        .HasColumnType("bigint");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("userId")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.HasIndex("courseId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("personal_project.Models.Domain.ChatRecord", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.Property<DateTime>("createdTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("teacherId")
                        .HasColumnType("bigint");

                    b.Property<long>("userId")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("ChatRecords");
                });

            modelBuilder.Entity("personal_project.Models.Domain.Comment", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.Property<string>("comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createdTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("rate")
                        .HasColumnType("float");

                    b.Property<long>("teacherId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("updatedTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("userId")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("personal_project.Models.Domain.Course", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.Property<DateTime>("endTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isBooked")
                        .HasColumnType("bit");

                    b.Property<DateTime>("startTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("teacherId")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.HasIndex("teacherId")
                        .IsUnique();

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("personal_project.Models.Domain.CourseCategory", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.Property<string>("category")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("CourseCategories");
                });

            modelBuilder.Entity("personal_project.Models.Domain.CourseRecord", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.Property<long>("ChatRecordId")
                        .HasColumnType("bigint");

                    b.Property<string>("roomId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("ChatRecordId");

                    b.ToTable("CourseRecords");
                });

            modelBuilder.Entity("personal_project.Models.Domain.Profile", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.Property<string>("avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("interest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nickname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("userId")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("personal_project.Models.Domain.Teacher", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.Property<string>("avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("courseCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("courseLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("courseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("courseRemider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("courseWay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("userId")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.HasIndex("userId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("personal_project.Models.Domain.TeacherApplication", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.Property<string>("category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("certification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("experience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isApproved")
                        .HasColumnType("bit");

                    b.Property<string>("language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("userId")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.HasIndex("userId");

                    b.ToTable("TeacherApplications");
                });

            modelBuilder.Entity("personal_project.Models.Domain.User", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("provider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("personal_project.Models.Domain.Booking", b =>
                {
                    b.HasOne("personal_project.Models.Domain.Course", "course")
                        .WithMany("bookings")
                        .HasForeignKey("courseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("course");
                });

            modelBuilder.Entity("personal_project.Models.Domain.Course", b =>
                {
                    b.HasOne("personal_project.Models.Domain.Teacher", "teacher")
                        .WithOne("course")
                        .HasForeignKey("personal_project.Models.Domain.Course", "teacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("teacher");
                });

            modelBuilder.Entity("personal_project.Models.Domain.CourseRecord", b =>
                {
                    b.HasOne("personal_project.Models.Domain.ChatRecord", "chatRecord")
                        .WithMany("courseRecords")
                        .HasForeignKey("ChatRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("chatRecord");
                });

            modelBuilder.Entity("personal_project.Models.Domain.Teacher", b =>
                {
                    b.HasOne("personal_project.Models.Domain.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("personal_project.Models.Domain.TeacherApplication", b =>
                {
                    b.HasOne("personal_project.Models.Domain.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("personal_project.Models.Domain.ChatRecord", b =>
                {
                    b.Navigation("courseRecords");
                });

            modelBuilder.Entity("personal_project.Models.Domain.Course", b =>
                {
                    b.Navigation("bookings");
                });

            modelBuilder.Entity("personal_project.Models.Domain.Teacher", b =>
                {
                    b.Navigation("course");
                });
#pragma warning restore 612, 618
        }
    }
}
