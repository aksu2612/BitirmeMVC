﻿using System.Web;
using System.Web.Mvc;

namespace Su_Dagitim_1_0
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}