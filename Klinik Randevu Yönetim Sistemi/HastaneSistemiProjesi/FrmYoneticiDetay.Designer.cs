namespace HastaneSistemiProjesi
{
    partial class FrmYoneticiDetay
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
            this.BtnBransPanel = new System.Windows.Forms.Button();
            this.BtnDoktorPaneli = new System.Windows.Forms.Button();
            this.BtnSekreterPaneli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBransPanel
            // 
            this.BtnBransPanel.Location = new System.Drawing.Point(78, 47);
            this.BtnBransPanel.Name = "BtnBransPanel";
            this.BtnBransPanel.Size = new System.Drawing.Size(153, 35);
            this.BtnBransPanel.TabIndex = 19;
            this.BtnBransPanel.Text = "Branş Paneli";
            this.BtnBransPanel.UseVisualStyleBackColor = true;
            this.BtnBransPanel.Click += new System.EventHandler(this.BtnBransPanel_Click);
            // 
            // BtnDoktorPaneli
            // 
            this.BtnDoktorPaneli.Location = new System.Drawing.Point(78, 106);
            this.BtnDoktorPaneli.Name = "BtnDoktorPaneli";
            this.BtnDoktorPaneli.Size = new System.Drawing.Size(153, 35);
            this.BtnDoktorPaneli.TabIndex = 18;
            this.BtnDoktorPaneli.Text = "Doktor Paneli";
            this.BtnDoktorPaneli.UseVisualStyleBackColor = true;
            this.BtnDoktorPaneli.Click += new System.EventHandler(this.BtnDoktorPaneli_Click);
            // 
            // BtnSekreterPaneli
            // 
            this.BtnSekreterPaneli.Location = new System.Drawing.Point(78, 167);
            this.BtnSekreterPaneli.Name = "BtnSekreterPaneli";
            this.BtnSekreterPaneli.Size = new System.Drawing.Size(153, 35);
            this.BtnSekreterPaneli.TabIndex = 20;
            this.BtnSekreterPaneli.Text = "Sekreter Paneli";
            this.BtnSekreterPaneli.UseVisualStyleBackColor = true;
            this.BtnSekreterPaneli.Click += new System.EventHandler(this.BtnSekreterPaneli_Click);
            // 
            // FrmYoneticiDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSekreterPaneli);
            this.Controls.Add(this.BtnBransPanel);
            this.Controls.Add(this.BtnDoktorPaneli);
            this.Name = "FrmYoneticiDetay";
            this.Text = "FrmYoneticiDetay";
            this.Load += new System.EventHandler(this.FrmYoneticiDetay_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBransPanel;
        private System.Windows.Forms.Button BtnDoktorPaneli;
        private System.Windows.Forms.Button BtnSekreterPaneli;
    }
}