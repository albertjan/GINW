using System.Linq;
using GIN.Model;
using Nancy;

namespace GINB
{
    public class BAModule : NancyModule
    {
        public BAModule() : base("data")
        {
            Get["/"] = x =>
            {
                return "backend";
            };
            Get["/categories"] = x =>
            {
                return Response.AsJson(Category.GetExampleCategories());
            };

            Get["/filter/{category}/{word}"] = x =>
            {
                return Response.AsJson(Category.GetExampleCategories().Where(c => c.Name == (string)x.category).SelectMany(c => c.Words).Where(w => w.Contains((string)x.word)));
            };

            Get["/location"] = x => Response.AsJson(new
                                                    {
                                                        lat = Request.Session["Latitude"],
                                                        longi = Request.Session["Longitude"]
                                                    });

            Post["/location"] = x =>
            {
                Request.Session["Latitude"] = (string) Request.Form.lat;
                Request.Session["Longitude"] = (string) Request.Form.longi;

                return 200;
            };
        }
    }
}
