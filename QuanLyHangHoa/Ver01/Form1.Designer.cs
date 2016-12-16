namespace Ver01
{
    partial class Form1
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
            this.mTHD = new MetroFramework.Controls.MetroTile();
            this.mTKH = new MetroFramework.Controls.MetroTile();
            this.mTNV = new MetroFramework.Controls.MetroTile();
            this.mTHH = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mTHD
            // 
            this.mTHD.ActiveControl = null;
            this.mTHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(162)))), ((int)(((byte)(29)))));
            this.mTHD.ForeColor = System.Drawing.Color.White;
            this.mTHD.Location = new System.Drawing.Point(262, 63);
            this.mTHD.Name = "mTHD";
            this.mTHD.Size = new System.Drawing.Size(182, 149);
            this.mTHD.TabIndex = 2;
            this.mTHD.Text = "Hóa Đơn";
            this.mTHD.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mTHD.TileImage = global::Ver01.Properties.Resources.tax_icon_151281;
            this.mTHD.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTHD.UseCustomBackColor = true;
            this.mTHD.UseCustomForeColor = true;
            this.mTHD.UseSelectable = true;
            this.mTHD.UseTileImage = true;
            this.mTHD.Click += new System.EventHandler(this.mTHD_Click);
            // 
            // mTKH
            // 
            this.mTKH.ActiveControl = null;
            this.mTKH.BackColor = System.Drawing.Color.White;
            this.mTKH.ForeColor = System.Drawing.Color.Black;
            this.mTKH.Location = new System.Drawing.Point(262, 218);
            this.mTKH.Name = "mTKH";
            this.mTKH.Size = new System.Drawing.Size(182, 147);
            this.mTKH.TabIndex = 2;
            this.mTKH.Text = "Thông Tin Khách Hàng";
            this.mTKH.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mTKH.TileImage = global::Ver01.Properties.Resources._76_512;
            this.mTKH.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTKH.UseCustomBackColor = true;
            this.mTKH.UseCustomForeColor = true;
            this.mTKH.UseSelectable = true;
            this.mTKH.UseTileImage = true;
            this.mTKH.Click += new System.EventHandler(this.mTKH_Click);
            // 
            // mTNV
            // 
            this.mTNV.ActiveControl = null;
            this.mTNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.mTNV.ForeColor = System.Drawing.Color.White;
            this.mTNV.Location = new System.Drawing.Point(58, 218);
            this.mTNV.Name = "mTNV";
            this.mTNV.Size = new System.Drawing.Size(184, 147);
            this.mTNV.TabIndex = 2;
            this.mTNV.Text = "Nhân Viên";
            this.mTNV.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mTNV.TileImage = global::Ver01.Properties.Resources.flat_faces_icons_circle_6_circle1;
            this.mTNV.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTNV.UseCustomBackColor = true;
            this.mTNV.UseSelectable = true;
            this.mTNV.UseTileImage = true;
            this.mTNV.Click += new System.EventHandler(this.mtNV_Click);
            // 
            // mTHH
            // 
            this.mTHH.ActiveControl = null;
            this.mTHH.BackColor = System.Drawing.Color.White;
            this.mTHH.Location = new System.Drawing.Point(58, 63);
            this.mTHH.Name = "mTHH";
            this.mTHH.Size = new System.Drawing.Size(184, 149);
            this.mTHH.Style = MetroFramework.MetroColorStyle.Black;
            this.mTHH.TabIndex = 2;
            this.mTHH.Text = "Quản lý Hàng Hóa";
            this.mTHH.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mTHH.TileImage = global::Ver01.Properties.Resources.box1;
            this.mTHH.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTHH.UseCustomBackColor = true;
            this.mTHH.UseCustomForeColor = true;
            this.mTHH.UseSelectable = true;
            this.mTHH.UseTileImage = true;
            this.mTHH.Click += new System.EventHandler(this.btnHH_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 381);
            this.Controls.Add(this.mTHD);
            this.Controls.Add(this.mTKH);
            this.Controls.Add(this.mTNV);
            this.Controls.Add(this.mTHH);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mTHH;
        private MetroFramework.Controls.MetroTile mTHD;
        private MetroFramework.Controls.MetroTile mTNV;
        private MetroFramework.Controls.MetroTile mTKH;
    }
}

