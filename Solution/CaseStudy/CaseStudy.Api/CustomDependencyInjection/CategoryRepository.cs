namespace CaseStudy.Api.CustomDependencyInjection
{
    public class CategoryRepository : ICaseCategoryRepository
    {
        public string AddCategory(string categoryName)
        {
            return $"{categoryName} Category Created !";
        }
    }
}
