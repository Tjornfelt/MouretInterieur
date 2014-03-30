using Mouret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web;
using Mouret.Models.HelperModels;
using Umbraco.Core.Models;
using Mouret.Classes.Helpers;

namespace Mouret.Mappers
{
    public static class ProductMapper
    {
        public static IEnumerable<Product> Map(IPublishedContent currentPage, UmbracoHelper helper)
        {
            List<Product> productList = new List<Product>();
            var products = currentPage.Children.Where(x => x.IsDocumentType("Product"));

            if (products != null)
            {
                foreach (var item in products)
                {
                    Product p = new Product();

                    var imagesIdCsv = item.GetPropertyValue<string>("images");
                    

                    if (!string.IsNullOrWhiteSpace(imagesIdCsv))
                    {
                        var imageIds = imagesIdCsv.Split(',');
                        List<UmbracoImage> imgList = new List<UmbracoImage>();
                        foreach (var imageId in imageIds)
                        {
                            UmbracoImage img = new UmbracoImage();

                            img = UmbracoImageMapper.Map(imageId, helper);
                            imgList.Add(img);
                        }
                        p.Images = imgList;
                    }
                    p.Description = item.GetPropertyValue<IHtmlString>("description");
                    productList.Add(p);
                }
                if (productList.Any())
                {
                    return productList;
                }
            }
            return null;
        }
    }
}