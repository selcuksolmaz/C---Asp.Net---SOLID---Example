using MentalBilisim.Core.DataAccess.NHibernate;
using MentalBilisim.Northwind.DataAccess.Abstract;
using MentalBilisim.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalBilisim.Northwind.DataAccess.Concrete.NHibernate
{
    public class NhCategoryDal : NhEntityRepositoryBase<Category>, ICategoryDal
    {
        public NhCategoryDal(NHihabernateHelper nHihabernateHelper) : base(nHihabernateHelper)
        {
        }
    }
}
