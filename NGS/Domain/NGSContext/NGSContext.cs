using Domain.Consts;
using Domain.Entities;
using Domain.Entities.Base;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.NGSContext
{
    public class NGSContext : IdentityDbContext<
        User, Role, Guid>
    {
        public DbSet<Image> Images =>Set<Image>();
        public DbSet<Message> Messages => Set<Message>();
        public DbSet<Conversation> Conversations => Set<Conversation>();
        public DbSet<Game> Games => Set<Game>();
        public DbSet<GameStuff> GameStuffs => Set<GameStuff>();
        public DbSet<GameRole> GameRoles => Set<GameRole>();
        public DbSet<GameRank> GameRanks => Set<GameRank>();
        public DbSet<Slider> Sliders => Set<Slider>();
        public DbSet<Section> Sections => Set<Section>();
        public DbSet<MainSection> MainSections => Set<MainSection>();
        public DbSet<GameTeam> GameTeams => Set<GameTeam>();
        public DbSet<Invitation> Invations => Set<Invitation>();
        public DbSet<GameTeamInvitation> GameTeamInvitations => Set<GameTeamInvitation>();
        public DbSet<SiteConfiguration> SiteConfiguration => Set<SiteConfiguration>();


        public NGSContext(DbContextOptions<NGSContext> options) : base(options)
        { }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);            

            builder.Entity<Image>()
                .Property(e => e.ImageSource)
                .HasConversion(new EnumToStringConverter<ImageSourcePossibility>());

            builder.Entity<GameStuff>()
                .Property("Discriminator")
                .HasMaxLength(200);
            builder.Entity<GameStuff>()
                .HasDiscriminator<string>("StuffType")
                .HasValue<GameRole>("GameRole")
                .HasValue<GameRank>("GameRank");

            builder.Entity<Section>()
                .Property("Discriminator")
                .HasMaxLength(200);
            builder.Entity<Section>()
                .HasDiscriminator<string>("Discriminator")
                .HasValue<MainSection>("MainSection");

            builder.Entity<Invitation>()
                .Property("Discriminator")
                .HasMaxLength(200);
            builder.Entity<Invitation>()
                .HasDiscriminator<string>("Discriminator")
                .HasValue<GameTeamInvitation>("GameTeam");
        }
    }
}
