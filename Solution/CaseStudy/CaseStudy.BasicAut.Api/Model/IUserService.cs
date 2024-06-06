namespace CaseStudy.BasicAut.Api.Model
{
    public interface IUserService
    {
        List<UserModel> GetUsers();
        UserModel Login(string username, string password);
    }
}
