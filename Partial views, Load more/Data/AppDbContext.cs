using Microsoft.EntityFrameworkCore;
using PurpleBuzz.Models;

namespace PurpleBuzz.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<SliderImage> SliderImages { get; set; }
        public DbSet<SliderInfo> SliderInfos { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Banner> Banners{ get; set; }
        public DbSet<TeamMember> TeamMembers{ get; set; }
        public DbSet<TeamMemberHeader> TeamMemberHeaders{ get; set; }
        public DbSet<WhyUsBanner> WhyUsBanners{ get; set; }
        public DbSet<ObjectiveBanner> ObjectiveBanners{ get; set; }
        public DbSet<Subscribe> Subscribes{ get; set; }
        public DbSet<Partner> Partners{ get; set; }
        public DbSet<PricingOffer> PricingOffers{ get; set; }
        public DbSet<PricingTitle> PricingTitles { get; set; }
        public DbSet<PricingHeader> PricingHeaders { get; set; }
        public DbSet<ContactBanner> ContactBanners { get; set; }
        public DbSet<ContactHeader> ContactHeaders { get; set; }
        public DbSet<Contact> Contacts { get; set; }

    }
}
