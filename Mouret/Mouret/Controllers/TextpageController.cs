using Mouret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web;
using Mouret.Mappers;
using Mouret.Models.HelperModels;

namespace Mouret.Controllers
{
    public class TextpageController : MasterController
    {
        public ActionResult Textpage()
        {
            var model = new TextpageModel();
            model.BodyText = CurrentPage.GetPropertyValue<IHtmlString>("bodyText");
            model.Image = UmbracoImageMapper.Map(CurrentPage.GetPropertyValue<string>("image"), Umbraco);
            model.Splatter = SetSplatterValues();
            return base.Index(model);
        }

        private Splatter SetSplatterValues()
        {
            Splatter splatter = new Splatter();

            splatter.Text = CurrentPage.GetPropertyValue<string>("splatterText");
            splatter.VerticalPosition = CurrentPage.GetPropertyValue<int>("vPosition");
            splatter.HorizontalPosition = CurrentPage.GetPropertyValue<int>("hPosition");
            splatter.Diameter = CurrentPage.GetPropertyValue<int>("diameter");

            return splatter;
        }
    }
}
