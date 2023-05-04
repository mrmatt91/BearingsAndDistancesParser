using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearingsAndDistancesParser
{
    public static class HelperCollections
    {
        public static List<string> Directions = new List<string> { "N", "S", "E", "W" };
        public static Dictionary<string, string> DirectionMap = new Dictionary<string, string> { { "S", "South" }, { "N", "North" }, { "E", "East" }, { "W", "West" } };
        public static List<char> VowelList = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'y' };
}
}
