using GIN.Model;
using Nancy;

namespace GINB
{
    public class BAModule : NancyModule
    {
        public BAModule() : base("data")
        {
            Get["/categories"] = x =>
            {
                return Response.AsJson(Category.GetExampleCategories());
            };

            Get["/filter/{category}/{word}"] = x =>
            {
                
            };
        }
    }
}
