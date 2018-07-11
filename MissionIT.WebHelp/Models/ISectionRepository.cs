using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MissionIT.WebHelp.Models
{
    public interface ISectionRepository : IRepository<Section>
    {
        Section GetSectionWithArticles(int id);
    }
}
