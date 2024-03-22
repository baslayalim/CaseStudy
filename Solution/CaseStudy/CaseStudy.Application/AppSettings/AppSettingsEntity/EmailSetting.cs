namespace CaseStudy.Application.AppSettings.AppSettingsEntity
{
    public class EmailSetting
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ServerAdress { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public int Port { get; set; }
        public bool Ssl { get; set; }
        public bool? Status { get; set; }
        public bool? Type { get; set; }
    }
}