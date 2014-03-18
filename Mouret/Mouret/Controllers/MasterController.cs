using Mouret.Mappers;
using Mouret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web;
using Mouret.Classes.Helpers;

namespace Mouret.Controllers
{
    public class MasterController : Umbraco.Web.Mvc.RenderMvcController
    {
        //
        // GET: /Master/

        public ActionResult Index(BaseModel model)
        {
            var frontpage = CurrentPage.AncestorOrSelf(1);
			var imagesIdCsv = frontpage.GetPropertyValue<string>("bannerImages");
			var imageIds = imagesIdCsv.Split(',');

			List<UmbracoImage> imgList = new List<UmbracoImage>();
			foreach (var imageId in imageIds)
			{
				UmbracoImage img = new UmbracoImage();

				img = UmbracoImageMapper.Map(imageId, Umbraco, CropHelper.FrontpageBanner);
				imgList.Add(img);
			}
			model.BannerImages = imgList;
            model.TopNavigation = NavigationMapper.Map(CurrentPage, true);
            model.SideNavigation = NavigationMapper.Map(CurrentPage);

            return View(model);
        }
    }
}
