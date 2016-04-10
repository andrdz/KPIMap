namespace InstituteKyivMaps
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PanelMenu = new System.Windows.Forms.MenuStrip();
            this.CorpsList = new System.Windows.Forms.ToolStripComboBox();
            this.ListInstitute = new System.Windows.Forms.ToolStripComboBox();
            this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KPIMap = new System.Windows.Forms.PictureBox();
            this.Map = new System.Windows.Forms.Panel();
            this.corpus = new System.Windows.Forms.PictureBox();
            this.showmaps = new System.Windows.Forms.Button();
            this.GetRoute = new System.Windows.Forms.Button();
            this.ClearRoute = new System.Windows.Forms.Button();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KPIMap)).BeginInit();
            this.Map.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.corpus)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.Gray;
            this.PanelMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CorpsList});
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(984, 27);
            this.PanelMenu.TabIndex = 0;
            // 
            // CorpsList
            // 
            this.CorpsList.Name = "CorpsList";
            this.CorpsList.Size = new System.Drawing.Size(460, 23);
            this.CorpsList.Text = "Інститути & факультети";
            // 
            // ListInstitute
            // 
            this.ListInstitute.Items.AddRange(new object[] {
            "Національний технічний університет України \"Київський політехнічний інститут\""});
            this.ListInstitute.Name = "ListInstitute";
            this.ListInstitute.Size = new System.Drawing.Size(500, 23);
            this.ListInstitute.Text = "Навчальні заклади Києва";
            // 
            // проПрограмуToolStripMenuItem
            // 
            this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.проПрограмуToolStripMenuItem.Text = "Про програму";
            // 
            // KPIMap
            // 
            this.KPIMap.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.KPIMap.Image = ((System.Drawing.Image)(resources.GetObject("KPIMap.Image")));
            this.KPIMap.Location = new System.Drawing.Point(-427, -195);
            this.KPIMap.Name = "KPIMap";
            this.KPIMap.Size = new System.Drawing.Size(1424, 1083);
            this.KPIMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.KPIMap.TabIndex = 0;
            this.KPIMap.TabStop = false;
            this.KPIMap.Paint += new System.Windows.Forms.PaintEventHandler(this.KPIMap_Paint);
            this.KPIMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.KPIMap_MouseClick);
            this.KPIMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KPIMap_MouseDown);
            this.KPIMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KPIMap_MouseMove);
            // 
            // Map
            // 
            this.Map.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Map.Controls.Add(this.corpus);
            this.Map.Controls.Add(this.KPIMap);
            this.Map.Location = new System.Drawing.Point(0, 30);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(984, 531);
            this.Map.TabIndex = 1;
            this.Map.Paint += new System.Windows.Forms.PaintEventHandler(this.Map_Paint);
            // 
            // corpus
            // 
            this.corpus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.corpus.Image = ((System.Drawing.Image)(resources.GetObject("corpus.Image")));
            this.corpus.InitialImage = null;
            this.corpus.Location = new System.Drawing.Point(0, 0);
            this.corpus.Name = "corpus";
            this.corpus.Size = new System.Drawing.Size(50, 50);
            this.corpus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.corpus.TabIndex = 1;
            this.corpus.TabStop = false;
            this.corpus.Visible = false;
            this.corpus.Click += new System.EventHandler(this.corpus_Click);
            // 
            // showmaps
            // 
            this.showmaps.Location = new System.Drawing.Point(471, 2);
            this.showmaps.Name = "showmaps";
            this.showmaps.Size = new System.Drawing.Size(114, 23);
            this.showmaps.TabIndex = 2;
            this.showmaps.Text = "Показати на карті";
            this.showmaps.UseVisualStyleBackColor = true;
            this.showmaps.Click += new System.EventHandler(this.showmaps_Click);
            // 
            // GetRoute
            // 
            this.GetRoute.Location = new System.Drawing.Point(737, 2);
            this.GetRoute.Name = "GetRoute";
            this.GetRoute.Size = new System.Drawing.Size(119, 23);
            this.GetRoute.TabIndex = 8;
            this.GetRoute.Text = "Прокласти маршрут";
            this.GetRoute.UseVisualStyleBackColor = true;
            this.GetRoute.Click += new System.EventHandler(this.GetRoute_Click);
            // 
            // ClearRoute
            // 
            this.ClearRoute.Location = new System.Drawing.Point(862, 2);
            this.ClearRoute.Name = "ClearRoute";
            this.ClearRoute.Size = new System.Drawing.Size(119, 23);
            this.ClearRoute.TabIndex = 10;
            this.ClearRoute.Text = "Прибрати маршрут";
            this.ClearRoute.UseVisualStyleBackColor = true;
            this.ClearRoute.Click += new System.EventHandler(this.ClearRoute_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.ClearRoute);
            this.Controls.Add(this.GetRoute);
            this.Controls.Add(this.showmaps);
            this.Controls.Add(this.Map);
            this.Controls.Add(this.PanelMenu);
            this.MainMenuStrip = this.PanelMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Факультети та інститути КПІ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KPIMap)).EndInit();
            this.Map.ResumeLayout(false);
            this.Map.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.corpus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip PanelMenu;
        private System.Windows.Forms.ToolStripComboBox ListInstitute;
        private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
        private System.Windows.Forms.PictureBox KPIMap;
        private System.Windows.Forms.Panel Map;
        private System.Windows.Forms.ToolStripComboBox CorpsList;
        private System.Windows.Forms.Button showmaps;
        private System.Windows.Forms.Button GetRoute;
        private System.Windows.Forms.Button ClearRoute;
        public System.Windows.Forms.PictureBox corpus;
    }
}

