namespace CaseStudy.BasicAut.Api.Model
{
    public class UserService : IUserService
    {
        private readonly List<UserModel> _users;
        public UserService()
        {
            _users = new List<UserModel>()
            {
                new UserModel{ Username = "Case", EmailAddress="case@study.com", Password="2024" },
                new UserModel{ Username = "Study", EmailAddress="study@case.com", Password="2025" }
            };
        }

        public List<UserModel> GetUsers()
        {
            return _users;
        }

        public UserModel Login(string username, string password)
        {
            var user = _users.FirstOrDefault(x => x.Username == username && x.Password == password);

            return user;
        }
    }
}
