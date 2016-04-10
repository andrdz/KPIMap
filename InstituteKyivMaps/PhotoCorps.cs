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
    public partial class PhotoCorps : Form
    {
        public PhotoCorps()
        {
            InitializeComponent();
        }

        CorpsClass institutes = new CorpsClass();

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Photo_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Width = Photo.Width + 20;
            Height = Photo.Height + 90;
            btnOK.Location = new Point(Photo.Width- 50, Photo.Height + 10);
        }
    }
}
