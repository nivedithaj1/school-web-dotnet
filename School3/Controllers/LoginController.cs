using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;

namespace School3.Controllers
{
    public class LoginController : Controller
    {
        // GET: LoginController
        public ActionResult Index(string returnUrl)
        {
            var abc = returnUrl;
            return View();
        }

        // GET: LoginController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ProcessLogin(IFormCollection collection, string ReturnUrl = null)
        {
            try
            {
                string userName = collection["username"];
                string password = collection["password"];
                if ( userName == "nivi" && password == "1234")
                {
                    //create claims
                    var claims = new List<Claim>();
                    claims.Add(new Claim("firstname", "niveditha"));
                    claims.Add(new Claim("email", "nive@gmail.com"));
                    //create claims idenetity
                    var claimsIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                    //create claims principle
                    var claimsPrinsiple  = new ClaimsPrincipal(claimsIdentity);
                    //sign with the principle
                    HttpContext.SignInAsync(claimsPrinsiple).Wait();
                    return Redirect("/");


                } else
                {
                    // this will be executed when the credernitals are wrong 
                    // you are expected to return back to the login page with a text near the button "Wrong user name or password"
                    return Redirect("/login");
                }
              
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
