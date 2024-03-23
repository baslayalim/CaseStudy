using CaseStudy.Application.AppSettings.AppSettingsEntity;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;
using System;
using System.Runtime; 

namespace CaseStudy.Application.AppSettings
{
    public static class AppSettings
    {

        public static string? ConnectionString { get; set; }
        public static GeneralParameters? GeneralParameters { get; set; }
        public static List<EmailSetting>? EmailSetting { get; set; }

        public static void Loading(IConfiguration appSettings)
        {
            ConnectionString = appSettings.GetValue<string>("ConnectionString");
            GeneralParameters = appSettings.GetSection("GeneralParameters").Get<GeneralParameters>();
            EmailSetting = appSettings.GetSection("EmailSetting").Get<List<EmailSetting>>();
        }
    }
}