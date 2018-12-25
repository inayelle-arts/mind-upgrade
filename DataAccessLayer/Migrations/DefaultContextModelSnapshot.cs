﻿// <auto-generated />
using System;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(DefaultContext))]
    partial class DefaultContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DataAccessLayer.Entities.Attachment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StoragePath");

                    b.HasKey("Id");

                    b.ToTable("Attachment");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.BacklogTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("Priority");

                    b.Property<int?>("ProjectBacklogId");

                    b.Property<int>("RequirementId");

                    b.Property<int?>("SprintBacklogId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectBacklogId");

                    b.HasIndex("RequirementId");

                    b.HasIndex("SprintBacklogId");

                    b.ToTable("BacklogTask");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Board", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatorId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("HistoryId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("ProjectId");

                    b.Property<int>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("HistoryId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("TeamId")
                        .IsUnique();

                    b.ToTable("Boards");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Board");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Column", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BoardId");

                    b.Property<int>("CreatorId");

                    b.Property<int>("HistoryId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("BoardId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("HistoryId");

                    b.ToTable("Columns");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AttachmentsId");

                    b.Property<int>("AuthorId");

                    b.Property<DateTime>("CreationDate");

                    b.Property<int>("TaskId");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("AttachmentsId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("TaskId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Constraints.Abstract.BoardConstraintEntityBase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("OwnerId");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("BoardConstraints");

                    b.HasDiscriminator<string>("Discriminator").HasValue("BoardConstraintEntityBase");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Constraints.Abstract.ColumnConstraintEntityBase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("OwnerId");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("ColumnConstraints");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ColumnConstraintEntityBase");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Constraints.Abstract.TaskConstraintEntityBase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("OwnerId");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("TaskConstraints");

                    b.HasDiscriminator<string>("Discriminator").HasValue("TaskConstraintEntityBase");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.ContactInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Identifier")
                        .IsRequired();

                    b.Property<int?>("OwnerId");

                    b.Property<string>("Source")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("ContactInfo");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Cooperation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompanyId");

                    b.Property<DateTime>("EndOfCooperation");

                    b.Property<int>("MemberId");

                    b.Property<DateTime>("StartOfCooperation");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("MemberId");

                    b.ToTable("Cooperation");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Histories");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.HistoryPoint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Event")
                        .IsRequired();

                    b.Property<int>("HistoryId");

                    b.HasKey("Id");

                    b.HasIndex("HistoryId");

                    b.ToTable("HistoryPoints");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Label", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BoardId");

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<int?>("TaskId");

                    b.HasKey("Id");

                    b.HasIndex("BoardId");

                    b.HasIndex("TaskId");

                    b.ToTable("Labels");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BacklogId");

                    b.Property<int>("CompanyId");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("ProjectRootId");

                    b.Property<int>("RequirementListId");

                    b.HasKey("Id");

                    b.HasIndex("BacklogId")
                        .IsUnique();

                    b.HasIndex("CompanyId");

                    b.HasIndex("ProjectRootId");

                    b.HasIndex("RequirementListId")
                        .IsUnique();

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.ProjectBacklog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("ProjectBacklog");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Requirement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("Priority");

                    b.Property<int>("RequirementListId");

                    b.HasKey("Id");

                    b.HasIndex("RequirementListId");

                    b.ToTable("Requirement");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.RequirementList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("RequirementList");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Sprint", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<int>("SprintBacklogId");

                    b.Property<int>("StoryPointsActual");

                    b.Property<int>("StoryPointsExpected");

                    b.HasKey("Id");

                    b.HasIndex("SprintBacklogId")
                        .IsUnique();

                    b.ToTable("Sprint");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.SprintBacklog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("SprintBacklog");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AssigneeId");

                    b.Property<int?>("BacklogTaskId");

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<int>("ColumnId");

                    b.Property<int>("CreatorId");

                    b.Property<string>("Description");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int?>("HistoryId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("AssigneeId");

                    b.HasIndex("BacklogTaskId");

                    b.HasIndex("ColumnId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("HistoryId");

                    b.ToTable("Tasks");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Task");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompanyId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("ProjectId");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Teams2Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MemberId");

                    b.Property<int>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.HasIndex("TeamId");

                    b.ToTable("Teams2Users");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("PasswordHash");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.KanbanBoard", b =>
                {
                    b.HasBaseType("DataAccessLayer.Entities.Board");

                    b.ToTable("KanbanBoards");

                    b.HasDiscriminator().HasValue("KanbanBoard");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.ScrumBoard", b =>
                {
                    b.HasBaseType("DataAccessLayer.Entities.Board");

                    b.Property<int>("CurrentSprintId");

                    b.HasIndex("CurrentSprintId")
                        .IsUnique();

                    b.ToTable("ScrumBoards");

                    b.HasDiscriminator().HasValue("ScrumBoard");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Constraints.SequentialBoardMovementConstraintEntity", b =>
                {
                    b.HasBaseType("DataAccessLayer.Entities.Constraints.Abstract.BoardConstraintEntityBase");

                    b.HasDiscriminator().HasValue("SequentialBoardMovementConstraintEntity");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Constraints.TasksPerUserColumnConstraintEntity", b =>
                {
                    b.HasBaseType("DataAccessLayer.Entities.Constraints.Abstract.ColumnConstraintEntityBase");

                    b.Property<int>("Quantity");

                    b.HasDiscriminator().HasValue("TasksPerUserColumnConstraintEntity");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Constraints.SequentialTaskConstraintEntity", b =>
                {
                    b.HasBaseType("DataAccessLayer.Entities.Constraints.Abstract.TaskConstraintEntityBase");

                    b.Property<int>("ParentTaskId");

                    b.HasIndex("ParentTaskId");

                    b.HasDiscriminator().HasValue("SequentialTaskConstraintEntity");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.KanbanTask", b =>
                {
                    b.HasBaseType("DataAccessLayer.Entities.Task");

                    b.Property<int>("StoryPointsSpent");

                    b.ToTable("KanbanTasks");

                    b.HasDiscriminator().HasValue("KanbanTask");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.ScrumTask", b =>
                {
                    b.HasBaseType("DataAccessLayer.Entities.Task");

                    b.Property<DateTime>("ExpirationDate");

                    b.Property<int>("SprintId");

                    b.Property<int>("StoryPointsExpected");

                    b.Property<int>("StoryPointsSpent")
                        .HasColumnName("ScrumTask_StoryPointsSpent");

                    b.HasIndex("SprintId");

                    b.ToTable("ScrumTasks");

                    b.HasDiscriminator().HasValue("ScrumTask");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.BacklogTask", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.ProjectBacklog")
                        .WithMany("Tasks")
                        .HasForeignKey("ProjectBacklogId");

                    b.HasOne("DataAccessLayer.Entities.Requirement", "Requirement")
                        .WithMany("Tasks")
                        .HasForeignKey("RequirementId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataAccessLayer.Entities.SprintBacklog")
                        .WithMany("Tasks")
                        .HasForeignKey("SprintBacklogId");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Board", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataAccessLayer.Entities.History", "History")
                        .WithMany()
                        .HasForeignKey("HistoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataAccessLayer.Entities.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataAccessLayer.Entities.Team", "Team")
                        .WithOne("Board")
                        .HasForeignKey("DataAccessLayer.Entities.Board", "TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Column", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.Board", "Board")
                        .WithMany("Columns")
                        .HasForeignKey("BoardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataAccessLayer.Entities.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataAccessLayer.Entities.History", "History")
                        .WithMany()
                        .HasForeignKey("HistoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Comment", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.Attachment", "Attachments")
                        .WithMany()
                        .HasForeignKey("AttachmentsId");

                    b.HasOne("DataAccessLayer.Entities.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataAccessLayer.Entities.Task", "Task")
                        .WithMany("Comments")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Constraints.Abstract.BoardConstraintEntityBase", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.Board", "Owner")
                        .WithMany("Constraints")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Constraints.Abstract.ColumnConstraintEntityBase", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.Column", "Owner")
                        .WithMany("Constraints")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Constraints.Abstract.TaskConstraintEntityBase", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.Task", "Owner")
                        .WithMany("Constraints")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.ContactInfo", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.User", "Owner")
                        .WithMany("Contacts")
                        .HasForeignKey("OwnerId");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Cooperation", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.Company", "Company")
                        .WithMany("Cooperations")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataAccessLayer.Entities.User", "Member")
                        .WithMany("CompanyCooperations")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.HistoryPoint", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.History", "History")
                        .WithMany("Events")
                        .HasForeignKey("HistoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Label", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.Board", "Board")
                        .WithMany("Labels")
                        .HasForeignKey("BoardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataAccessLayer.Entities.Task")
                        .WithMany("Labels")
                        .HasForeignKey("TaskId");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Project", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.ProjectBacklog", "Backlog")
                        .WithOne("Project")
                        .HasForeignKey("DataAccessLayer.Entities.Project", "BacklogId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataAccessLayer.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataAccessLayer.Entities.User", "ProjectRoot")
                        .WithMany("Projects")
                        .HasForeignKey("ProjectRootId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataAccessLayer.Entities.RequirementList", "RequirementList")
                        .WithOne("Project")
                        .HasForeignKey("DataAccessLayer.Entities.Project", "RequirementListId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Requirement", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.RequirementList", "RequirementList")
                        .WithMany("Requirements")
                        .HasForeignKey("RequirementListId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Sprint", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.SprintBacklog", "Backlog")
                        .WithOne("Sprint")
                        .HasForeignKey("DataAccessLayer.Entities.Sprint", "SprintBacklogId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Task", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.User", "Assignee")
                        .WithMany()
                        .HasForeignKey("AssigneeId");

                    b.HasOne("DataAccessLayer.Entities.BacklogTask", "BacklogTask")
                        .WithMany()
                        .HasForeignKey("BacklogTaskId");

                    b.HasOne("DataAccessLayer.Entities.Column", "Column")
                        .WithMany("Tasks")
                        .HasForeignKey("ColumnId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataAccessLayer.Entities.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataAccessLayer.Entities.History", "History")
                        .WithMany()
                        .HasForeignKey("HistoryId");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Team", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataAccessLayer.Entities.Project", "Project")
                        .WithMany("Teams")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Teams2Users", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.User", "Member")
                        .WithMany("TeamUserPairs")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataAccessLayer.Entities.Team", "Team")
                        .WithMany("TeamUserPairs")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.ScrumBoard", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.Sprint", "CurrentSprint")
                        .WithOne("Board")
                        .HasForeignKey("DataAccessLayer.Entities.ScrumBoard", "CurrentSprintId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Constraints.SequentialTaskConstraintEntity", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.Task", "ParentTask")
                        .WithMany()
                        .HasForeignKey("ParentTaskId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.ScrumTask", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.Sprint", "Sprint")
                        .WithMany()
                        .HasForeignKey("SprintId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
