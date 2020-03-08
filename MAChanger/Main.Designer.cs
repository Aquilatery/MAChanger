namespace MAChanger
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Adapters = new System.Windows.Forms.ComboBox();
            this.CurrentMAC = new System.Windows.Forms.TextBox();
            this.NewMAC = new System.Windows.Forms.TextBox();
            this.Current = new System.Windows.Forms.Label();
            this.New = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Button();
            this.Summon = new System.Windows.Forms.Button();
            this.SAVE = new System.Windows.Forms.Button();
            this.BACK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Adapters
            // 
            this.Adapters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Adapters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Adapters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Adapters.FormattingEnabled = true;
            this.Adapters.Location = new System.Drawing.Point(12, 12);
            this.Adapters.Name = "Adapters";
            this.Adapters.Size = new System.Drawing.Size(364, 21);
            this.Adapters.TabIndex = 0;
            this.Adapters.SelectedIndexChanged += new System.EventHandler(this.Adapters_SelectedIndexChanged);
            // 
            // CurrentMAC
            // 
            this.CurrentMAC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CurrentMAC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CurrentMAC.Location = new System.Drawing.Point(185, 39);
            this.CurrentMAC.MaxLength = 12;
            this.CurrentMAC.Name = "CurrentMAC";
            this.CurrentMAC.ReadOnly = true;
            this.CurrentMAC.Size = new System.Drawing.Size(110, 20);
            this.CurrentMAC.TabIndex = 1;
            this.CurrentMAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewMAC
            // 
            this.NewMAC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NewMAC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NewMAC.Location = new System.Drawing.Point(185, 64);
            this.NewMAC.MaxLength = 12;
            this.NewMAC.Name = "NewMAC";
            this.NewMAC.Size = new System.Drawing.Size(110, 20);
            this.NewMAC.TabIndex = 2;
            this.NewMAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewMAC.TextChanged += new System.EventHandler(this.NewMAC_TextChanged);
            // 
            // Current
            // 
            this.Current.Location = new System.Drawing.Point(12, 39);
            this.Current.Name = "Current";
            this.Current.Size = new System.Drawing.Size(166, 20);
            this.Current.TabIndex = 3;
            this.Current.Text = "Kullanılan MAC Adresi:";
            this.Current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(12, 64);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(166, 20);
            this.New.TabIndex = 4;
            this.New.Text = "Değiştirilecek MAC Adresi:";
            this.New.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Refresh
            // 
            this.Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refresh.Location = new System.Drawing.Point(302, 39);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 20);
            this.Refresh.TabIndex = 5;
            this.Refresh.Text = "Yenile";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Summon
            // 
            this.Summon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Summon.Location = new System.Drawing.Point(302, 64);
            this.Summon.Name = "Summon";
            this.Summon.Size = new System.Drawing.Size(75, 20);
            this.Summon.TabIndex = 6;
            this.Summon.Text = "Oluştur";
            this.Summon.UseVisualStyleBackColor = true;
            this.Summon.Click += new System.EventHandler(this.Summon_Click);
            // 
            // SAVE
            // 
            this.SAVE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SAVE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SAVE.Enabled = false;
            this.SAVE.Location = new System.Drawing.Point(100, 90);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(88, 35);
            this.SAVE.TabIndex = 7;
            this.SAVE.Text = "KAYDET";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // BACK
            // 
            this.BACK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BACK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BACK.Location = new System.Drawing.Point(200, 90);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(88, 35);
            this.BACK.TabIndex = 8;
            this.BACK.Text = "GERİ AL";
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 137);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.Summon);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Current);
            this.Controls.Add(this.NewMAC);
            this.Controls.Add(this.CurrentMAC);
            this.Controls.Add(this.Adapters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAC Changer v1.1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CurrentMAC;
        private System.Windows.Forms.TextBox NewMAC;
        private System.Windows.Forms.Label Current;
        private System.Windows.Forms.Label New;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Summon;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.ComboBox Adapters;
    }
}