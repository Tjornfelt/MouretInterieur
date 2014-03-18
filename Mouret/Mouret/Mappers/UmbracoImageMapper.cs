﻿using Mouret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web;
using Mouret.Classes.Helpers;

namespace Mouret.Mappers
{
    public static class UmbracoImageMapper
    {
        public static UmbracoImage Map(string imageId, UmbracoHelper helper)
        {
            if (!string.IsNullOrWhiteSpace(imageId))
            {
                var image = helper.TypedMedia(imageId);
                if (image != null)
                {
                    UmbracoImage umbImg = new UmbracoImage();
                    umbImg.ImageUrl = image.Url;
                    umbImg.AltText = image.Name;
                    umbImg.ImageCropUrl = image.GetCropUrl(CropHelper.ProductThumbnail);
                    return umbImg;
                }
            }
            return null;
        }
    }
}