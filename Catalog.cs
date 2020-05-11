using System.Collections.Generic;

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
