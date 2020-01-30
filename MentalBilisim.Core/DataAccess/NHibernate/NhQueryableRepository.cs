using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MentalBilisim.Core.Entities;

namespace MentalBilisim.Core.DataAccess.NHibernate
{
    public class NhQueryableRepository<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        private NHihabernateHelper _nHihabernateHelper;
        private IQueryable<T> _entities;
        
        public NhQueryableRepository(NHihabernateHelper nHihabernateHelper)
        {
            _nHihabernateHelper = nHihabernateHelper;
        }

        public IQueryable<T> Table
        {
            get
               {
                return this.Entities;
               }
        }

        public virtual IQueryable<T> Entities
        {
            get
            {
                if(_entities==null)
                {
                    _entities = _nHihabernateHelper.OpenSession().Query<T>();
                }
                return _entities;
            }
        }

    }
}
