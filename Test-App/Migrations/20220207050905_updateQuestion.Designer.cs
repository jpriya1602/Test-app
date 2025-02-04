﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Test_App.shared;

namespace Test_App.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220207050905_updateQuestion")]
    partial class updateQuestion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Test_App.question.entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int?>("PostedById")
                        .HasColumnType("integer");

                    b.Property<DateTime>("PostedTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("QuestionPosted")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PostedById");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Test_App.user.entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime>("AccountCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("EmailId")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Test_App.question.entities.Question", b =>
                {
                    b.HasOne("Test_App.user.entities.User", "PostedBy")
                        .WithMany()
                        .HasForeignKey("PostedById");

                    b.Navigation("PostedBy");
                });
#pragma warning restore 612, 618
        }
    }
}
