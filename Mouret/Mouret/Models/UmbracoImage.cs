using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mouret.Models
{
    public class UmbracoImage
    {
        public string ImageUrl { get; set; }
        public string ImageCropUrl { get; set; }
        public string AltText { get; set; }
    }
}