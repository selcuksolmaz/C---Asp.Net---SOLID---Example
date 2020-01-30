using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MentalBilisim.Core.Entities;
using NHibernate.Linq;


namespace MentalBilisim.Core.DataAccess.NHibernate
{
    public class NhEntityRepositoryBase<TEntity>:IEntityRepository<TEntity>
        where TEntity:class, IEntity, new()
    {
        private NHihabernateHelper _nHihabernateHelper;

        public NhEntityRepositoryBase(NHihabernateHelper nHihabernateHelper)
        {
            _nHihabernateHelper = nHihabernateHelper;
        }

        public TEntity Add(TEntity entity)
        {
            using (var session = _nHihabernateHelper.OpenSession()) 
            {
                session.Save(entity);
                return entity;
            }
        }

        public void Delete(TEntity entity)
        {
            using (var session = _nHihabernateHelper.OpenSession())
            {
                session.Delete(entity);
            }
        }

        public TEntity GeT(Expression<Func<TEntity, bool>> filter)
        {
            using (var session = _nHihabernateHelper.OpenSession())
            {
                return session.Query<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var session = _nHihabernateHelper.OpenSession())
            {
                return filter==null
                    ?session.Query<TEntity>().ToList()
                    :session.Query<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (var session = _nHihabernateHelper.OpenSession())
            {
                session.Update(entity);
                return entity;
            }
        }
    }
}
