using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ihff.Models;
using ihff.Repositories;

namespace ihff.Controllers
{
    public class AccountController : Controller
    {
        //Gebruik van inMemory. Deze regel kan later worden omgezet naar een interface met DBContext
        private IAccountRepository AccountRepository = new InMemoryAccountRepository();


        public ActionResult Index()
        {
            ViewBag.Message = "Index.";

            return View();
        }

        public ActionResult LogIn()
        {
            ViewBag.Message = "Log in.";

            return View();
        }

        [HttpPost]
        public ActionResult LogIn(LoginViewModel LoginModel)
        {
            if (ModelState.IsValid)
            {
                Account account = AccountRepository.GetAccount(LoginModel.Email, LoginModel.Password);

                if (account != null)
                {
                    FormsAuthentication.SetAuthCookie(account.Email, false);

                    Session["loggedin_account"] = account;

                    return RedirectToAction("Index", "Home");
                }

                else
                {
                    ModelState.AddModelError("login-error",
                        "The user name or password provided is incorrect.");
                }
            }
            return View();
        }

        public ActionResult LogOut()
        {
            ViewBag.Message = "Log out.";

            return View();
        }


    }
}