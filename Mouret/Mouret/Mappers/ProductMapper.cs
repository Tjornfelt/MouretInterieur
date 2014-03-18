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

            foreach (var item in products)
            {
                Product p = new Product();
                var image = UmbracoImageMapper.Map(item.GetPropertyValue<string>("image"), helper);
                if (image != null)
                {
                    p.ImageUrl = image.ImageUrl;
                    p.ImageCropUrl = image.ImageCropUrl;
                }
                p.Description = item.GetPropertyValue<IHtmlString>("description");
                productList.Add(p);
            }
            if (productList.Any())
            {
                return productList;
            }
            return null;
        }
    }
}