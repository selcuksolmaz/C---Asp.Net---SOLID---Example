using MentalBilisim.Core.DataAccess.EntityFramework;
using MentalBilisim.Northwind.DataAccess.Abstract;
using MentalBilisim.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalBilisim.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryDal
    {

    }
}
