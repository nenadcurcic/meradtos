using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DTOs
{
    public class Catalog
    {
        public List<string> TextSubjectsList { get; set; }

        public Catalog()
        {
            TextSubjectsList = new List<string>();
        }
    }
}
