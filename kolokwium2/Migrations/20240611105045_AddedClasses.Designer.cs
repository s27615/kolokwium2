﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kolokwium2.Data;

#nullable disable

namespace kolokwium2.Migrations
{
    [DbContext(typeof(ApbdContext))]
    [Migration("20240611105045_AddedClasses")]
    partial class AddedClasses
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.4.24267.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("backpackscharacters", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("BackpacksCharacterId")
                        .HasColumnType("int");

                    b.Property<int>("BackpacksItemId")
                        .HasColumnType("int");

                    b.HasKey("CharacterId", "BackpacksCharacterId", "BackpacksItemId");

                    b.HasIndex("BackpacksCharacterId", "BackpacksItemId");

                    b.ToTable("backpackscharacters");
                });

            modelBuilder.Entity("backpacksitems", b =>
                {
                    b.Property<int>("ItemsId")
                        .HasColumnType("int");

                    b.Property<int>("BackpacksCharacterId")
                        .HasColumnType("int");

                    b.Property<int>("BackpacksItemId")
                        .HasColumnType("int");

                    b.HasKey("ItemsId", "BackpacksCharacterId", "BackpacksItemId");

                    b.HasIndex("BackpacksCharacterId", "BackpacksItemId");

                    b.ToTable("backpacksitems");
                });

            modelBuilder.Entity("character_titlescharacters", b =>
                {
                    b.Property<int>("CharactersId")
                        .HasColumnType("int");

                    b.Property<int>("CharacterTitlesCharacterId")
                        .HasColumnType("int");

                    b.Property<int>("CharacterTitlesTitleId")
                        .HasColumnType("int");

                    b.HasKey("CharactersId", "CharacterTitlesCharacterId", "CharacterTitlesTitleId");

                    b.HasIndex("CharacterTitlesCharacterId", "CharacterTitlesTitleId");

                    b.ToTable("character_titlescharacters");
                });

            modelBuilder.Entity("character_titlestitles", b =>
                {
                    b.Property<int>("TitlesId")
                        .HasColumnType("int");

                    b.Property<int>("CharacterTitlesCharacterId")
                        .HasColumnType("int");

                    b.Property<int>("CharacterTitlesTitleId")
                        .HasColumnType("int");

                    b.HasKey("TitlesId", "CharacterTitlesCharacterId", "CharacterTitlesTitleId");

                    b.HasIndex("CharacterTitlesCharacterId", "CharacterTitlesTitleId");

                    b.ToTable("character_titlestitles");
                });

            modelBuilder.Entity("kolokwium2.Models.backpacks", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.HasKey("CharacterId", "ItemId");

                    b.ToTable("Backpacks");
                });

            modelBuilder.Entity("kolokwium2.Models.character_titles", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("AcquiredAt")
                        .HasColumnType("datetime2");

                    b.HasKey("CharacterId", "TitleId");

                    b.ToTable("CharacterTitles");
                });

            modelBuilder.Entity("kolokwium2.Models.characters", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CurrentWei")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<int>("MaxWeight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("kolokwium2.Models.items", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("kolokwium2.Models.titles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Titles");
                });

            modelBuilder.Entity("backpackscharacters", b =>
                {
                    b.HasOne("kolokwium2.Models.characters", null)
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kolokwium2.Models.backpacks", null)
                        .WithMany()
                        .HasForeignKey("BackpacksCharacterId", "BackpacksItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("backpacksitems", b =>
                {
                    b.HasOne("kolokwium2.Models.items", null)
                        .WithMany()
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kolokwium2.Models.backpacks", null)
                        .WithMany()
                        .HasForeignKey("BackpacksCharacterId", "BackpacksItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("character_titlescharacters", b =>
                {
                    b.HasOne("kolokwium2.Models.characters", null)
                        .WithMany()
                        .HasForeignKey("CharactersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kolokwium2.Models.character_titles", null)
                        .WithMany()
                        .HasForeignKey("CharacterTitlesCharacterId", "CharacterTitlesTitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("character_titlestitles", b =>
                {
                    b.HasOne("kolokwium2.Models.titles", null)
                        .WithMany()
                        .HasForeignKey("TitlesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("kolokwium2.Models.character_titles", null)
                        .WithMany()
                        .HasForeignKey("CharacterTitlesCharacterId", "CharacterTitlesTitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
