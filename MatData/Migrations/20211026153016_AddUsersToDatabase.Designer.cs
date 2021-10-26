﻿// <auto-generated />
using System;
using MatData.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MatData.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211026153016_AddUsersToDatabase")]
    partial class AddUsersToDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("MatData.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Icon")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MatData.Models.Indicator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("ThemeId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("ThemeId");

                    b.ToTable("Indicators");
                });

            modelBuilder.Entity("MatData.Models.IndicatorResponse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Data")
                        .HasColumnType("text");

                    b.Property<int?>("IndicatorId")
                        .HasColumnType("integer");

                    b.Property<int?>("MunicipeId")
                        .HasColumnType("integer");

                    b.Property<int?>("NeighborhoodVillageId")
                        .HasColumnType("integer");

                    b.Property<int?>("ProvinceId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("UrbanDistrictCommuneId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IndicatorId");

                    b.HasIndex("MunicipeId");

                    b.HasIndex("NeighborhoodVillageId");

                    b.HasIndex("ProvinceId");

                    b.HasIndex("UrbanDistrictCommuneId");

                    b.ToTable("IndicatorResponses");
                });

            modelBuilder.Entity("MatData.Models.Municipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("ProvinceId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("ProvinceId");

                    b.ToTable("Municipes");
                });

            modelBuilder.Entity("MatData.Models.NeighborhoodVillage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("UrbanDistrictCommuneId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UrbanDistrictCommuneId");

                    b.ToTable("NeighborhoodVillages");
                });

            modelBuilder.Entity("MatData.Models.Province", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("MatData.Models.Theme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("CodName")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Themes");
                });

            modelBuilder.Entity("MatData.Models.UrbanDistrictCommune", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("MunicipeId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("MunicipeId");

                    b.ToTable("UrbanDistrictCommunes");
                });

            modelBuilder.Entity("MatData.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MatData.Models.Indicator", b =>
                {
                    b.HasOne("MatData.Models.Theme", "Theme")
                        .WithMany("Indicator")
                        .HasForeignKey("ThemeId");

                    b.Navigation("Theme");
                });

            modelBuilder.Entity("MatData.Models.IndicatorResponse", b =>
                {
                    b.HasOne("MatData.Models.Indicator", "Indicator")
                        .WithMany()
                        .HasForeignKey("IndicatorId");

                    b.HasOne("MatData.Models.Municipe", "Municipe")
                        .WithMany()
                        .HasForeignKey("MunicipeId");

                    b.HasOne("MatData.Models.NeighborhoodVillage", "NeighborhoodVillage")
                        .WithMany()
                        .HasForeignKey("NeighborhoodVillageId");

                    b.HasOne("MatData.Models.Province", "Province")
                        .WithMany()
                        .HasForeignKey("ProvinceId");

                    b.HasOne("MatData.Models.UrbanDistrictCommune", "UrbanDistrictCommune")
                        .WithMany()
                        .HasForeignKey("UrbanDistrictCommuneId");

                    b.Navigation("Indicator");

                    b.Navigation("Municipe");

                    b.Navigation("NeighborhoodVillage");

                    b.Navigation("Province");

                    b.Navigation("UrbanDistrictCommune");
                });

            modelBuilder.Entity("MatData.Models.Municipe", b =>
                {
                    b.HasOne("MatData.Models.Province", "Province")
                        .WithMany()
                        .HasForeignKey("ProvinceId");

                    b.Navigation("Province");
                });

            modelBuilder.Entity("MatData.Models.NeighborhoodVillage", b =>
                {
                    b.HasOne("MatData.Models.UrbanDistrictCommune", "UrbanDistrictCommune")
                        .WithMany()
                        .HasForeignKey("UrbanDistrictCommuneId");

                    b.Navigation("UrbanDistrictCommune");
                });

            modelBuilder.Entity("MatData.Models.Theme", b =>
                {
                    b.HasOne("MatData.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MatData.Models.UrbanDistrictCommune", b =>
                {
                    b.HasOne("MatData.Models.Municipe", "Municipe")
                        .WithMany()
                        .HasForeignKey("MunicipeId");

                    b.Navigation("Municipe");
                });

            modelBuilder.Entity("MatData.Models.Theme", b =>
                {
                    b.Navigation("Indicator");
                });
#pragma warning restore 612, 618
        }
    }
}
