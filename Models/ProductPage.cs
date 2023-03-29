using System;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using static postgre2.Models.SimplePage;

namespace postgre2.Models
{
    [PageType(Title = "Product Page")]
    public class ProductPage : Page<SimplePage>
	{
        public class ProductReg
        {
            [Field(Placeholder = "Name")]
            public StringField Name { get; set; }

            [Field]
            public TextField Description { get; set; }

            [Field]
            public ImageField Product { get; set; }

        }

        [Region]
        public ProductReg ProductRegion { get; set; }
    }
}

