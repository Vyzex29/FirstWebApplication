using FirstWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApplication.Controllers
{
    public class UserController : Controller
    {
        public static List<UserModel> userModels = new List<UserModel>();

        [HttpGet]
        public IActionResult CreateFromScaffold()
        {
            var user = new UserModel
            {
                Id = userModels.Count + 1
            };
            return View(user);
        }

        [HttpPost]
        public IActionResult CreateFromScaffold(UserModel user)
        {
            if (ModelState.IsValid)
            {
                userModels.Add(user);
                return RedirectToAction("Show");
            }

            return View(user);
        }

        // webadress.com/User/Show/
        public IActionResult Show()
        {
            return View(userModels);
        }

   
        // webadress.com/User/Find/id
        public IActionResult Find(int specific)
        {
            UserModel model;
            if (userModels.Exists(user => user.Id == specific))
            {
                model = userModels.Find(user => user.Id == specific);
            }
            else
            {
                return RedirectToAction("Show");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var user = new UserModel
            {
                Id = userModels.Count + 1
            };

            return View(user);
        }

        [HttpPost]
        public IActionResult Create(UserModel user)
        {
            if (ModelState.IsValid)
            {
                userModels.Add(user);
                return RedirectToAction("Show");
            }

            return View(user);
        }
    }
}
