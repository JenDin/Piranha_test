using System;
using Microsoft.AspNetCore.Routing;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace postgre2.Models
{
    [PostType(Title = "Hero Post")]
    [ContentTypeRoute(Title = "Default", Route = "/heropost")]
    public class SimplePost :PostBase
    {
        public class HeroRegion
        {
            [Field]
            public StringField Title { get; set; }
            [Field]
            public ImageField Image { get; set; }
            [Field]
            public TextField Body { get; set; }
        }

        [Region]
        public HeroRegion Hero { get; set; }
    }
}

