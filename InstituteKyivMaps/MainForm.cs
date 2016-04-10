using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InstituteKyivMaps
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        CorpsClass corps = new CorpsClass();
        Graf graf = new Graf();
        public static int xclick=0, yclick=0;
        int lx = 0, ly = 0;
        int cx = 0, cy = 0;
        int fix;
        int indexStart;
        bool getroute = false;

        public static bool paint = false;

        public void Map_Paint(object sender, PaintEventArgs e)
        {
            if (KPIMap.Bottom < 200 || KPIMap.Right < 200)
            {
                cx = 0;
                cy = 0;
                if (fix >= 0)
                    corpus.Location = new Point(KPIMap.Location.X + CorpsClass.ListXcorps[fix] + 1, KPIMap.Location.Y + CorpsClass.ListYcorps[fix] + 1);
                KPIMap.Location = new Point(KPIMap.Location.X + 1, KPIMap.Location.Y+1);
            }
            else if (KPIMap.Left > Map.Right - 200 || KPIMap.Top > Map.Bottom - 200)
            {
                cx = 0;
                cy = 0;
                if (fix >= 0)
                    corpus.Location = new Point(KPIMap.Location.X + CorpsClass.ListXcorps[fix] - 1, KPIMap.Location.Y + CorpsClass.ListYcorps[fix] - 1);
                KPIMap.Location = new Point(KPIMap.Location.X - 1, KPIMap.Location.Y - 1);
            }
            else
            {
                if (fix >= 0)
                    corpus.Location = new Point(cx + KPIMap.Location.X + CorpsClass.ListXcorps[fix], cy + KPIMap.Location.Y + CorpsClass.ListYcorps[fix]);
                KPIMap.Location = new Point(cx + KPIMap.Location.X, cy + KPIMap.Location.Y);
            }
        }

        private void KPIMap_MouseDown(object sender, MouseEventArgs e)
        {
            lx = e.X;
            ly = e.Y;
        }

        private void KPIMap_MouseMove(object sender, MouseEventArgs e)
        {
            if (KPIMap.Capture && e.X + KPIMap.Location.X < Map.Width && e.Y + KPIMap.Location.Y < Map.Height && e.X + KPIMap.Location.X > 0 && e.Y + KPIMap.Location.Y > 0)
            {
                int dx = e.X - lx;
                int dy = e.Y - ly;
                cx += dx;
                cy += dy;
                lx = e.X;
                ly = e.Y;
                Map.Invalidate();
            }
        }

        private void corpus_Click(object sender, EventArgs e)
        {
            PhotoCorps window = new PhotoCorps();
            window.Text = CorpsClass.NameCorps[fix];
            window.Photo.ImageLocation = "../../Resources/" + CorpsClass.PhotoCorps[fix];
            window.ShowDialog();
        }

        private void showmaps_Click(object sender, EventArgs e)
        {
                        fix = CorpsList.SelectedIndex;
                        if (fix >= 0)
                        {
                            corpus.Visible = true;
                            KPIMap.Location = new Point(CorpsClass.xList[fix], CorpsClass.yList[fix]);
                            corpus.Location = new Point(CorpsClass.xList[fix] + CorpsClass.ListXcorps[fix], CorpsClass.yList[fix] + CorpsClass.ListYcorps[fix]);
                        }
                        else
                        {
                            corpus.Visible = false;
                            MessageBox.Show("Спочатку виберіть інститут або факультет...");
                        }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ClearRoute.Enabled = false;

            //------------------------------------------------------------
            
            corps.AddCorps("MechanicalEngineering.jpg", "Механіко-машинобудівний інститут", -244, -103, 716, 350, 11);
            corps.AddCorps("IPSA.jpg", "Інститут прикладного системного аналiзу", 50, -500, 472, 690, 63);
            corps.AddCorps("VPI.jpg", "Видавничо-поліграфічний інститут", 348, 64, 122, 190, 7);
            corps.AddCorps("FTI.jpg", "Фізико-технічний інститут", -317, -127, 794, 360, 11);
            corps.AddCorps("IFF.jpg", "Інженерно-фізичний факультет", -530, -400, 988, 641, 50);
            corps.AddCorps("IHF.jpg", "Інженерно-хімічний факультет", -190, -565, 742, 765, 49);
            corps.AddCorps("PBF.jpg", "Приладобудівний факультет", -317, -127, 794, 390, 11);
            corps.AddCorps("RTF.jpg", "Радiотехнiчний факультет", -177, -454, 655, 671, 64);
            corps.AddCorps("TEF.jpg", "Теплоенергетичний факультет", -655, -84, 1187, 335, 66);
            corps.AddCorps("FAKS.jpg", "Факультет авіаційних і космічних систем", -607, -384, 1107, 609, 67);
            corps.AddCorps("FBT.jpg", "Факультет біотехнології і біотехніки", 186, -120, 355, 350, 14);
            corps.AddCorps("FEA.jpg", "Факультет електроенерготехніки та автоматики",-417, -444, 890, 665, 69);
            corps.AddCorps("FEL.jpg", "Факультет електроніки", 185, -485, 310, 710, 45);
            corps.AddCorps("FIOT.jpg", "Факультет інформатики та обчислюваної техніки", -43, -563, 545, 775, 46);
            corps.AddCorps("FL.jpg", "Факультет лінгвістики", -41, -323, 520, 543, 32);
            corps.AddCorps("FMM.jpg", "Факультет менеджменту та маркетингу",  -317, -127, 794, 360, 11);
            corps.AddCorps("FSP.jpg", "Факультет соціології і права", -41, -323, 520, 543, 32);
            corps.AddCorps("FPM.jpg", "Факультет прикладної математики", -3, -443, 500, 689, 63);
            corps.AddCorps("FMF.jpg", "Фізико-математичний факультет", -41, -323, 520, 543, 70);
            corps.AddCorps("HTF.jpg", "Хіміко-технологічний факультет", 186, -120, 355, 350, 14);
            CorpsList.Items.AddRange(CorpsClass.NameCorps.ToArray());

            //------------------------------------------------------------
            graf.AddVertex(82, 40);
            graf.AddVertex(1195, 40);
            graf.AddVertex(1299, 46);
            graf.AddVertex(131, 296);
            graf.AddVertex(1109, 259);
            graf.AddVertex(1284, 300);
            graf.AddVertex(122, 190);
            graf.AddVertex(1039, 289);
            graf.AddVertex(901, 293);
            graf.AddVertex(746, 293);
            graf.AddVertex(821, 361);
            graf.AddVertex(431, 298);
            graf.AddVertex(313, 298);
            graf.AddVertex(374, 338);
            graf.AddVertex(170, 298);
            graf.AddVertex(500, 298);
            graf.AddVertex(662, 298);
            graf.AddVertex(660, 425);
            graf.AddVertex(493, 420);
            graf.AddVertex(259, 425);
            graf.AddVertex(188, 436);
            graf.AddVertex(1263, 378);
            graf.AddVertex(1131, 449);
            graf.AddVertex(999, 489);
            graf.AddVertex(830, 465);
            graf.AddVertex(673, 468);
            graf.AddVertex(1067, 489);
            graf.AddVertex(685, 533);
            graf.AddVertex(901, 574);
            graf.AddVertex(751, 585);
            graf.AddVertex(282, 595);
            graf.AddVertex(560, 610);
            graf.AddVertex(1232, 606);
            graf.AddVertex(1141, 610);
            graf.AddVertex(1063, 617);
            graf.AddVertex(908, 629);
            graf.AddVertex(767, 662);
            graf.AddVertex(619, 673);
            graf.AddVertex(472, 682);
            graf.AddVertex(411, 684);
            graf.AddVertex(408, 643);
            graf.AddVertex(305, 650);
            graf.AddVertex(221, 686);
            graf.AddVertex(244, 775);
            graf.AddVertex(332, 761);
            graf.AddVertex(571, 765);
            graf.AddVertex(623, 742);
            graf.AddVertex(791, 700);
            graf.AddVertex(757, 765);
            graf.AddVertex(950, 655);
            graf.AddVertex(1074, 696);
            graf.AddVertex(1268, 666);
            graf.AddVertex(1295, 706);
            graf.AddVertex(1072, 740);
            graf.AddVertex(1061, 850);
            graf.AddVertex(955, 749);
            graf.AddVertex(956, 842);
            graf.AddVertex(814, 881);
            graf.AddVertex(815, 850);
            graf.AddVertex(1219, 693);
            graf.AddVertex(280, 926);
            graf.AddVertex(414, 758);
            graf.AddVertex(475, 745);
            graf.AddVertex(701, 704);
            graf.AddVertex(1191, 282);
            graf.AddVertex(1186, 371);
            graf.AddVertex(1150, 656);
            graf.AddVertex(886, 649);
            graf.AddVertex(893, 699);
            graf.AddVertex(521, 737);
            graf.AddVertex(420, 500);
            graf.AddVertex(545, 488);
            graf.AddVertex(521, 682);

            //-------------------------------------------------------------

            graf.AddEdges(1, 2);
            graf.AddEdges(1, 7);
            graf.AddEdges(2, 3);
            graf.AddEdges(2, 5);
            graf.AddEdges(3, 6);
            graf.AddEdges(4, 7);
            graf.AddEdges(4, 15);
            graf.AddEdges(4, 43);
            graf.AddEdges(5, 8);
            graf.AddEdges(5, 65);
            graf.AddEdges(6, 22);
            graf.AddEdges(6, 65);
            graf.AddEdges(8, 9);
            graf.AddEdges(8, 24);
            graf.AddEdges(9, 10);
            graf.AddEdges(9, 11);
            graf.AddEdges(10, 11);
            graf.AddEdges(10, 17);
            graf.AddEdges(12, 13);
            graf.AddEdges(12, 14);
            graf.AddEdges(12, 16);
            graf.AddEdges(13, 14);
            graf.AddEdges(13, 15);
            graf.AddEdges(15, 21);
            graf.AddEdges(16, 17);
            graf.AddEdges(16, 19);
            graf.AddEdges(17, 18);
            graf.AddEdges(18, 19);
            graf.AddEdges(18, 26);
            graf.AddEdges(18, 71);
            graf.AddEdges(19, 20);
            graf.AddEdges(19, 71);
            graf.AddEdges(20, 21);
            graf.AddEdges(20, 31);
            graf.AddEdges(22, 23);
            graf.AddEdges(23, 27);
            graf.AddEdges(23, 33);
            graf.AddEdges(24, 25);
            graf.AddEdges(24, 29);
            graf.AddEdges(25, 26);
            graf.AddEdges(26, 71);
            graf.AddEdges(26, 28);
            graf.AddEdges(27, 34);
            graf.AddEdges(27, 36);
            graf.AddEdges(28, 30);
            graf.AddEdges(29, 30);
            graf.AddEdges(30, 37);
            graf.AddEdges(31, 43);
            graf.AddEdges(32, 38);
            graf.AddEdges(32, 39);
            graf.AddEdges(32, 72);
            graf.AddEdges(32, 73);
            graf.AddEdges(33, 34);
            graf.AddEdges(33, 52);
            graf.AddEdges(34, 35);
            graf.AddEdges(36, 50);
            graf.AddEdges(36, 68);
            graf.AddEdges(37, 38);
            graf.AddEdges(37, 48);
            graf.AddEdges(38, 73);
            graf.AddEdges(38, 47);
            graf.AddEdges(39, 40);
            graf.AddEdges(39, 73);
            graf.AddEdges(40, 41);
            graf.AddEdges(40, 43);
            graf.AddEdges(40, 62);
            graf.AddEdges(41, 42);
            graf.AddEdges(41, 71);
            graf.AddEdges(42, 43);
            graf.AddEdges(43, 44);
            graf.AddEdges(44, 45);
            graf.AddEdges(44, 61);
            graf.AddEdges(45, 62);
            graf.AddEdges(46, 47);
            graf.AddEdges(46, 63);
            graf.AddEdges(46, 70);
            graf.AddEdges(47, 48);
            graf.AddEdges(47, 49);
            graf.AddEdges(47, 64);
            graf.AddEdges(48, 49);
            graf.AddEdges(48, 59);
            graf.AddEdges(48, 64);
            graf.AddEdges(48, 68);
            graf.AddEdges(50, 56);
            graf.AddEdges(51, 54);
            graf.AddEdges(51, 60);
            graf.AddEdges(51, 67);
            graf.AddEdges(52, 53);
            graf.AddEdges(52, 60);
            graf.AddEdges(53, 55);
            graf.AddEdges(54, 56);
            graf.AddEdges(55, 58);
            graf.AddEdges(56, 57);
            graf.AddEdges(57, 59);
            graf.AddEdges(58, 59);
            graf.AddEdges(58, 61);
            graf.AddEdges(60, 67);
            graf.AddEdges(62, 63);
            graf.AddEdges(63, 70);
            graf.AddEdges(65, 66);
            graf.AddEdges(68, 69);
            graf.AddEdges(70, 73);
            graf.AddEdges(71, 72);
        }

        private void KPIMap_Paint(object sender, PaintEventArgs e)
        {
            if (paint == true)
            {
                KPIMap.Invalidate();
                Graphics graph = e.Graphics;
                graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Pen p1 = new Pen(Color.OrangeRed, 20);
                Pen p2 = new Pen(Color.Red, 20);
                int i=0, d;
                int[] route = new int[500];
                route = graf.DijkstraAlgorithm(indexStart, GetRouteForm.finish);
                while (route[i] != 0)
                {
                    i++;
                }
                d=i-1;
                i = 0;
                graph.DrawLine(p1, xclick, yclick, Graf.X[indexStart-1], Graf.Y[indexStart-1]);
                while (i != d)
                {
                    graph.DrawLine(p2, Graf.X[route[i] - 1], Graf.Y[route[i] - 1], Graf.X[route[i + 1] - 1], Graf.Y[route[i + 1] - 1]);
                    i++;
                }
            }
        }

        private void GetRoute_Click(object sender, EventArgs e)
        {
            if (paint == true)
            {
                fix = -1;
                paint = false;
            }
            corpus.Visible = false;
            MessageBox.Show("Виберіть початкову точку");
            KPIMap.Cursor = Cursors.PanSouth;
            getroute = true;
        }

        private void ClearRoute_Click(object sender, EventArgs e)
        {
            paint = false;
            fix = -1;
            corpus.Visible = false;
            ClearRoute.Enabled = false;
            showmaps.Enabled = true;
        }

        private void KPIMap_MouseClick(object sender, MouseEventArgs e)
        {
            if (getroute == true)
            {
                corpus.Visible = false;

                int min = KPIMap.Width;
                double l;

                xclick = e.X;
                yclick = e.Y;

                for (int i = 0; i < Graf.num; i++)
                {
                    l = Math.Sqrt(Math.Pow(Graf.X[i]-xclick, 2)+Math.Pow(Graf.Y[i]-yclick, 2));
                    if (min > l)
                    {
                        indexStart = i + 1;
                        min = (int)l;
                    }

                }

                GetRouteForm window = new GetRouteForm();
                window.ShowDialog();
                if (paint == true)
                {
                    showmaps.Enabled = false;
                    fix = GetRouteForm.select;
                    corpus.Visible = true;
                    KPIMap.Location = new Point(CorpsClass.xList[fix], CorpsClass.yList[fix]);
                    corpus.Location = new Point(CorpsClass.xList[fix] + CorpsClass.ListXcorps[fix], CorpsClass.yList[fix] + CorpsClass.ListYcorps[fix]);
                    ClearRoute.Enabled = true;
                }

            }
            KPIMap.Cursor = Cursors.SizeAll;
            getroute = false;
        }
    }
}
