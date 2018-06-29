﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MissionIT.WebHelp.Models;

namespace MissionIT.WebHelp.Models
{
    public interface ISectionRepository : IDataRepository<Section>
    {
        IEnumerable<Section> GetSectionsWithArticles();
    }
}
