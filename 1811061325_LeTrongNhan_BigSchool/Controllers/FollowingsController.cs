using _1811061325_LeTrongNhan_BigSchool.DTO;
using _1811061325_LeTrongNhan_BigSchool.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _1811061325_LeTrongNhan_BigSchool.Controllers
{
    public class FollowingsController : ApiController
    {
        private ApplicationDbContext _dbContext;

        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend(FollowingDTO followingDTO)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Followings.Any(a => a.FollwerId == userId && a.FolloweeId == followingDTO.FolloweeId))
            {
                return BadRequest("The Attendance already exits");
            }
            var following = new Following
            {
                FollwerId = userId,
                FolloweeId = followingDTO.FolloweeId


            };

            _dbContext.Followings.Add(following);
            _dbContext.SaveChanges();

            return Ok();

        }
    }
}

