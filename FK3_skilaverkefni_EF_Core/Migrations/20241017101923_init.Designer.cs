﻿// <auto-generated />
using System;
using FK3_skilaverkefni_EF_Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FK3_skilaverkefni_EF_Core.Migrations
{
    [DbContext(typeof(SchoolDBContext))]
    [Migration("20241017101923_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FK3_skilaverkefni_EF_Core.Models.Groups", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentsStudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentsStudentId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("FK3_skilaverkefni_EF_Core.Models.Marks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Mark")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Marks");
                });

            modelBuilder.Entity("FK3_skilaverkefni_EF_Core.Models.Students", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<string>("First_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MarksId")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.HasIndex("MarksId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("FK3_skilaverkefni_EF_Core.Models.Subject_teacher", b =>
                {
                    b.Property<int>("SubjectId")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("TeacherId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.HasKey("SubjectId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Subject_teachers");
                });

            modelBuilder.Entity("FK3_skilaverkefni_EF_Core.Models.Subjects", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("MarksId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MarksId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("FK3_skilaverkefni_EF_Core.Models.Teachers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("First_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("FK3_skilaverkefni_EF_Core.Models.Groups", b =>
                {
                    b.HasOne("FK3_skilaverkefni_EF_Core.Models.Students", null)
                        .WithMany("Group_Id")
                        .HasForeignKey("StudentsStudentId");
                });

            modelBuilder.Entity("FK3_skilaverkefni_EF_Core.Models.Students", b =>
                {
                    b.HasOne("FK3_skilaverkefni_EF_Core.Models.Marks", null)
                        .WithMany("StudentId")
                        .HasForeignKey("MarksId");
                });

            modelBuilder.Entity("FK3_skilaverkefni_EF_Core.Models.Subject_teacher", b =>
                {
                    b.HasOne("FK3_skilaverkefni_EF_Core.Models.Subjects", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FK3_skilaverkefni_EF_Core.Models.Teachers", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("FK3_skilaverkefni_EF_Core.Models.Subjects", b =>
                {
                    b.HasOne("FK3_skilaverkefni_EF_Core.Models.Marks", null)
                        .WithMany("Subject_id")
                        .HasForeignKey("MarksId");
                });

            modelBuilder.Entity("FK3_skilaverkefni_EF_Core.Models.Marks", b =>
                {
                    b.Navigation("StudentId");

                    b.Navigation("Subject_id");
                });

            modelBuilder.Entity("FK3_skilaverkefni_EF_Core.Models.Students", b =>
                {
                    b.Navigation("Group_Id");
                });
#pragma warning restore 612, 618
        }
    }
}