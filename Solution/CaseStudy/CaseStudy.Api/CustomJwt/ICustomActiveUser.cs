namespace CaseStudy.Api.CustomJwt
{
    public interface ICustomActiveUser
    {
        public Guid Id { get; }
        public string Name { get; }
        public string UserName { get; }
        public string Email { get; }
        public string Description { get; }
        public List<string> Roles { get;}
    }
}
