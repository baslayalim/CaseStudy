namespace CaseStudy.Api.CustomRoleBasedAttributes
{
    public class AuthorizeRoleBasedAttribute : Attribute
    {
        public string? Menu { get; set; }
        public string? Definition { get; set; }
        public ActionType ActionType { get; set; }
        public AppType AppType { get; set; }
    }
}