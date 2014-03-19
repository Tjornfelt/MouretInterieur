using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mouret.Models.HelperModels;

namespace Mouret.Models
{
    public class TextpageModel : BaseModel
    {
        public IHtmlString BodyText { get; set; }
        public UmbracoImage Image { get; set; }
        public Splatter Splatter { get; set; }
    }
}