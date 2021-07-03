using _1811061325_LeTrongNhan_BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1811061325_LeTrongNhan_BigSchool.ViewModel
{
    public class FollowingViewModel
    {
        public IEnumerable<ApplicationUser> Followings { get; set; }
        public bool ShowAction { get; set; }
    }
}