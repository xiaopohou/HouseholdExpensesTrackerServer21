﻿// <auto-generated />
using System;
using HouseholdExpensesTrackerServer21.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HouseholdExpensesTrackerServer21.Infrastructure.Migrations
{
    [DbContext(typeof(HouseholdDbContext))]
    partial class HouseholdDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HouseholdExpensesTrackerServer21.Domain.Expenses.Models.Expense", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount")
                        .HasColumnType("money");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<Guid>("ExpenseTypeId");

                    b.Property<Guid>("HouseholdId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("Version")
                        .IsConcurrencyToken()
                        .HasColumnName("Version");

                    b.Property<string>("_createdBy")
                        .IsRequired()
                        .HasColumnName("CreatedBy")
                        .HasMaxLength(255);

                    b.Property<DateTime>("_createdDate")
                        .HasColumnName("CreatedDate");

                    b.Property<string>("_updatedBy")
                        .HasColumnName("UpdatedBy")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("_updatedDate")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("ExpenseTypeId");

                    b.HasIndex("HouseholdId");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("HouseholdExpensesTrackerServer21.Domain.Expenses.Models.ExpenseType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<Guid>("UserId");

                    b.Property<int>("Version")
                        .IsConcurrencyToken()
                        .HasColumnName("Version");

                    b.Property<string>("_createdBy")
                        .IsRequired()
                        .HasColumnName("CreatedBy")
                        .HasMaxLength(255);

                    b.Property<DateTime>("_createdDate")
                        .HasColumnName("CreatedDate");

                    b.Property<string>("_updatedBy")
                        .HasColumnName("UpdatedBy")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("_updatedDate")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("UserId");

                    b.ToTable("ExpenseTypes");
                });

            modelBuilder.Entity("HouseholdExpensesTrackerServer21.Domain.Households.Models.Household", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Symbol");

                    b.Property<Guid>("UserId");

                    b.Property<int>("Version")
                        .IsConcurrencyToken()
                        .HasColumnName("Version");

                    b.Property<string>("_createdBy")
                        .IsRequired()
                        .HasColumnName("CreatedBy")
                        .HasMaxLength(255);

                    b.Property<DateTime>("_createdDate")
                        .HasColumnName("CreatedDate");

                    b.Property<string>("_updatedBy")
                        .HasColumnName("UpdatedBy")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("_updatedDate")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("UserId");

                    b.ToTable("Households");
                });

            modelBuilder.Entity("HouseholdExpensesTrackerServer21.Domain.Identities.Models.Credential", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CredentialTypeId");

                    b.Property<string>("Identifier")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Secret")
                        .HasMaxLength(1024);

                    b.Property<Guid>("UserId");

                    b.Property<int>("Version")
                        .IsConcurrencyToken()
                        .HasColumnName("Version");

                    b.Property<string>("_createdBy")
                        .IsRequired()
                        .HasColumnName("CreatedBy")
                        .HasMaxLength(255);

                    b.Property<DateTime>("_createdDate")
                        .HasColumnName("CreatedDate");

                    b.Property<string>("_updatedBy")
                        .HasColumnName("UpdatedBy")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("_updatedDate")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("CredentialTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Credentials");

                    b.HasData(
                        new { Id = new Guid("132a06e7-4c9e-49f9-8f94-0604f01a5c16"), CredentialTypeId = new Guid("105ef49d-42b6-4fb8-8d9e-52aaa16f42a9"), Identifier = "admin@example.com", Secret = "21-23-2F-29-7A-57-A5-A7-43-89-4A-0E-4A-80-1F-C3", UserId = new Guid("fa64114f-9aaf-492a-a9aa-43022bfac171"), Version = 1, _createdBy = "Initial", _createdDate = new DateTime(2018, 11, 21, 8, 10, 34, 326, DateTimeKind.Utc) }
                    );
                });

            modelBuilder.Entity("HouseholdExpensesTrackerServer21.Domain.Identities.Models.CredentialType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("Version")
                        .IsConcurrencyToken()
                        .HasColumnName("Version");

                    b.Property<string>("_createdBy")
                        .IsRequired()
                        .HasColumnName("CreatedBy")
                        .HasMaxLength(255);

                    b.Property<DateTime>("_createdDate")
                        .HasColumnName("CreatedDate");

                    b.Property<string>("_updatedBy")
                        .HasColumnName("UpdatedBy")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("_updatedDate")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("CredentialTypes");

                    b.HasData(
                        new { Id = new Guid("105ef49d-42b6-4fb8-8d9e-52aaa16f42a9"), Code = "email", Name = "Email address", Version = 1, _createdBy = "Initial", _createdDate = new DateTime(2018, 11, 21, 8, 10, 34, 317, DateTimeKind.Utc) }
                    );
                });

            modelBuilder.Entity("HouseholdExpensesTrackerServer21.Domain.Identities.Models.Permission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<int>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnName("Version");

                    b.Property<string>("_createdBy")
                        .IsRequired()
                        .HasColumnName("CreatedBy")
                        .HasMaxLength(255);

                    b.Property<DateTime>("_createdDate")
                        .HasColumnName("CreatedDate");

                    b.Property<string>("_updatedBy")
                        .HasColumnName("UpdatedBy")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("_updatedDate")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("HouseholdExpensesTrackerServer21.Domain.Identities.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<int>("Version")
                        .IsConcurrencyToken()
                        .HasColumnName("Version");

                    b.Property<string>("_createdBy")
                        .IsRequired()
                        .HasColumnName("CreatedBy")
                        .HasMaxLength(255);

                    b.Property<DateTime>("_createdDate")
                        .HasColumnName("CreatedDate");

                    b.Property<string>("_updatedBy")
                        .HasColumnName("UpdatedBy")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("_updatedDate")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("HouseholdExpensesTrackerServer21.Domain.Identities.Models.RolePermission", b =>
                {
                    b.Property<Guid>("RoleId");

                    b.Property<Guid>("PermissionId");

                    b.HasKey("RoleId", "PermissionId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("PermissionId");

                    b.ToTable("RolePermissions");
                });

            modelBuilder.Entity("HouseholdExpensesTrackerServer21.Domain.Identities.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("Version")
                        .IsConcurrencyToken()
                        .HasColumnName("Version");

                    b.Property<string>("_createdBy")
                        .IsRequired()
                        .HasColumnName("CreatedBy")
                        .HasMaxLength(255);

                    b.Property<DateTime>("_createdDate")
                        .HasColumnName("CreatedDate");

                    b.Property<string>("_updatedBy")
                        .HasColumnName("UpdatedBy")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("_updatedDate")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("Users");

                    b.HasData(
                        new { Id = new Guid("fa64114f-9aaf-492a-a9aa-43022bfac171"), Name = "Administrator", Version = 1, _createdBy = "Initial", _createdDate = new DateTime(2018, 11, 21, 8, 10, 34, 316, DateTimeKind.Utc) }
                    );
                });

            modelBuilder.Entity("HouseholdExpensesTrackerServer21.Domain.Identities.Models.UserRole", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("HouseholdExpensesTrackerServer21.Domain.Savings.Models.Saving", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount")
                        .HasColumnType("money");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<Guid>("HouseholdId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<Guid>("SavingTypeId");

                    b.Property<int>("Version")
                        .IsConcurrencyToken()
                        .HasColumnName("Version");

                    b.Property<string>("_createdBy")
                        .IsRequired()
                        .HasColumnName("CreatedBy")
                        .HasMaxLength(255);

                    b.Property<DateTime>("_createdDate")
                        .HasColumnName("CreatedDate");

                    b.Property<string>("_updatedBy")
                        .HasColumnName("UpdatedBy")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("_updatedDate")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("HouseholdId");

                    b.HasIndex("SavingTypeId");

                    b.ToTable("Savings");
                });

            modelBuilder.Entity("HouseholdExpensesTrackerServer21.Domain.Savings.Models.SavingType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Symbol")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<Guid>("UserId");

                    b.Property<int>("Version")
                        .IsConcurrencyToken()
                        .HasColumnName("Version");

                    b.Property<string>("_createdBy")
                        .IsRequired()
                        .HasColumnName("CreatedBy")
                        .HasMaxLength(255);

                    b.Property<DateTime>("_createdDate")
                        .HasColumnName("CreatedDate");

                    b.Property<string>("_updatedBy")
                        .HasColumnName("UpdatedBy")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("_updatedDate")
                        .HasColumnName("UpdatedDate");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("SavingTypes");
                });

            modelBuilder.Entity("HouseholdExpensesTrackerServer21.Domain.Expenses.Models.Expense", b =>
                {
                    b.HasOne("HouseholdExpensesTrackerServer21.Domain.Expenses.Models.ExpenseType")
                        .WithMany()
                        .HasForeignKey("ExpenseTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HouseholdExpensesTrackerServer21.Domain.Households.Models.Household")
                        .WithMany()
                        .HasForeignKey("HouseholdId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.OwnsOne("HouseholdExpensesTrackerServer21.Domain.Expenses.Models.Period", "Period", b1 =>
                        {
                            b1.Property<Guid?>("ExpenseId");

                            b1.Property<DateTime>("PeriodEnd");

                            b1.Property<DateTime>("PeriodStart");

                            b1.ToTable("Expenses");

                            b1.HasOne("HouseholdExpensesTrackerServer21.Domain.Expenses.Models.Expense")
                                .WithOne("Period")
                                .HasForeignKey("HouseholdExpensesTrackerServer21.Domain.Expenses.Models.Period", "ExpenseId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("HouseholdExpensesTrackerServer21.Domain.Expenses.Models.ExpenseType", b =>
                {
                    b.HasOne("HouseholdExpensesTrackerServer21.Domain.Identities.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("HouseholdExpensesTrackerServer21.Domain.Households.Models.Household", b =>
                {
                    b.HasOne("HouseholdExpensesTrackerServer21.Domain.Identities.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.OwnsOne("HouseholdExpensesTrackerServer21.Domain.Households.Models.Address", "Address", b1 =>
                        {
                            b1.Property<Guid?>("HouseholdId");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasMaxLength(255);

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasMaxLength(255);

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasMaxLength(255);

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasMaxLength(10);

                            b1.ToTable("Households");

                            b1.HasOne("HouseholdExpensesTrackerServer21.Domain.Households.Models.Household")
                                .WithOne("Address")
                                .HasForeignKey("HouseholdExpensesTrackerServer21.Domain.Households.Models.Address", "HouseholdId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("HouseholdExpensesTrackerServer21.Domain.Identities.Models.Credential", b =>
                {
                    b.HasOne("HouseholdExpensesTrackerServer21.Domain.Identities.Models.CredentialType")
                        .WithMany()
                        .HasForeignKey("CredentialTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HouseholdExpensesTrackerServer21.Domain.Identities.Models.User")
                        .WithMany("Credentials")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HouseholdExpensesTrackerServer21.Domain.Identities.Models.RolePermission", b =>
                {
                    b.HasOne("HouseholdExpensesTrackerServer21.Domain.Identities.Models.Permission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HouseholdExpensesTrackerServer21.Domain.Identities.Models.Role", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HouseholdExpensesTrackerServer21.Domain.Identities.Models.UserRole", b =>
                {
                    b.HasOne("HouseholdExpensesTrackerServer21.Domain.Identities.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HouseholdExpensesTrackerServer21.Domain.Identities.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HouseholdExpensesTrackerServer21.Domain.Savings.Models.Saving", b =>
                {
                    b.HasOne("HouseholdExpensesTrackerServer21.Domain.Households.Models.Household")
                        .WithMany()
                        .HasForeignKey("HouseholdId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HouseholdExpensesTrackerServer21.Domain.Savings.Models.SavingType")
                        .WithMany()
                        .HasForeignKey("SavingTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
