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
    public class ContactpageController : MasterController
    {
        public ActionResult Contactpage()
        {
            var model = new ContactpageModel();
            model.BodyText = CurrentPage.GetPropertyValue<IHtmlString>("bodyText");
            model.GoogleMaps = CurrentPage.GetPropertyValue<string>("googleMapsIframe");
            return base.Index(model);
        }
    }
}
