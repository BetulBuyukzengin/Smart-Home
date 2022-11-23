﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartHome.Models;

namespace SmartHome.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220803120146_AsmarthomeMigration")]
    partial class AsmarthomeMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("SmartHome.Database.A_smarthome", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("A_Smarthomes");
                });

            modelBuilder.Entity("SmartHome.Database.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("text");

                    b.Property<string>("KullaniciSifre")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("SmartHome.Database.Hq_technology", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("hq_Technologies");
                });

            modelBuilder.Entity("SmartHome.Database.Kullanicilar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Ad")
                        .HasColumnType("text");

                    b.Property<string>("Mesaj")
                        .HasColumnType("text");

                    b.Property<string>("Posta")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("KullaniciTablo");
                });

            modelBuilder.Entity("SmartHome.Models.Banner2", b =>
                {
                    b.Property<int>("Idbanner2")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bn2text")
                        .HasColumnType("text");

                    b.Property<string>("CardText1")
                        .HasColumnType("text");

                    b.Property<string>("CardText2")
                        .HasColumnType("text");

                    b.Property<string>("CardText3")
                        .HasColumnType("text");

                    b.Property<string>("CardText4")
                        .HasColumnType("text");

                    b.Property<string>("CardText5")
                        .HasColumnType("text");

                    b.Property<string>("CardText6")
                        .HasColumnType("text");

                    b.Property<string>("CardText7")
                        .HasColumnType("text");

                    b.Property<string>("CardText8")
                        .HasColumnType("text");

                    b.HasKey("Idbanner2");

                    b.ToTable("Banner2s");
                });

            modelBuilder.Entity("SmartHome.Models.Banner6", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Callnow")
                        .HasColumnType("int");

                    b.Property<string>("Eml")
                        .HasColumnType("text");

                    b.Property<string>("Msg")
                        .HasColumnType("text");

                    b.Property<string>("Solaciklama")
                        .HasColumnType("text");

                    b.Property<string>("Solbaslik1")
                        .HasColumnType("text");

                    b.Property<string>("Submit")
                        .HasColumnType("text");

                    b.Property<string>("Yname")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Baner6s");
                });

            modelBuilder.Entity("SmartHome.Models.Swiper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Centered1")
                        .HasColumnType("text");

                    b.Property<string>("Centered2")
                        .HasColumnType("text");

                    b.Property<string>("Centered3")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Swipers");
                });

            modelBuilder.Entity("SmartHome.Models.Yorum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cardtext1")
                        .HasColumnType("text");

                    b.Property<string>("Cardtext2")
                        .HasColumnType("text");

                    b.Property<string>("Etiket")
                        .HasColumnType("text");

                    b.Property<string>("Etiketbaslik")
                        .HasColumnType("text");

                    b.Property<string>("Sahibi1")
                        .HasColumnType("text");

                    b.Property<string>("Sahibi2")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Yorums");
                });
#pragma warning restore 612, 618
        }
    }
}
