using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MissionIT.WebHelp.Models;

namespace MissionIT.WebHelp.Data
{
    public class SectionRepository : Repository<Section>, ISectionRepository 
    {
        public SectionRepository(HelpDbContext context)
            : base(context)
        {

        }

        public HelpDbContext HelpDbContext
        {
            get { return Context as HelpDbContext; }
           // set { HelpDbContext = value; }
        }
        
        Section ISectionRepository.GetSectionWithArticles(int id)
        {
            return HelpDbContext.Sections.Include(a => a.SectionID == id).SingleOrDefault(a => a.SectionID == id);
        }
    }
}
