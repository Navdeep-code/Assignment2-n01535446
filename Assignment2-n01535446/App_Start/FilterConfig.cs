﻿using System.Web;
using System.Web.Mvc;

namespace Assignment2_n01535446
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
