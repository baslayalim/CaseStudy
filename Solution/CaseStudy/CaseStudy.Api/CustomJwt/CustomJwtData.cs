namespace CaseStudy.Api.CustomJwt
{
    public class CustomJwtData
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }

        public string RefreshToken { get; set; }
        public DateTime RefreshTokenEndDate { get; set; }

        public List<string> Roles { get; set; } = new List<string>();
    }
}
