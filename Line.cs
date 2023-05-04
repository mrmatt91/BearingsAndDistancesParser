using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearingsAndDistancesParser
{
    public class Line
    {
        public Line() {}

        public Line(int point, string description)
        {
            Point = point;
            Description = description;
        }
        public Line(int point, string firstValue, string direction1, string degrees, string minutes, string seconds, string direction2, decimal distance, string description)
        {
            Point = point;
            FirstValue = firstValue;
            Direction1 = direction1;
            Degrees = degrees;
            Minutes = minutes;
            Seconds = seconds;
            Direction2 = direction2;
            Distance = distance;
            Description = description;
        }
        public string FirstValue { get; set; }
        public int Point { get; set; }
        
        public string Direction1 { get; set; }
        public string Degrees { get; set; }
        public string Minutes { get; set; }
        public string Seconds { get; set; }
        public string Direction2 { get; set; }

        public decimal Distance { get; set; }

        public string Description { get; set; }
    }
}
