namespace CookieVirus
{
    partial class CookieVirus
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
            this.components = new System.ComponentModel.Container();
            this.starttimer = new System.Windows.Forms.Timer(this.components);
            this.movetimer = new System.Windows.Forms.Timer(this.components);
            this.intro0 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.monster0 = new System.Windows.Forms.PictureBox();
            this.cookie1 = new System.Windows.Forms.PictureBox();
            this.cookie0 = new System.Windows.Forms.PictureBox();
            this.intro1 = new System.Windows.Forms.PictureBox();
            this.chomp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.monster0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookie0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intro1)).BeginInit();
            this.SuspendLayout();
            // 
            // intro0
            // 
            this.intro0.AutoSize = true;
            this.intro0.Font = new System.Drawing.Font("Segoe UI Symbol", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intro0.Location = new System.Drawing.Point(633, 39);
            this.intro0.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.intro0.Name = "intro0";
            this.intro0.Size = new System.Drawing.Size(798, 384);
            this.intro0.TabIndex = 0;
            this.intro0.Text = "I want a Cookie.\r\nGive me a cookie.\r\nN     W!";
            this.intro0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // monster0
            // 
            this.monster0.Image = global::CookieVirus.Properties.Resources._9cpbzoRyi;
            this.monster0.Location = new System.Drawing.Point(12, 61);
            this.monster0.Name = "monster0";
            this.monster0.Size = new System.Drawing.Size(209, 102);
            this.monster0.TabIndex = 6;
            this.monster0.TabStop = false;
            this.monster0.Visible = false;
            // 
            // cookie1
            // 
            this.cookie1.Image = global::CookieVirus.Properties.Resources.tumblr_inline_nlivuq0i4t1qmxivf_400;
            this.cookie1.Location = new System.Drawing.Point(423, 52);
            this.cookie1.Name = "cookie1";
            this.cookie1.Size = new System.Drawing.Size(121, 111);
            this.cookie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cookie1.TabIndex = 4;
            this.cookie1.TabStop = false;
            this.cookie1.Visible = false;
            // 
            // cookie0
            // 
            this.cookie0.Image = global::CookieVirus.Properties.Resources.tumblr_inline_nlivuq0i4t1qmxivf_400;
            this.cookie0.Location = new System.Drawing.Point(261, 52);
            this.cookie0.Name = "cookie0";
            this.cookie0.Size = new System.Drawing.Size(121, 111);
            this.cookie0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cookie0.TabIndex = 3;
            this.cookie0.TabStop = false;
            this.cookie0.Visible = false;
            // 
            // intro1
            // 
            this.intro1.Image = global::CookieVirus.Properties.Resources.cookie_monster_clip_art_cookie_monster_by_neorame_d4yb0b5;
            this.intro1.Location = new System.Drawing.Point(945, 300);
            this.intro1.Name = "intro1";
            this.intro1.Size = new System.Drawing.Size(123, 123);
            this.intro1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.intro1.TabIndex = 1;
            this.intro1.TabStop = false;
            // 
            // chomp
            // 
            this.chomp.AutoSize = true;
            this.chomp.Location = new System.Drawing.Point(220, 193);
            this.chomp.Name = "chomp";
            this.chomp.Size = new System.Drawing.Size(144, 47);
            this.chomp.TabIndex = 7;
            this.chomp.Text = "Chomp!";
            this.chomp.Visible = false;
            // 
            // CookieVirus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 47F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1924, 942);
            this.Controls.Add(this.chomp);
            this.Controls.Add(this.monster0);
            this.Controls.Add(this.cookie1);
            this.Controls.Add(this.cookie0);
            this.Controls.Add(this.intro1);
            this.Controls.Add(this.intro0);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.Name = "CookieVirus";
            this.Opacity = 0.75D;
            this.Text = "CookieVirus";
            this.Load += new System.EventHandler(this.CookieVirus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monster0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookie0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intro1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer starttimer;
        private System.Windows.Forms.Timer movetimer;
        private System.Windows.Forms.Label intro0;
        private System.Windows.Forms.PictureBox intro1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox cookie0;
        private System.Windows.Forms.PictureBox cookie1;
        private System.Windows.Forms.PictureBox monster0;
        private System.Windows.Forms.Label chomp;
    }
}

