using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MissionIT.WebHelp.Models;


namespace MissionIT.WebHelp.Data
{
    public class UnitOfWork
    {
        private HelpDbContext _context;

        
        
        public UnitOfWork(HelpDbContext context)
        {
            _context = context;
            Sections = new SectionRepository(get; set;) 
            Articles = new ArticleRepository { get; set; }
        }

        public ISectionRepository Sections { get; set; }
        public IArticleRepository Articles { get; set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
