using System;
using System.Collections.Generic;

namespace GIN.Model
{
    public class Category
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public string[] Words { get; set; }

        public static IEnumerable<Category> GetExampleCategories()
        {
            return new[]
                   {
                       new Category

                       {

                           ID = Guid.NewGuid(),

                           Name = "BeautyWellness",

                           Words =
                               new[]
                               {
                                   "hairdresser", "haircut", "massage", "manicure", "hairdo", "brasilian", "wax",
                                   "makeover", "nailpolish", "nails"
                               }



                       },

                       new Category

                       {

                           ID = Guid.NewGuid(),

                           Name = "Health",


                           Words =
                               new[]
                               {
                                   "doctor", "nurse", "medicine", "medication", "pills", "chiropractor", "surgeon",
                                   "psychiatrist", "ambulance", "first aid"
                               }





                       },

                       new Category

                       {

                           ID = Guid.NewGuid(),

                           Name = "Handyman",


                           Words =
                               new[]
                               {
                                   "concierge", "plumber", "carpenter", "locksmith", "engineer", "mechanic", "fix",
                                   "broken", "repair", "solve"
                               }




                       },

                       new Category

                       {

                           ID = Guid.NewGuid(),

                           Name = "IT",


                           Words =
                               new[]
                               {
                                   "install", "software", "webdesign", "design", "repair", "hardware", "network", "wifi",
                                   "cable", "setup"
                               }




                       },

                       new Category

                       {

                           ID = Guid.NewGuid(),

                           Name = "Entertainment",


                           Words =
                               new[]
                               {"DJ", "VJ", "clown", "party", "balloons", "karaoke", "pets", "cake", "music", "piano"}




                       },

                       new Category

                       {

                           ID = Guid.NewGuid(),

                           Name = "Groceries",


                           Words =
                               new[]
                               {
                                   "beer run", "cigarettes", "delivery", "food", "groceries", "liquor", "diner", "lunch",
                                   "breakfast", "errands"
                               }




                       }

                   };
        }
    }
}