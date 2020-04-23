using Account.Manager.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace Account.Manager.Repository.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<Sms> Sms { get; set; }
        public DbSet<UserProfileRole> UserProfileRoles { get; set; }
        public DbSet<EmailHash> EmailHashes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasMany(e => e.UserProfiles).WithOne(e => e.User).HasForeignKey(e => e.UserId).IsRequired();

            builder.Entity<UserProfile>()
                .HasMany(e => e.Tokens)
                .WithOne(e => e.UserProfile)
                .HasForeignKey(e => e.UserProfileId)
                .IsRequired();
            builder.Entity<UserProfile>()
                .HasMany(e => e.Sms)
                .WithOne(e => e.UserProfile)
                .HasForeignKey(e => e.UserProfileId)
                .IsRequired();
            builder.Entity<UserProfile>()
                .HasMany(e => e.EmailHashes)
                .WithOne(e => e.UserProfile)
                .HasForeignKey(e => e.UserProfileId)
                .IsRequired();

            builder.Entity<UserProfile>()
                .HasMany(e => e.UserProfileRoles)
                .WithOne(e => e.UserProfile)
                .HasForeignKey(e => e.UserProfileId)
                .IsRequired();

            builder.Entity<Company>()
                .HasMany(e => e.UserProfileRoles)
                .WithOne(e => e.Company)
                .HasForeignKey(e => e.CompanyId)
                .IsRequired();
            //builder.Entity<UserProfile>().HasMany(e => e.UserProfileRoles).WithOne(e => e.UserProfile).HasForeignKey(e => e.UserProfile).IsRequired(); 
            builder.Entity<Role>()
                .HasMany(e => e.UserProfileRoles)
                .WithOne(e => e.Role)
                .HasForeignKey(e => e.RoleId)
                .IsRequired();

            base.OnModelCreating(builder);
        }
    }
}
