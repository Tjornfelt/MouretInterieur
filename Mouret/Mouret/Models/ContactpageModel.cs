using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mouret.Models
{
    public class ContactpageModel : BaseModel
    {
        public IHtmlString BodyText { get; set; }
        public string GoogleMaps { get; set; }
    }
}