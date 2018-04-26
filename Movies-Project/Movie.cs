using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies_Project
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Released { get; set; }
        public string Director { get; set; }
        public string Poster { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Title}";
        }
    }
}
