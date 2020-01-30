﻿using MentalBilisim.Core.DataAccess;
using MentalBilisim.Northwind.Entities.Concrete;
using MentalBilisim.Northwind.Entities.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalBilisim.Northwind.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetail> GetProductDetails();
    }
}
