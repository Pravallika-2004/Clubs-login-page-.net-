
using System.Linq;
using System.Web.Mvc;
using WebApplication4.Models;
using System.Dynamic;


//using WebApplication4.ViewModels;

namespace WebApplication4.Controllers
{
    public class AdminController : Controller
    {
        private readonly dummyclubsEntities _db = new dummyclubsEntities();

        // GET: Login Page
        public ActionResult Login()
        {
            return View();
        }

        // POST: Handle Login
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Find the user in the database
                var user = _db.USERs.FirstOrDefault(u => u.Email == model.Username && u.Password == model.Password);

                if (user != null)
                {
                    if (user.Userrole == "Admin")
                    {
                        // Store admin details in session
                        Session["UserID"] = user.UserID;
                        Session["UserRole"] = user.Userrole;
                        Session["UserName"] = user.FirstName + " " + user.LastName;

                        return RedirectToAction("Adminmethod", "AdminDashboard");
                    }
                    else
                    if(user.Userrole == "Mentor")
                    {
                        return View("Mentordash");
                    }
                    else
                    {
                        ViewBag.Message = "Access Denied! You are not an admin.";
                    }
                }
                else
                {
                    ViewBag.Message = "Invalid email or password.";
                }
            }
            return View(model);
        }

        // Logout Action
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
