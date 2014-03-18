﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mouret.Models.HelperModels
{
    public class Product
    {
        public string ImageUrl { get; set; }
        public string ImageCropUrl { get; set; }
        public IHtmlString Description { get; set; }
    }
}