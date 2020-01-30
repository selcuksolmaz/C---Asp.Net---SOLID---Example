using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MentalBilisim.Core.Entities;

namespace MentalBilisim.Core.DataAccess
{
    public interface IQueryableRepository<T> where T:class ,IEntity, new()
    {
        IQueryable<T> Table { get; }
    }
}
