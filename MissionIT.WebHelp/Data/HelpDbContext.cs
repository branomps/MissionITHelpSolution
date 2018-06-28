using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MissionIT.WebHelp.Models;

namespace MissionIT.WebHelp.Data
{
    public class HelpDbContext : DbContext
    {
        public DbSet<Section> Sections { get; set; }
        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Section>().ToTable("tblSections");
            modelBuilder.Entity<Article>().ToTable("tblArticles");
        }
    }
}
