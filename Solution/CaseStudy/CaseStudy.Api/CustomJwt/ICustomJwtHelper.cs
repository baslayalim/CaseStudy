namespace CaseStudy.Api.CustomJwt
{
    public interface ICustomJwtHelper
    {
        CustomJwtAccessToken CreateToken(CustomJwtData _customJwtData);
    }
}
