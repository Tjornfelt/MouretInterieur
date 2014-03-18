using Mouret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Web;
using Mouret.Models.HelperModels;
using Umbraco.Core.Models;

namespace Mouret.Mappers
{
    public static class NavigationMapper
    {
        public static IEnumerable<MenuItem> Map(IPublishedContent currentPage, bool sideNav = false)
        {
            List<MenuItem> menuItemList = new List<MenuItem>();

            MenuItem frontPage = new MenuItem();
            var siteRoot = currentPage.AncestorOrSelf(1);

            if (!siteRoot.GetPropertyValue<bool>("umbracoNaviHide"))
            {
                frontPage.Name = siteRoot.Name;
                frontPage.Url = siteRoot.Url;
                menuItemList.Add(frontPage);
            }

            foreach (var child in siteRoot.Children.Where(x => x.GetPropertyValue<bool>("showInTopMenu") == sideNav && x.GetPropertyValue<bool>("umbracoNaviHide") == false))
            {
                MenuItem menuItem = new MenuItem();
                menuItem.Name = child.Name;
                

                if (child.IsDocumentType("Link"))
                {
                    menuItem.OpenInNewWindow = child.GetPropertyValue<bool>("targetNewWindow");
                    menuItem.Url = child.GetPropertyValue<string>("linkUrl");
                }
                else
                {
                    menuItem.Url = child.Url;
                }
                menuItemList.Add(menuItem);
            }
            if (menuItemList.Any())
            {
                return menuItemList;
            }
            return null;
        }
    }
}