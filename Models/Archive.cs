using System;
using Piranha.AttributeBuilder;
using Piranha.Models;
using System.IO.Compression;

namespace postgre2.Models
{
    [PageType(Title = "Simple Archive", UseBlocks = false, IsArchive = true)]
    public class Archive : Page<Archive>
    {

    }

}

