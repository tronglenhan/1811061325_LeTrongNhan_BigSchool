using _1811061325_LeTrongNhan_BigSchool.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _1811061325_LeTrongNhan_BigSchool.Controllers.Api
{
    public class CoursesController : ApiController
    {
        private readonly ApplicationDbContext _dbContext;

        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpDelete]
        public IHttpActionResult Cancel(int id)
        {
            var userId = User.Identity.GetUserId();

            var course = _dbContext.Courses.Single(c => c.Id == id && c.LecturerId == userId);

            if (course.IsCancled)
            {
                return NotFound();
            }

            course.IsCancled = true;
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
