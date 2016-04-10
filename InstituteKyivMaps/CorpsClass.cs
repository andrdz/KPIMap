using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InstituteKyivMaps
{
    class CorpsClass
    {
        public static List<string> PhotoCorps = new List<string>();
        public static List<string> NameCorps = new List<string>();
        public static List<int> xList = new List<int>();
        public static List<int> yList = new List<int>();
        public static List<int> ListXcorps = new List<int>();
        public static List<int> ListYcorps = new List<int>();
        public static List<int> ToVertex = new List<int>();

        public void AddCorps(string img, string name, int x, int y, int xcorps, int ycorps, int ToV)
        {
            PhotoCorps.Add(img);
            NameCorps.Add(name);
            xList.Add(x);
            yList.Add(y);
            ListXcorps.Add(xcorps);
            ListYcorps.Add(ycorps);
            ToVertex.Add(ToV);
        }
    }
}
