using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DTOs
{
    class Catalog
    {
        List<string> TextsList { get; set; }

        public Catalog()
        {
            TextsList = new List<string>();
        }
    }
}
