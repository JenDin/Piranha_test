using System;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace postgre2.Models
{
    [PageType(Title = "Simple Page")]
    public class SimplePage : Page<SimplePage>
    {
        public class JennyRegion
        {
            [Field(Placeholder = "Name")]
            public StringField Name { get; set; }

            [Field]
            public TextField Description { get; set; }

            [Field]
            public TextField AnotherText { get; set; }

            [Field]
            public ImageField Image { get; set; }

            [Field]
            public VideoField Video { get; set; }
        }

        [Region]
        public JennyRegion MyRegion { get; set; }
    }
}

