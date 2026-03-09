using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._03._2026
{
    public class Movie
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public int Length { get; set; }

        public double Imdb { get; set; }
        public double Csfd { get; set; }
        public int Rotten { get; set; }

        public string Director { get; set; }
        public string Description { get; set; }
    }
}
