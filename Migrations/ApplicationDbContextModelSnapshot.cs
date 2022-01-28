﻿// <auto-generated />
using KanbanBoard.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace KanbanBoard.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("KanbanBoard.Models.Login", b =>
                {
                    b.Property<string>("email_id")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("email_id");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("KanbanBoard.Models.Project", b =>
                {
                    b.Property<int>("project_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ProjectStatus")
                        .HasColumnType("text");

                    b.Property<string>("project_name")
                        .HasColumnType("text");

                    b.HasKey("project_id");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("KanbanBoard.Models.Signup", b =>
                {
                    b.Property<int>("signup_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("email_id")
                        .HasColumnType("text");

                    b.Property<string>("first_name")
                        .HasColumnType("text");

                    b.Property<string>("last_name")
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .HasColumnType("text");

                    b.Property<long>("phone_number")
                        .HasColumnType("bigint");

                    b.HasKey("signup_id");

                    b.ToTable("Signup");
                });

            modelBuilder.Entity("KanbanBoard.Models.Tasks", b =>
                {
                    b.Property<int>("task_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("TaskStatus")
                        .HasColumnType("text");

                    b.Property<string>("task_name")
                        .HasColumnType("text");

                    b.HasKey("task_id");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("KanbanBoard.Models.TeamMembers", b =>
                {
                    b.Property<int>("teammember_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Role")
                        .HasColumnType("text");

                    b.Property<string>("TeamMembersStatus")
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .HasColumnType("text");

                    b.Property<string>("teammemberAnswer")
                        .HasColumnType("text");

                    b.Property<string>("teammemberEmail")
                        .HasColumnType("text");

                    b.Property<string>("teammemberName")
                        .HasColumnType("text");

                    b.HasKey("teammember_id");

                    b.ToTable("TeamMembers");
                });

            modelBuilder.Entity("KanbanBoard.Models.Users", b =>
                {
                    b.Property<int>("user_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Role")
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .HasColumnType("text");

                    b.Property<string>("userAnswer")
                        .HasColumnType("text");

                    b.Property<string>("userEmail")
                        .HasColumnType("text");

                    b.Property<string>("userName")
                        .HasColumnType("text");

                    b.HasKey("user_id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
