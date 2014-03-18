using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mouret.Models.HelperModels;

namespace Mouret.Models
{
    public class BaseModel
    {
		/*
        public UmbracoImage LeftImage { get; set; }
        public UmbracoImage MidImage { get; set; }
        public UmbracoImage RightImage { get; set; }
		 * */

		public IEnumerable<UmbracoImage> BannerImages { get; set; }

        public IEnumerable<MenuItem> TopNavigation { get; set; }
        public IEnumerable<MenuItem> SideNavigation { get; set; }
    }
}