using CaseStudy.Application.AppSettings.AppSettingsEntity;
using Microsoft.Extensions.Configuration;

namespace CaseStudy.Application.AppSettings
{
    public static class AppSettings
    {

        public static string? ConnectionString { get; set; }
        public static GeneralParameters? GeneralParameters { get; set; }
        public static EmailSetting? EmailSetting { get; set; }

        public static void Loading(IConfiguration appSettings)
        {
        }
    }
}