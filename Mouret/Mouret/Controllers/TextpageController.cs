using Mouret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web;
using Mouret.Mappers;

namespace Mouret.Controllers
{
    public class TextpageController : MasterController
    {
        public ActionResult Textpage()
        {
            var model = new TextpageModel();
            model.BodyText = CurrentPage.GetPropertyValue<IHtmlString>("bodyText");
            return base.Index(model);
        }
    }
}
