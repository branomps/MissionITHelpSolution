using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MissionIT.WebHelp.Models;

namespace MissionIT.WebHelp.Models
{
     public interface IUnitOfWork : IDisposable
    {
        ISectionRepository Sections { get; }
        IArticleRepository Articles { get; }
        int Complete();
    }
}
