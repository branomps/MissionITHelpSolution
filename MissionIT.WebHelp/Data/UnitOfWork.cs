using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MissionIT.WebHelp.Models;

namespace MissionIT.WebHelp.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HelpDbContext _context;

        public UnitOfWork(HelpDbContext context)
        {
            _context = context;
            Sections = new SectionRepository(_context);
            Articles = new ArticleRepository(_context);
        }

        public ISectionRepository Sections { get; set; }
        public IArticleRepository Articles { get; set; }

        public int Complete ()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
