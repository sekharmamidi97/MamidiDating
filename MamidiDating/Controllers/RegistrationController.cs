using MamidiDating.Crypto;
using MamidiDating.DAL;
using MamidiDating.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MamidiDating.Controllers
{
    public class RegistrationController : MamidiDatingController
    {
        //private readonly IRegistrationDAL registrationDAL;
        //private readonly ILoginDAL loginDAL;
        //private const string UsernameKey = "UsernameKey";
        //public RegistrationController(IRegistrationDAL registrationDAL, ILoginDAL loginDAL)
        //{
        //    this.registrationDAL = registrationDAL;
        //    this.loginDAL = loginDAL;
        //}

        //public RegistrationController()
        //{

        //}

        //// GET: Registration
        //[HttpGet]
        //public ActionResult Registration()
        //{
        //    if (IsAuthenticated)
        //    {
        //        return RedirectToAction("Index", "Home");
        //    }
        //    else
        //    {
        //        var model = new RegistrationViewModel();
        //        return View("Registration", model);
        //    }
        //}

        //[HttpPost]
        //public ActionResult Registration(RegistrationViewModel model)
        //{
        //    if (IsAuthenticated)
        //    {
        //        return RedirectToAction("Index", "Home");
        //    }
        //    if (ModelState.IsValid)
        //    {
        //        var user = loginDAL.GetUsername(model.Username);
        //        if (user != null)
        //        {
        //            ModelState.AddModelError("Username", "This username is unavailable.");
        //            return View("Registration", model);
        //        }
        //        var hashProvider = new HashProvider();
        //        var hashedPassword = hashProvider.HashPassword(model.Password);
        //        var salt = hashProvider.SaltValue;

        //        var registeredUser = new LoginViewModel
        //        {
        //            Username = model.Username,
        //            Password = hashedPassword,
        //            Salt = salt

        //        };

        //        loginDAL.RegisterUser(registeredUser);
        //        return RedirectToAction("Login", "Login");
        //    }
        //    return View("Registration");
        //}

        ////Get AddRegistrationInfo
        //public ActionResult AddRegistrationInfo()
        //{
        //    return View("Registration");
        //}

        //[HttpPost]
        //public ActionResult AddRegistrationInfo(RegistrationViewModel registrationInfo)
        //{
        //    if(registrationInfo.FirstName == null)
        //    {
        //        registrationInfo.FirstName = "";
        //    }
        //    if(registrationInfo.LastName == null)
        //    {
        //        registrationInfo.LastName = "";
        //    }
        //    if(registrationInfo.EmailAddress == null)
        //    {
        //        registrationInfo.EmailAddress = "";
        //    }
        //    if(registrationInfo.Month == null)
        //    {
        //        registrationInfo.Month = "";
        //    }
        //    if(registrationInfo.Day == null)
        //    {
        //        registrationInfo.Day = "";

        //    }
        //    if(registrationInfo.Year == null)
        //    {
        //        registrationInfo.Year = "";
        //    }
        //    if(registrationInfo.Age == null)
        //    {
        //        registrationInfo.Age = "";
        //    }
        //    if(registrationInfo.IsYes == false)
        //    {
        //        registrationInfo.IsYes = true;
        //    }
        //    registrationDAL.AddRegistrationInfo(registrationInfo);
        //    return RedirectToAction("Login");
        //}

    }
}