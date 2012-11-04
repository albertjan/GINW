using GIN.Model;
using Nancy;

namespace GINB
{
    public class FAModule : NancyModule
    {
        public FAModule()
        {
            Get["/"] = x =>
            {
                return View["main", new { categories = Category.GetExampleCategories()} ];
            };

            Get["/signup"] = x => View["mail"];
        }
    }
}