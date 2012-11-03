using System;
using System.Collections.Generic;

namespace GIN.Model
{
    public class Category
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public static IEnumerable<Category> GetExampleCategories()
        {
            return new []
                       {
                           new Category
                               {
                                   ID = Guid.NewGuid(),
                                   Name = "Beauty & Wellness"
                               },
                           new Category
                               {
                                   ID = Guid.NewGuid(),
                                   Name = "Health"
                               },
                           new Category
                               {
                                   ID = Guid.NewGuid(),
                                   Name = "Handyman"
                               },
                               new Category
                               {
                                   ID = Guid.NewGuid(),
                                   Name = "IT"
                               },
                               new Category
                               {
                                   ID = Guid.NewGuid(),
                                   Name = "Entertainment"
                               },
                               new Category
                               {
                                   ID = Guid.NewGuid(),
                                   Name = "Groceries"
                               }
                       };
        }
    }
}