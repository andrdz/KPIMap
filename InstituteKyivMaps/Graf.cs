using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InstituteKyivMaps
{
    class Graf
    {
        public static  List<int> X = new List<int>();
        public static  List<int> Y = new List<int>();
        public static int[,] w = new int[500, 500];
        public static int num=0;

        public void AddVertex(int x, int y)
        {
            X.Add(x);
            Y.Add(y);
            num++;
        }

        public void AddEdges (int v1, int v2)
        {
            v1--;
            v2--;
            double l = Math.Sqrt((Math.Pow((X[v2] - X[v1]), 2)+Math.Pow((Y[v2]-Y[v1]), 2)));
            w[v1, v2] = Convert.ToInt32(l);
            w[v2, v1] = Convert.ToInt32(l);
        }

        public int[] DijkstraAlgorithm(int v1, int v2)
        {
            //-----------------------------------------------------------------------------
            bool[] used = new bool[500]; //масив використаних вершин
            int[] d = new int[500]; //масив довжини найкоротшого шляху
            string[] s = new string[500];
            int[] path = new int[500]; //масив вершин найкоротшого шляху
            int inf = 1000000000; //умовна безкінечність
            //-----------------------------------------------------------------------------

            v1--;
            v2--;
            for (int i = 0; i < num; i++)
            {
                d[i] = inf;
                used[i] = false;
            }

            //-----------------------------------------------------------------------------

            d[v1] = 0;
            s[v1] = Convert.ToString(v1+1);

            //-----------------------------------------------------------------------------
            while (true)
            {
                int from = 0, zfrom = inf;
                for (int i = 0; i < num; i++)
                    if ((zfrom > d[i]) && !(used[i]))
                    {
                        from = i;
                        zfrom = d[i];
                    }
                if (zfrom >= inf)
                    break;
                used[from] = true;
                for (int to = 0; to < num; to++)
                    if (w[from, to] != 0)
                        if ((!used[to]) && (d[to] > d[from] + w[from, to]))
                        {
                            s[to] = s[from] + ' ' + Convert.ToString(to+1);
                            d[to] = d[from] + w[from, to];
                        }
            }

            //-----------------------------------------------------------------------------

            string[] str = new string[500];
            string p;
            int m = 0, n = 0;

            //-----------------------------------------------------------------------------

            p = s[v2] + ' ';
            while (m<p.Length)
            {
                str[n] += Convert.ToString(p[m]);
                m++;
                if (p[m] == ' ')
                {
                    path[n] = Convert.ToInt32(str[n]);
                    m++;
                    n++;
                }
            }

            //-----------------------------------------------------------------------------

            return path;
        }
    }
}
