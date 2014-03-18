using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using Mouret.Models.HelperModels;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace Mouret.Classes.Helpers
{
    public static class CropHelper
    {
        public const string ProductThumbnail = "Produkt thumbnail";
		public const string FrontpageBanner = "Forside banner";

        public static ImageCrop GetCrop(this IPublishedContent image, string cropName)
        {
            var imageCrop = image.GetPropertyValue<string>("crops");

            if (!string.IsNullOrWhiteSpace(imageCrop))
            {
				ImageCrop imageCropObj = new ImageCrop();

                XmlDocument xml = new XmlDocument();
                xml.LoadXml(imageCrop);

                XmlNodeList xnList = xml.SelectNodes("/crops/crops/crop[@name='"+cropName+"']");
                foreach (XmlNode xn in xnList)
                {
                    string cropUrl = xn.Attributes["url"].Value;
					int x = Convert.ToInt32(xn.Attributes["x"].Value);
					int x2 = Convert.ToInt32(xn.Attributes["x2"].Value);
                    if (!string.IsNullOrWhiteSpace(cropUrl))
                    {
						imageCropObj.CropUrl = cropUrl;
						imageCropObj.CropWidth = x2 - x;

						return imageCropObj;
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