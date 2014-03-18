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
    public class ProductGalleryController : MasterController
    {
        public ActionResult ProductGallery()
        {
            var model = new ProductGalleryModel();
            model.Products = ProductMapper.Map(CurrentPage, Umbraco);
            return base.Index(model);
        }
    }
}
