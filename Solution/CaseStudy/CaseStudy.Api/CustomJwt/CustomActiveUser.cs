namespace CaseStudy.Api.CustomJwt
{
    public class CustomActiveUser : ICustomActiveUser
    {
        private readonly CustomJwtData _jwtData;
        public CustomActiveUser(CustomJwtData jwtData)
        {
            _jwtData = jwtData;
        }
        public Guid Id => _jwtData.Id;
        public string Name => _jwtData.Name;
        public string UserName => _jwtData.UserName;
        public string Email => _jwtData.Email;
        public string Description => _jwtData.Description;
        public List<string> Roles => _jwtData.Roles;
    }
}
