using BrockAllen.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OauthClaimsDemo.Controllers
{
    public class HomeController : Controller
    {
      

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(ProviderType type)
        {
            // 1st param is which OAuth2 provider to use
            // 2nd param is what URL to send the user once all the login magic is done
            return new OAuth2ActionResult(type, Url.Action("Index"));
        }
    }
}
