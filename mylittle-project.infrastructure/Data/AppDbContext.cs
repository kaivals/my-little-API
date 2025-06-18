using Microsoft.EntityFrameworkCore;
using mylittle_project.Domain.Entities;



namespace mylittle_project.infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Branding> Brandings { get; set; }
        public DbSet<ContentSettings> ContentSettings { get; set; }
        public DbSet<FeatureSettings> FeatureSettings { get; set; }
        public DbSet<DomainSettings> DomainSettings { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }
        // If you have other entities like Subscription, Filter, etc. add them too
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Filter> Filters { get; set; }
        public DbSet<BrandingText> BrandingTexts { get; set; }
        public DbSet<BrandingMedia> BrandingMedia { get; set; }

        public DbSet<Productandlisting> Products { get; set; }


    }
}

