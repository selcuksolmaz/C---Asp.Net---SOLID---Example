﻿using MentalBilisim.Core.CrossCuttingConcerns.Security.Web;
using MentalBilisim.Northwind.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MentalBilisim.Northwind.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        // GET: Account
        public string Login(string userName,string password)
        {
            var user = _userService.GetByUserNameAndPassword(userName,password );
            if ( user != null)
            {
                AuthenticationHelper.CreateAuthCookie(
                new Guid(), user.UserName,
                user.Email,
                DateTime.Now.AddDays(15),
                _userService.GetUserRoles(user).Select(u=>u.RoleName).ToArray(),
                false,
                user.FirstName,
                user.LastName);
                return "User is authenticated!";
            }
            return "User is NOT authenticated!";
        }
    }
}