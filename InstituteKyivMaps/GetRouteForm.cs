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
    public partial class GetRouteForm : Form
    {
        public GetRouteForm()
        {
            InitializeComponent();
        }

        public static int finish;
        public static int select;

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GetRouteForm_Load(object sender, EventArgs e)
        {
            PointLabel.Text = "X: " + MainForm.xclick + "; Y: " + MainForm.yclick;
            ListCorps.Items.AddRange(CorpsClass.NameCorps.ToArray());
        }

        private void GetRouteButton_Click(object sender, EventArgs e)
        {
            select = ListCorps.SelectedIndex;
            if (select > -1)
            {
                finish = CorpsClass.ToVertex[select];
                MainForm.paint = true;
                Close();
            }
            else
                MessageBox.Show("Спочатку виберіть інститут або факультет");
        }

        private void ListCorps_SelectedIndexChanged(object sender, EventArgs e)
        {
            select = ListCorps.SelectedIndex;
        }
    }
}
