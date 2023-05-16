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
        User, Role, Guid, IdentityUserClaim<Guid>, UserRole, IdentityUserLogin<Guid>, IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
    {
        public DbSet<Image> Images { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Conversation> Conversations { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameStuff> GameStuffs { get; set; }
        public DbSet<GameRole> GameRoles { get; set; }
        public DbSet<GameRank> GameRanks { get; set; }
        public DbSet<Slider> Sliders { get; set; }


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
                
        }
    }
}
