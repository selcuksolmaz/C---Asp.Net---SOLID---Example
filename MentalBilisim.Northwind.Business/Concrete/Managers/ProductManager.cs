using MentalBilisim.Core.CrossCuttingConcerns.Validation.FluentValidation;
using MentalBilisim.Northwind.Business.Abstract;
using MentalBilisim.Northwind.Business.ValidationRules.FluentValidation;
using MentalBilisim.Northwind.DataAccess.Abstract;
using MentalBilisim.Northwind.Entities.Concrete;
using MentalBilisim.Core.Aspects.Postsharp.ValidationAspects;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using MentalBilisim.Core.Aspects.Postsharp.TransactionAspects;
using MentalBilisim.Core.Aspects.Postsharp.CacheAspects;
using MentalBilisim.Core.CrossCuttingConcerns.Caching.Microsoft;
using MentalBilisim.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using MentalBilisim.Core.Aspects.Postsharp.LogAspects;
using MentalBilisim.Core.Aspects.Postsharp.PerformanceAspects;
using MentalBilisim.Core.Aspects.Postsharp.AuthorizationAspects;
using System.Threading;

namespace MentalBilisim.Northwind.Business.Concrete.Managers
{

    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        [FluentValidationAspect(typeof(ProductValidatior))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Product Add(Product product)
        {
            
            return _productDal.Add(product);
        }
        [CacheAspect(typeof(MemoryCacheManager))]
        [PerformanceCounterAspect(2)]
        [SecuredOperation(Roles="Admin,Editor,Student")]
        public List<Product> GetAll()
        {
            Thread.Sleep(3000);
            return _productDal.GetList();
        }

        public Product GetById(int id)
        {
            return _productDal.GeT(p => p.ProductId == id);
        }
        [FluentValidationAspect(typeof(ProductValidatior))]
        [TransactionScopeAspect]
        public void TransactionalOperation(Product product1, Product product2)
        {

            _productDal.Add(product1);
            //Business Codes
            _productDal.Update(product2);
        }

        [FluentValidationAspect(typeof(ProductValidatior))]
        public Product Update(Product product)
        {
            
            return _productDal.Update(product);
        }
    }
}
