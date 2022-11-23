﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartHome.Models;

namespace SmartHome.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Baslik")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("A_Smarthomes");
                });

            modelBuilder.Entity("SmartHome.Database.AboutUsEkipUyleri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Meslek")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("ResimUrl")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("aboutUsEkipUyleriTablosu");
                });

            modelBuilder.Entity("SmartHome.Database.AboutUsForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FormMail")
                        .HasColumnType("text");

                    b.Property<string>("FormText")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("aboutUsFormTablosu");
                });

            modelBuilder.Entity("SmartHome.Database.AboutUsHizmetler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("HizmetText")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("aboutUsHizmetlerTablosu");
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

            modelBuilder.Entity("SmartHome.Database.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Aciklama")
                        .HasColumnType("text");

                    b.Property<bool>("AktifPasif")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Baslik")
                        .HasColumnType("text");

                    b.Property<int>("Goruntulenme")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<string>("Resim")
                        .HasColumnType("text");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("BlogTablosu");
                });

            modelBuilder.Entity("SmartHome.Database.BlogCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Aciklama")
                        .HasColumnType("text");

                    b.Property<string>("Baslik")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("BlokCategoryTablosu");
                });

            modelBuilder.Entity("SmartHome.Database.ConcatForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Ad")
                        .HasColumnType("text");

                    b.Property<string>("Mail")
                        .HasColumnType("text");

                    b.Property<string>("Mesaj")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("concatFormTablosu");
                });

            modelBuilder.Entity("SmartHome.Database.ConcatIletisim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Adres")
                        .HasColumnType("text");

                    b.Property<string>("Mail")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("concatIletisimTablosu");
                });

            modelBuilder.Entity("SmartHome.Database.Hq_technology", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Resim")
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

            modelBuilder.Entity("SmartHome.Database.Partners", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Gorev")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Partners_Con");
                });

            modelBuilder.Entity("SmartHome.Database.PartnersForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PartnersFormTable");
                });

            modelBuilder.Entity("SmartHome.Database.Services", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Services_a");
                });

            modelBuilder.Entity("SmartHome.Database.SingleProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Urun_ad")
                        .HasColumnType("text");

                    b.Property<string>("Urun_fiyat")
                        .HasColumnType("text");

                    b.Property<string>("Urun_fiyat_2")
                        .HasColumnType("text");

                    b.Property<string>("Urun_ozellik")
                        .HasColumnType("text");

                    b.Property<string>("Urun_ozellik_2")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("SingleProducts");
                });

            modelBuilder.Entity("SmartHome.Database.SupportCenter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Eposta")
                        .HasColumnType("text");

                    b.Property<string>("Saat")
                        .HasColumnType("text");

                    b.Property<string>("TelNo")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("SupportCenters");
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
