﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VstsClientLibrariesSamples.Tests
{
    public static class InitHelper
    {
        public static IConfiguration GetConfiguration(IConfiguration configuration)
        {
            configuration.PersonalAccessToken = ConfigurationSettings.AppSettings["appsetting.pat"].ToString();
            configuration.Project = ConfigurationSettings.AppSettings["appsetting.project"].ToString();
            configuration.Query = ConfigurationSettings.AppSettings["appsetting.query"].ToString();
            configuration.Identity = ConfigurationSettings.AppSettings["appsetting.identity"].ToString();
            configuration.UriString = ConfigurationSettings.AppSettings["appsetting.uri"].ToString();   
            configuration.WorkItemIds = ConfigurationSettings.AppSettings["appsetting.workitemids"].ToString();

            return configuration;
        }
    }
}