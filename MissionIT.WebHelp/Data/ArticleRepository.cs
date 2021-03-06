﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MissionIT.WebHelp.Models;

namespace MissionIT.WebHelp.Data
{
    public class ArticleRepository : Repository<Article>, IArticleRepository
    {
        public ArticleRepository(HelpDbContext context)
            : base(context)
        {

        }

        public HelpDbContext HelpDbContext
        {
            get { return Context as HelpDbContext; }
            //set { HelpDbContext = value; }
        }
        
        public IEnumerable<Article> GetArticleWithSection()
        {
            return HelpDbContext.Articles.ToList();
        }
    }
}
