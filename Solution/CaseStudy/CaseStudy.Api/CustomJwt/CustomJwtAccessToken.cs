namespace CaseStudy.Api.CustomJwt
{
    public class CustomJwtAccessToken
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public DateTime Expiration { get; set; }
        public DateTime RefreshTokenExpiration { get; set; }
    }
}
