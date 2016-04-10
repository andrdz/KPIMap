namespace InstituteKyivMaps
{
    partial class GetRouteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.PointLabel = new System.Windows.Forms.Label();
            this.ListCorps = new System.Windows.Forms.ComboBox();
            this.GetRouteButton = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromLabel.Location = new System.Drawing.Point(32, 20);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(50, 24);
            this.FromLabel.TabIndex = 0;
            this.FromLabel.Text = "Від:";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToLabel.Location = new System.Drawing.Point(32, 67);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(45, 24);
            this.ToLabel.TabIndex = 1;
            this.ToLabel.Text = "До:";
            // 
            // PointLabel
            // 
            this.PointLabel.AutoSize = true;
            this.PointLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PointLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PointLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PointLabel.Location = new System.Drawing.Point(88, 20);
            this.PointLabel.Name = "PointLabel";
            this.PointLabel.Size = new System.Drawing.Size(105, 26);
            this.PointLabel.TabIndex = 2;
            this.PointLabel.Text = "X: 0; Y: 0;";
            // 
            // ListCorps
            // 
            this.ListCorps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ListCorps.FormattingEnabled = true;
            this.ListCorps.Location = new System.Drawing.Point(88, 72);
            this.ListCorps.Name = "ListCorps";
            this.ListCorps.Size = new System.Drawing.Size(324, 21);
            this.ListCorps.TabIndex = 3;
            this.ListCorps.Text = "(Виберіть інститут або факультет)";
            this.ListCorps.SelectedIndexChanged += new System.EventHandler(this.ListCorps_SelectedIndexChanged);
            // 
            // GetRouteButton
            // 
            this.GetRouteButton.Location = new System.Drawing.Point(213, 124);
            this.GetRouteButton.Name = "GetRouteButton";
            this.GetRouteButton.Size = new System.Drawing.Size(118, 25);
            this.GetRouteButton.TabIndex = 4;
            this.GetRouteButton.Text = "Прокласти маршрут";
            this.GetRouteButton.UseVisualStyleBackColor = true;
            this.GetRouteButton.Click += new System.EventHandler(this.GetRouteButton_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(337, 124);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 25);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Відміна";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // GetRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(424, 161);
            this.ControlBox = false;
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.GetRouteButton);
            this.Controls.Add(this.ListCorps);
            this.Controls.Add(this.PointLabel);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.FromLabel);
            this.Name = "GetRouteForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прокласти маршрут";
            this.Load += new System.EventHandler(this.GetRouteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label PointLabel;
        private System.Windows.Forms.ComboBox ListCorps;
        private System.Windows.Forms.Button GetRouteButton;
        private System.Windows.Forms.Button CancelBtn;
    }
}