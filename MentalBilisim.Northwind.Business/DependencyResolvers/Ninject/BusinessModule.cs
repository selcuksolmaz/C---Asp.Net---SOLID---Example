using MentalBilisim.Core.DataAccess;
using MentalBilisim.Core.DataAccess.EntityFramework;
using MentalBilisim.Core.DataAccess.NHibernate;
using MentalBilisim.Northwind.Business.Abstract;
using MentalBilisim.Northwind.Business.Concrete.Managers;
using MentalBilisim.Northwind.DataAccess.Abstract;
using MentalBilisim.Northwind.DataAccess.Concrete.EntityFramework;
using MentalBilisim.Northwind.DataAccess.Concrete.NHibernate.Helpers;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace MentalBilisim.Northwind.Business.DependencyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

            Bind<IUserService>().To<UserManager>();
            Bind<IUserDal>().To<EfUserDal>();

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<NorthwindContext>();
            Bind<NHihabernateHelper>().To<SqlServerHelper>();
        }
    }
}
