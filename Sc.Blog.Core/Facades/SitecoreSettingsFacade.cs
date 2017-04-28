﻿using Sitecore.Mvc.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sc.Blog.Core.Facades
{
    public class SitecoreSettingsFacade
    {
        public string SitecoreRouteName { get => MvcSettings.SitecoreRouteName; }
    }
}