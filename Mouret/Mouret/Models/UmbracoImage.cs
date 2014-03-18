using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mouret.Models.HelperModels;

namespace Mouret.Models
{
    public class UmbracoImage
    {
        public string ImageUrl { get; set; }
        public string AltText { get; set; }
		public ImageCrop Crop { get; set; }

    }
}