using MentalBilisim.Northwind.DataAccess.Abstract;
using MentalBilisim.Northwind.Entities.Concrete;
using MentalBilisim.Core.DataAccess.NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MentalBilisim.Northwind.Entities.ComplexTypes;

namespace MentalBilisim.Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : NhEntityRepositoryBase<Product>, IProductDal
    {
        private NHihabernateHelper _nHihabernateHelper;
        public NhProductDal(NHihabernateHelper nHihabernateHelper ) : base(nHihabernateHelper)
        {
            _nHihabernateHelper = nHihabernateHelper;
        }

        public List<ProductDetail> GetProductDetails()
        {
            using (var session = _nHihabernateHelper.OpenSession())
            {
                var result = from p in session.Query<Product>()
                             join c in session.Query<Category>() on p.CategoryId equals c.CategoryId
                             select new ProductDetail
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName
                             };
                return result.ToList();
            }
        }
    }
}
