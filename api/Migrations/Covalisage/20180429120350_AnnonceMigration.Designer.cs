﻿// <auto-generated />
using api.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace api.Migrations.Covalisage
{
    [DbContext(typeof(CovalisageContext))]
    [Migration("20180429120350_AnnonceMigration")]
    partial class AnnonceMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("api.Domain.Annonce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Note");

                    b.Property<string>("UserId");

                    b.Property<string>("dateArrivee");

                    b.Property<string>("dateDepart");

                    b.Property<string>("lieuArrivee");

                    b.Property<string>("lieuDepart");

                    b.Property<int>("poidDisponible");

                    b.Property<decimal>("prixKg");

                    b.Property<string>("titre");

                    b.HasKey("Id");

                    b.ToTable("Annonces");
                });

            modelBuilder.Entity("api.Domain.Colis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Poid");

                    b.Property<decimal>("Prix");

                    b.Property<int>("UserId");

                    b.Property<string>("note");

                    b.HasKey("Id");

                    b.ToTable("Colis");
                });

            modelBuilder.Entity("api.Domain.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ColisId");

                    b.Property<int>("Qte");

                    b.Property<string>("name");

                    b.HasKey("Id");

                    b.HasIndex("ColisId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("api.Domain.Item", b =>
                {
                    b.HasOne("api.Domain.Colis")
                        .WithMany("listeItems")
                        .HasForeignKey("ColisId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
