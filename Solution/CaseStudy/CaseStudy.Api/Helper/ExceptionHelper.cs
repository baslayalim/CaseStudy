namespace CaseStudy.Api.Helper
{
    public class ExceptionHelper : Exception
    {
        public class CaseStudyException : Exception
        {
            public CaseStudyException(string message) : base(message)
            {
            }
        }
        public class AuthenticationException : Exception
        {
            public AuthenticationException(string message) : base(message: message)
            {
            }
        }
    }
}
