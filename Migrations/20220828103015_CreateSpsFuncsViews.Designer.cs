﻿// <auto-generated />
using System;
using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    [DbContext(typeof(DoctorWhoCoreDbContext))]
    [Migration("20220828103015_CreateSpsFuncsViews")]
    partial class CreateSpsFuncsViews
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DoctorWho.Db.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"), 1L, 1);

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorName = "Musab"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorName = "Rayyan"
                        },
                        new
                        {
                            AuthorId = 3,
                            AuthorName = "Hamza"
                        },
                        new
                        {
                            AuthorId = 4,
                            AuthorName = "Bob"
                        },
                        new
                        {
                            AuthorId = 5,
                            AuthorName = "Dan"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Companion", b =>
                {
                    b.Property<int>("CompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanionId"), 1L, 1);

                    b.Property<string>("CompanionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhoPlayed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanionId");

                    b.ToTable("companions");

                    b.HasData(
                        new
                        {
                            CompanionId = 1,
                            CompanionName = "Freddy",
                            WhoPlayed = "Joe"
                        },
                        new
                        {
                            CompanionId = 2,
                            CompanionName = "Creddy",
                            WhoPlayed = "Moe"
                        },
                        new
                        {
                            CompanionId = 3,
                            CompanionName = "Leddy",
                            WhoPlayed = "Loe"
                        },
                        new
                        {
                            CompanionId = 4,
                            CompanionName = "Teddy",
                            WhoPlayed = "Row"
                        },
                        new
                        {
                            CompanionId = 5,
                            CompanionName = "Reddy",
                            WhoPlayed = "Bow"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("FirstEpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastEpisodeDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DoctorId");

                    b.ToTable("doctors");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            BirthDate = new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Dr.Langstrum",
                            DoctorNumber = 1,
                            FirstEpisodeDate = new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 2,
                            BirthDate = new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Dr.Viktor",
                            DoctorNumber = 2,
                            FirstEpisodeDate = new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 3,
                            BirthDate = new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Dr.Robotnik",
                            DoctorNumber = 3,
                            FirstEpisodeDate = new DateTime(2014, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 4,
                            BirthDate = new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Dr.Briggs",
                            DoctorNumber = 4,
                            FirstEpisodeDate = new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 5,
                            BirthDate = new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Dr.Doofenshmirtz",
                            DoctorNumber = 5,
                            FirstEpisodeDate = new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2017, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Enemy", b =>
                {
                    b.Property<int>("EnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnemyId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnemyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnemyId");

                    b.ToTable("enemies");

                    b.HasData(
                        new
                        {
                            EnemyId = 1,
                            Description = "Marching Pawn",
                            EnemyName = "Goomba"
                        },
                        new
                        {
                            EnemyId = 2,
                            Description = "Likes Shells",
                            EnemyName = "Koopa"
                        },
                        new
                        {
                            EnemyId = 3,
                            Description = "Throws Hammers",
                            EnemyName = "Hammer Man"
                        },
                        new
                        {
                            EnemyId = 4,
                            Description = "Throws Hammers",
                            EnemyName = "Hammer Man"
                        },
                        new
                        {
                            EnemyId = 5,
                            Description = "Uses Crayons",
                            EnemyName = "Crayola Man"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Episode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeId"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<string>("EpisodeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeriesNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EpisodeId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("episodes");

                    b.HasData(
                        new
                        {
                            EpisodeId = 1,
                            AuthorId = 1,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "Good",
                            Notes = "",
                            SeriesNumber = 1,
                            Title = "All Ends it Ends Well"
                        },
                        new
                        {
                            EpisodeId = 2,
                            AuthorId = 2,
                            DoctorId = 2,
                            EpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 2,
                            EpisodeType = "Ok",
                            Notes = "",
                            SeriesNumber = 2,
                            Title = "Darkness Rising"
                        },
                        new
                        {
                            EpisodeId = 3,
                            AuthorId = 3,
                            DoctorId = 3,
                            EpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 3,
                            EpisodeType = "Bad",
                            Notes = "",
                            SeriesNumber = 3,
                            Title = "Sun Shining"
                        },
                        new
                        {
                            EpisodeId = 4,
                            AuthorId = 4,
                            DoctorId = 4,
                            EpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 4,
                            EpisodeType = "Excellent",
                            Notes = "",
                            SeriesNumber = 4,
                            Title = "Last Stand"
                        },
                        new
                        {
                            EpisodeId = 5,
                            AuthorId = 5,
                            DoctorId = 5,
                            EpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 5,
                            EpisodeType = "Noice",
                            Notes = "",
                            SeriesNumber = 5,
                            Title = "One Chance Left"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.EpisodeCompanion", b =>
                {
                    b.Property<int>("EpisodeCompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeCompanionId"), 1L, 1);

                    b.Property<int>("CompanionId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeCompanionId");

                    b.HasIndex("CompanionId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("episodesCompanions");

                    b.HasData(
                        new
                        {
                            EpisodeCompanionId = 1,
                            CompanionId = 1,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeCompanionId = 2,
                            CompanionId = 2,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeCompanionId = 3,
                            CompanionId = 3,
                            EpisodeId = 3
                        },
                        new
                        {
                            EpisodeCompanionId = 4,
                            CompanionId = 4,
                            EpisodeId = 4
                        },
                        new
                        {
                            EpisodeCompanionId = 5,
                            CompanionId = 5,
                            EpisodeId = 5
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.EpisodeEnemy", b =>
                {
                    b.Property<int>("EpisodeEnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeEnemyId"), 1L, 1);

                    b.Property<int>("EnemyId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeEnemyId");

                    b.HasIndex("EnemyId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("episodesEnemies");

                    b.HasData(
                        new
                        {
                            EpisodeEnemyId = 1,
                            EnemyId = 1,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeEnemyId = 2,
                            EnemyId = 2,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeEnemyId = 3,
                            EnemyId = 3,
                            EpisodeId = 3
                        },
                        new
                        {
                            EpisodeEnemyId = 4,
                            EnemyId = 4,
                            EpisodeId = 4
                        },
                        new
                        {
                            EpisodeEnemyId = 5,
                            EnemyId = 5,
                            EpisodeId = 5
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Episode", b =>
                {
                    b.HasOne("DoctorWho.Db.Author", "author")
                        .WithMany("EpisodeList")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Doctor", "doctor")
                        .WithMany("EpisodeList")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("author");

                    b.Navigation("doctor");
                });

            modelBuilder.Entity("DoctorWho.Db.EpisodeCompanion", b =>
                {
                    b.HasOne("DoctorWho.Db.Companion", "companion")
                        .WithMany()
                        .HasForeignKey("CompanionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Episode", "episode")
                        .WithMany()
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("companion");

                    b.Navigation("episode");
                });

            modelBuilder.Entity("DoctorWho.Db.EpisodeEnemy", b =>
                {
                    b.HasOne("DoctorWho.Db.Enemy", "enemy")
                        .WithMany()
                        .HasForeignKey("EnemyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Episode", "episode")
                        .WithMany()
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("enemy");

                    b.Navigation("episode");
                });

            modelBuilder.Entity("DoctorWho.Db.Author", b =>
                {
                    b.Navigation("EpisodeList");
                });

            modelBuilder.Entity("DoctorWho.Db.Doctor", b =>
                {
                    b.Navigation("EpisodeList");
                });
#pragma warning restore 612, 618
        }
    }
}
