using _1811061325_LeTrongNhan_BigSchool.Models;
using _1811061325_LeTrongNhan_BigSchool.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1811061325_LeTrongNhan_BigSchool.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;
        public HomeController()
        {
            _dbContext = new ApplicationDbContext();

        }
      
        public ActionResult Index()
        {
            
            var b = _dbContext.Courses
                .Include(c => c.Lecturer)
                .Include(c => c.Category)
                .Where(c => c.DateTime > DateTime.Now);

            var viewModel = new CoursesViewModel
            {
                UpcommingCourses = b,
                ShowAction = User.Identity.IsAuthenticated
            };

          
            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}