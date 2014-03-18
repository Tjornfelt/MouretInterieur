using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mouret.Models.HelperModels
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public bool OpenInNewWindow { get; set; }
    }
}