using MentalBilisim.Northwind.Business.Abstract;
using MentalBilisim.Northwind.DataAccess.Abstract;
using MentalBilisim.Northwind.Entities.ComplexTypes;
using MentalBilisim.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalBilisim.Northwind.Business.Concrete.Managers
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public User GetByUserNameAndPassword(string userName, string password)
        {
            return _userDal.GeT(u => u.UserName == userName & u.Password == password);
        }

        public List<UserRoleItem> GetUserRoles(User user)
        {
            return _userDal.GetUserRoles(user);
        }
    }
}
