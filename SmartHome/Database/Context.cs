using Microsoft.EntityFrameworkCore;
using SmartHome.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Swiper> Swipers { get; set; }
        public DbSet<Banner2> Banner2s { get; set; }
        public DbSet<Yorum> Yorums { get; set; }
        public DbSet<Banner6> Baner6s { get; set; }
        public DbSet<Kullanicilar> KullaniciTablo { get; set; }
        public DbSet<Admin> Admins { get; set; } //Admin paneli icin
        public DbSet<Hq_technology> hq_Technologies { get; set; }
        public DbSet<A_smarthome> A_Smarthomes { get; set; }
        public DbSet<Services> Services_a { get; set; }
        public DbSet<SingleProduct> SingleProducts { get; set; }
        public DbSet<SupportCenter> SupportCenters { get; set; } //SupportCenters, mysql de tablo ismi 
        public DbSet<Partners> Partners_Con { get; set; }
        public DbSet<PartnersForm> PartnersFormTable { get; set; }
        public DbSet<AboutUsEkipUyleri> aboutUsEkipUyleriTablosu { get; set; }
        public DbSet<AboutUsForm> aboutUsFormTablosu { get; set; }
        public DbSet<AboutUsHizmetler> aboutUsHizmetlerTablosu { get; set; }
        public DbSet<ConcatForm> concatFormTablosu { get; set; }
        public DbSet<ConcatIletisim> concatIletisimTablosu { get; set; }
        public DbSet<Blog> BlogTablosu { get; set; }
        public DbSet<BlogCategory> BlokCategoryTablosu { get; set; }

    }
}
