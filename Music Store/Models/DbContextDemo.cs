using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Music_Store.Models
{
    public class DbContextDemo : DbContext
    {
        public DbContextDemo()
        {
        }
        public DbContextDemo(DbContextOptions<DbContextDemo> options)
            : base(options)
        {
        }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Singer> Singers { get; set; }
        public DbSet<SingerSong> SingerSongs { get; set; }
        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SingerSong>().HasKey(sc => new { sc.SingerID, sc.SongID });
            modelBuilder.Entity<SingerSong>()
                .HasOne<Singer>(sc => sc.Singer)
                .WithMany(s => s.singerSongs)
                .HasForeignKey(sc => sc.SingerID);
            modelBuilder.Entity<SingerSong>()
                .HasOne<Song>(sc => sc.Song)
                .WithMany(s => s.singerSongs)
                .HasForeignKey(sc => sc.SongID);
        }
    }
}
