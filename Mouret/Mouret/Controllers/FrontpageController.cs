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
    public class FrontpageController : MasterController
    {
        public ActionResult Frontpage()
        {
            var model = new FrontpageModel();
            model.BodyText = CurrentPage.GetPropertyValue<IHtmlString>("bodyText");
            
            return base.Index(model);
        }
    }
}
