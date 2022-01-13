﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EnfcGlog.Migrations
{
    [DbContext(typeof(EnfcGlogContext))]
    [Migration("20220113144140_m1")]
    partial class m1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("EnfcGlog.Models.Equipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PouleId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ecole")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("nbPoints")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PouleId");

                    b.ToTable("Equipe");
                });

            modelBuilder.Entity("EnfcGlog.Models.Joueur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EquipeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nom")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("numlicence")
                        .HasColumnType("TEXT");

                    b.Property<string>("prenom")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Joueur");
                });

            modelBuilder.Entity("EnfcGlog.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PouleId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("coteMNul")
                        .HasColumnType("REAL");

                    b.Property<double>("coteVictoireE1")
                        .HasColumnType("REAL");

                    b.Property<double>("coteVictoireE2")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("dateDuMatch")
                        .HasColumnType("TEXT");

                    b.Property<string>("equipe1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("equipe2")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("scoreEquipe1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("scoreEquipe2")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PouleId");

                    b.ToTable("Match");
                });

            modelBuilder.Entity("EnfcGlog.Models.Poule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Poule");
                });

            modelBuilder.Entity("EnfcGlog.Models.Equipe", b =>
                {
                    b.HasOne("EnfcGlog.Models.Poule", null)
                        .WithMany("classement")
                        .HasForeignKey("PouleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EnfcGlog.Models.Match", b =>
                {
                    b.HasOne("EnfcGlog.Models.Poule", null)
                        .WithMany("lesMatchs")
                        .HasForeignKey("PouleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EnfcGlog.Models.Poule", b =>
                {
                    b.Navigation("classement");

                    b.Navigation("lesMatchs");
                });
#pragma warning restore 612, 618
        }
    }
}
