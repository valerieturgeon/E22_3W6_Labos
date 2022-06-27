﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZombieParty_DataAccess.Data;

namespace ZombieParty_DataAccess.Migrations
{
    [DbContext(typeof(ZombiePartyDbContext))]
    partial class ZombiePartyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ZombieParty_Models.Hunter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Biography")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nickname")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Hunter");
                });

            modelBuilder.Entity("ZombieParty_Models.HuntingLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AdventureDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HunterId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HunterId");

                    b.ToTable("HuntingLog");
                });

            modelBuilder.Entity("ZombieParty_Models.Zombie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Point")
                        .HasColumnType("int");

                    b.Property<string>("ShortDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZombieTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ZombieTypeId");

                    b.ToTable("Zombie");
                });

            modelBuilder.Entity("ZombieParty_Models.ZombieHuntingLog", b =>
                {
                    b.Property<int>("Zombie_Id")
                        .HasColumnType("int");

                    b.Property<int>("HuntingLog_Id")
                        .HasColumnType("int");

                    b.HasKey("Zombie_Id", "HuntingLog_Id");

                    b.HasIndex("HuntingLog_Id");

                    b.ToTable("ZombieHuntingLog");
                });

            modelBuilder.Entity("ZombieParty_Models.ZombieType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ZombieType");
                });

            modelBuilder.Entity("ZombieParty_Models.HuntingLog", b =>
                {
                    b.HasOne("ZombieParty_Models.Hunter", "Hunter")
                        .WithMany("HuntingLogs")
                        .HasForeignKey("HunterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hunter");
                });

            modelBuilder.Entity("ZombieParty_Models.Zombie", b =>
                {
                    b.HasOne("ZombieParty_Models.ZombieType", "ZombieType")
                        .WithMany("Zombies")
                        .HasForeignKey("ZombieTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ZombieType");
                });

            modelBuilder.Entity("ZombieParty_Models.ZombieHuntingLog", b =>
                {
                    b.HasOne("ZombieParty_Models.HuntingLog", "HuntingLog")
                        .WithMany()
                        .HasForeignKey("HuntingLog_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZombieParty_Models.Zombie", "Zombie")
                        .WithMany("zombieHuntingLogs")
                        .HasForeignKey("Zombie_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HuntingLog");

                    b.Navigation("Zombie");
                });

            modelBuilder.Entity("ZombieParty_Models.Hunter", b =>
                {
                    b.Navigation("HuntingLogs");
                });

            modelBuilder.Entity("ZombieParty_Models.Zombie", b =>
                {
                    b.Navigation("zombieHuntingLogs");
                });

            modelBuilder.Entity("ZombieParty_Models.ZombieType", b =>
                {
                    b.Navigation("Zombies");
                });
#pragma warning restore 612, 618
        }
    }
}
