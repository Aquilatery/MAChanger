namespace MAChanger
{
    partial class LAST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LAST));
            Adapters = new System.Windows.Forms.ComboBox();
            CurrentMAC = new System.Windows.Forms.TextBox();
            NewMAC = new System.Windows.Forms.TextBox();
            Current = new System.Windows.Forms.Label();
            New = new System.Windows.Forms.Label();
            Refresh = new System.Windows.Forms.Button();
            Summon = new System.Windows.Forms.Button();
            SAVE = new System.Windows.Forms.Button();
            BACK = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // Adapters
            // 
            Adapters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            Adapters.Cursor = System.Windows.Forms.Cursors.Hand;
            Adapters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Adapters.FormattingEnabled = true;
            Adapters.Location = new System.Drawing.Point(12, 12);
            Adapters.Name = "Adapters";
            Adapters.Size = new System.Drawing.Size(364, 21);
            Adapters.TabIndex = 0;
            Adapters.SelectedIndexChanged += new System.EventHandler(Adapters_SelectedIndexChanged);
            // 
            // CurrentMAC
            // 
            CurrentMAC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            CurrentMAC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            CurrentMAC.Location = new System.Drawing.Point(185, 39);
            CurrentMAC.MaxLength = 12;
            CurrentMAC.Name = "CurrentMAC";
            CurrentMAC.ReadOnly = true;
            CurrentMAC.Size = new System.Drawing.Size(110, 20);
            CurrentMAC.TabIndex = 1;
            CurrentMAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewMAC
            // 
            NewMAC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            NewMAC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            NewMAC.Location = new System.Drawing.Point(185, 64);
            NewMAC.MaxLength = 12;
            NewMAC.Name = "NewMAC";
            NewMAC.Size = new System.Drawing.Size(110, 20);
            NewMAC.TabIndex = 2;
            NewMAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            NewMAC.TextChanged += new System.EventHandler(NewMAC_TextChanged);
            // 
            // Current
            // 
            Current.Location = new System.Drawing.Point(12, 39);
            Current.Name = "Current";
            Current.Size = new System.Drawing.Size(166, 20);
            Current.TabIndex = 3;
            Current.Text = "MAC Address Used:";
            Current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // New
            // 
            New.Location = new System.Drawing.Point(12, 64);
            New.Name = "New";
            New.Size = new System.Drawing.Size(166, 20);
            New.TabIndex = 4;
            New.Text = "New MAC Address:";
            New.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Refresh
            // 
            Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            Refresh.Location = new System.Drawing.Point(302, 39);
            Refresh.Name = "Refresh";
            Refresh.Size = new System.Drawing.Size(75, 20);
            Refresh.TabIndex = 5;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += new System.EventHandler(Refresh_Click);
            // 
            // Summon
            // 
            Summon.Cursor = System.Windows.Forms.Cursors.Hand;
            Summon.Location = new System.Drawing.Point(302, 64);
            Summon.Name = "Summon";
            Summon.Size = new System.Drawing.Size(75, 20);
            Summon.TabIndex = 6;
            Summon.Text = "Generate";
            Summon.UseVisualStyleBackColor = true;
            Summon.Click += new System.EventHandler(Summon_Click);
            // 
            // SAVE
            // 
            SAVE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            SAVE.Cursor = System.Windows.Forms.Cursors.Hand;
            SAVE.Enabled = false;
            SAVE.Location = new System.Drawing.Point(100, 90);
            SAVE.Name = "SAVE";
            SAVE.Size = new System.Drawing.Size(88, 35);
            SAVE.TabIndex = 7;
            SAVE.Text = "SAVE";
            SAVE.UseVisualStyleBackColor = true;
            SAVE.Click += new System.EventHandler(SAVE_Click);
            // 
            // BACK
            // 
            BACK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            BACK.Cursor = System.Windows.Forms.Cursors.Hand;
            BACK.Location = new System.Drawing.Point(200, 90);
            BACK.Name = "BACK";
            BACK.Size = new System.Drawing.Size(88, 35);
            BACK.TabIndex = 8;
            BACK.Text = "UNDO";
            BACK.UseVisualStyleBackColor = true;
            BACK.Click += new System.EventHandler(BACK_Click);
            // 
            // LAST
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(388, 137);
            Controls.Add(BACK);
            Controls.Add(SAVE);
            Controls.Add(Summon);
            Controls.Add(Refresh);
            Controls.Add(New);
            Controls.Add(Current);
            Controls.Add(NewMAC);
            Controls.Add(CurrentMAC);
            Controls.Add(Adapters);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            Name = "LAST";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "MAC Changer v1.2";
            Load += new System.EventHandler(LAST_Load);
            ResumeLayout(false);
            PerformLayout();

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