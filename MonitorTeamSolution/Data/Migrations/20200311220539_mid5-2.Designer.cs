﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MonitorTeamSolution.Data;

namespace MonitorTeamSolution.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200311220539_mid5-2")]
    partial class mid52
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ApplicationUserId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MonitorTeamSolution.Models.Entities.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PageCreateVMId");

                    b.Property<int?>("PageDeleteVMId");

                    b.Property<int?>("PageEditVMId");

                    b.Property<int?>("PageInfoId");

                    b.Property<int?>("PageListVMId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("PageCreateVMId");

                    b.HasIndex("PageDeleteVMId");

                    b.HasIndex("PageEditVMId");

                    b.HasIndex("PageInfoId");

                    b.HasIndex("PageListVMId");

                    b.HasIndex("UserId");

                    b.ToTable("ApplicationUser");
                });

            modelBuilder.Entity("MonitorTeamSolution.Models.Entities.Logs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NumberOfPageViews");

                    b.Property<int?>("PageCreateVMId");

                    b.Property<int?>("PageDeleteVMId");

                    b.Property<int?>("PageEditVMId");

                    b.Property<int?>("PageInfoId");

                    b.Property<int?>("PageListVMId");

                    b.Property<string>("PageTitle");

                    b.Property<string>("SessionDuration");

                    b.Property<string>("TimeLoggedIn");

                    b.Property<string>("TimeLoggedOut");

                    b.Property<string>("TimeStamp");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("PageCreateVMId");

                    b.HasIndex("PageDeleteVMId");

                    b.HasIndex("PageEditVMId");

                    b.HasIndex("PageInfoId");

                    b.HasIndex("PageListVMId");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("MonitorTeamSolution.Models.Entities.PageInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PageTitle");

                    b.Property<string>("TimeStamp");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("MonitorTeamSolution.Models.ViewModels.LogCreateVM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NumberOfPageViews");

                    b.Property<string>("PageTitle");

                    b.Property<string>("SessionDuration");

                    b.Property<string>("TimeLoggedIn");

                    b.Property<string>("TimeLoggedOut");

                    b.Property<string>("TimeStamp");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("LogCreateVM");
                });

            modelBuilder.Entity("MonitorTeamSolution.Models.ViewModels.LogDeleteVM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NumberOfPageViews");

                    b.Property<string>("PageTitle");

                    b.Property<string>("SessionDuration");

                    b.Property<string>("TimeLoggedIn");

                    b.Property<string>("TimeLoggedOut");

                    b.Property<string>("TimeStamp");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("LogDeleteVM");
                });

            modelBuilder.Entity("MonitorTeamSolution.Models.ViewModels.LogEditVM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NumberOfPageViews");

                    b.Property<string>("PageTitle");

                    b.Property<string>("SessionDuration");

                    b.Property<string>("TimeLoggedIn");

                    b.Property<string>("TimeLoggedOut");

                    b.Property<string>("TimeStamp");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("LogEditVM");
                });

            modelBuilder.Entity("MonitorTeamSolution.Models.ViewModels.LogListVM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NumberOfPageViews");

                    b.Property<string>("PageTitle");

                    b.Property<string>("SessionDuration");

                    b.Property<string>("TimeLoggedIn");

                    b.Property<string>("TimeLoggedOut");

                    b.Property<string>("TimeStamp");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("LogListVM");
                });

            modelBuilder.Entity("MonitorTeamSolution.Models.ViewModels.PageCreateVM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PageTitle");

                    b.Property<string>("TimeStamp");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("PageCreateVM");
                });

            modelBuilder.Entity("MonitorTeamSolution.Models.ViewModels.PageDeleteVM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PageTitle");

                    b.Property<string>("TimeStamp");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("PageDeleteVM");
                });

            modelBuilder.Entity("MonitorTeamSolution.Models.ViewModels.PageEditVM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PageTitle");

                    b.Property<string>("TimeStamp");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("PageEditVM");
                });

            modelBuilder.Entity("MonitorTeamSolution.Models.ViewModels.PageListVM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PageTitle");

                    b.Property<string>("TimeStamp");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("PageListVM");
                });

            modelBuilder.Entity("MonitorTeamSolution.Models.ViewModels.UserListVM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<int>("NumberOfRoles");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("UserListVM");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.HasOne("MonitorTeamSolution.Models.Entities.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MonitorTeamSolution.Models.Entities.ApplicationUser", b =>
                {
                    b.HasOne("MonitorTeamSolution.Models.ViewModels.PageCreateVM")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("PageCreateVMId");

                    b.HasOne("MonitorTeamSolution.Models.ViewModels.PageDeleteVM")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("PageDeleteVMId");

                    b.HasOne("MonitorTeamSolution.Models.ViewModels.PageEditVM")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("PageEditVMId");

                    b.HasOne("MonitorTeamSolution.Models.Entities.PageInfo")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("PageInfoId");

                    b.HasOne("MonitorTeamSolution.Models.ViewModels.PageListVM")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("PageListVMId");

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("MonitorTeamSolution.Models.Entities.Logs", b =>
                {
                    b.HasOne("MonitorTeamSolution.Models.ViewModels.PageCreateVM")
                        .WithMany("LogList")
                        .HasForeignKey("PageCreateVMId");

                    b.HasOne("MonitorTeamSolution.Models.ViewModels.PageDeleteVM")
                        .WithMany("LogList")
                        .HasForeignKey("PageDeleteVMId");

                    b.HasOne("MonitorTeamSolution.Models.ViewModels.PageEditVM")
                        .WithMany("LogList")
                        .HasForeignKey("PageEditVMId");

                    b.HasOne("MonitorTeamSolution.Models.Entities.PageInfo")
                        .WithMany("LogList")
                        .HasForeignKey("PageInfoId");

                    b.HasOne("MonitorTeamSolution.Models.ViewModels.PageListVM")
                        .WithMany("LogList")
                        .HasForeignKey("PageListVMId");
                });
#pragma warning restore 612, 618
        }
    }
}
