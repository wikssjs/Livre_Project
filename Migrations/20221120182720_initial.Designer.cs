﻿// <auto-generated />
using Livre_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LivreProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221120182720_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Livre_Project.Models.Livre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Auteur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Livres");
                });

            modelBuilder.Entity("Livre_Project.Models.Livre_Utilisateur", b =>
                {
                    b.Property<int>("UtilisateurId")
                        .HasColumnType("int");

                    b.Property<int>("LivreId")
                        .HasColumnType("int");

                    b.HasKey("UtilisateurId", "LivreId");

                    b.HasIndex("LivreId");

                    b.ToTable("Livres_Utilisateurs");
                });

            modelBuilder.Entity("Livre_Project.Models.Utilisateur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Utilisateurs");
                });

            modelBuilder.Entity("Livre_Project.Models.Livre_Utilisateur", b =>
                {
                    b.HasOne("Livre_Project.Models.Livre", "Livre")
                        .WithMany("Livre_Utilisateur")
                        .HasForeignKey("LivreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Livre_Project.Models.Utilisateur", "Utilisateur")
                        .WithMany("Livres_Utilisateurs")
                        .HasForeignKey("UtilisateurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livre");

                    b.Navigation("Utilisateur");
                });

            modelBuilder.Entity("Livre_Project.Models.Livre", b =>
                {
                    b.Navigation("Livre_Utilisateur");
                });

            modelBuilder.Entity("Livre_Project.Models.Utilisateur", b =>
                {
                    b.Navigation("Livres_Utilisateurs");
                });
#pragma warning restore 612, 618
        }
    }
}