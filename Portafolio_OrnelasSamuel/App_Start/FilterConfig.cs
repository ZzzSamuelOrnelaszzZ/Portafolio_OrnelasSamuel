﻿using System.Web;
using System.Web.Mvc;

namespace Portafolio_OrnelasSamuel
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
