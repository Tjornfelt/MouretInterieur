using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace Mouret.Classes.Helpers
{
    public static class CropHelper
    {
        public const string ProductThumbnail = "Produkt thumbnail";

        public static string GetCropUrl(this IPublishedContent image, string cropName)
        {
            var imageCrop = image.GetPropertyValue<string>("crops");

            if (!string.IsNullOrWhiteSpace(imageCrop))
            {
                XmlDocument xml = new XmlDocument();
                xml.LoadXml(imageCrop);

                XmlNodeList xnList = xml.SelectNodes("/crops/crops/crop[@name='"+cropName+"']");
                foreach (XmlNode xn in xnList)
                {
                    string cropUrl = xn.Attributes["url"].Value;
                    if (!string.IsNullOrWhiteSpace(cropUrl))
                    {
                        return cropUrl;
                    }
                }
            }
            return null;
        }
    }
}

/*
"<crops>
<crops date=\"2014-03-07T21:31:12\">
<crop name=\"Produkt thumbnail\" x=\"0\" y=\"32\" x2=\"792\" y2=\"626\" url=\"/media/1002/antique-mahogany-victorian-5ft-3-door-armoire-wardrobe-closet-bap31_Produkt thumbnail.jpg\" />
</crops>
</crops>"
*/