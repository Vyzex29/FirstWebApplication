using FirstWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApplication.Controllers
{
    public class UserController : Controller
    {
        List<UserModel> userModels;

        public UserController()
        {
            userModels = new List<UserModel>
            {
                new UserModel
                {
                    Id = 1,
                    Name = "Valerijs",
                    Email = "virtuoso292@gmail.com",
                    Phone = "27793783"
                },
                new UserModel
                {
                    Id = 2,
                    Name = "Clara",
                    Email = "clara.smith@gmail.com",
                    Phone = "449158190"
                }
            };
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
    }
}
