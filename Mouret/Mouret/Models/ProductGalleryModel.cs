using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mouret.Models.HelperModels;

namespace Mouret.Models
{
    public class ProductGalleryModel : BaseModel
    {
        public IEnumerable<Product> Products { get; set; }
    }
}