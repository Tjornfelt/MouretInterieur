using Mouret.Mappers;
using Mouret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web;

namespace Mouret.Controllers
{
    public class MasterController : Umbraco.Web.Mvc.RenderMvcController
    {
        //
        // GET: /Master/

        public ActionResult Index(BaseModel model)
        {
            var frontpage = CurrentPage.AncestorOrSelf(1);
            model.LeftImage = UmbracoImageMapper.Map(frontpage.GetPropertyValue<string>("leftImage"), Umbraco);
            model.MidImage = UmbracoImageMapper.Map(frontpage.GetPropertyValue<string>("midImage"), Umbraco);
            model.RightImage = UmbracoImageMapper.Map(frontpage.GetPropertyValue<string>("rightImage"), Umbraco);
            model.TopNavigation = NavigationMapper.Map(CurrentPage, true);
            model.SideNavigation = NavigationMapper.Map(CurrentPage);

            return View(model);
        }
    }
}
