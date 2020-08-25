namespace MAChanger
{
    partial class MAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN));
            Adapters_CB = new ReaLTaiizor.Controls.ComboBox.ForeverComboBox();
            Refresh_B = new ReaLTaiizor.Controls.Button.LostAcceptButton();
            Generate_B = new ReaLTaiizor.Controls.Button.LostCancelButton();
            Current_L = new ReaLTaiizor.Controls.Label.ForeverLabel();
            New_L = new ReaLTaiizor.Controls.Label.ForeverLabel();
            New_TB = new ReaLTaiizor.Controls.TextBox.ForeverTextBox();
            Current_TB = new ReaLTaiizor.Controls.TextBox.ForeverTextBox();
            Save_B = new ReaLTaiizor.Controls.Button.LostButton();
            Undo_B = new ReaLTaiizor.Controls.Button.LostButton();
            SuspendLayout();
            // 
            // Adapters_CB
            // 
            Adapters_CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            Adapters_CB.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            Adapters_CB.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            Adapters_CB.Cursor = System.Windows.Forms.Cursors.Hand;
            Adapters_CB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            Adapters_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Adapters_CB.Font = new System.Drawing.Font("Segoe UI", 8F);
            Adapters_CB.ForeColor = System.Drawing.Color.White;
            Adapters_CB.FormattingEnabled = true;
            Adapters_CB.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            Adapters_CB.HoverFontColor = System.Drawing.Color.White;
            Adapters_CB.ItemHeight = 18;
            Adapters_CB.Location = new System.Drawing.Point(5, 39);
            Adapters_CB.MaxDropDownItems = 12;
            Adapters_CB.Name = "Adapters_CB";
            Adapters_CB.Size = new System.Drawing.Size(394, 24);
            Adapters_CB.TabIndex = 3;
            Adapters_CB.SelectedIndexChanged += new System.EventHandler(Adapters_CB_SelectedIndexChanged);
            // 
            // Refresh_B
            // 
            Refresh_B.BackColor = System.Drawing.Color.SeaGreen;
            Refresh_B.Cursor = System.Windows.Forms.Cursors.Hand;
            Refresh_B.Font = new System.Drawing.Font("Segoe UI", 9F);
            Refresh_B.ForeColor = System.Drawing.Color.White;
            Refresh_B.HoverColor = System.Drawing.Color.ForestGreen;
            Refresh_B.Image = null;
            Refresh_B.Location = new System.Drawing.Point(295, 69);
            Refresh_B.Name = "Refresh_B";
            Refresh_B.Size = new System.Drawing.Size(104, 29);
            Refresh_B.TabIndex = 5;
            Refresh_B.Text = "Refresh";
            Refresh_B.Click += new System.EventHandler(Refresh_B_Click);
            // 
            // Generate_B
            // 
            Generate_B.BackColor = System.Drawing.Color.Crimson;
            Generate_B.Cursor = System.Windows.Forms.Cursors.Hand;
            Generate_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            Generate_B.ForeColor = System.Drawing.Color.White;
            Generate_B.HoverColor = System.Drawing.Color.IndianRed;
            Generate_B.Image = null;
            Generate_B.Location = new System.Drawing.Point(295, 104);
            Generate_B.Name = "Generate_B";
            Generate_B.Size = new System.Drawing.Size(104, 29);
            Generate_B.TabIndex = 6;
            Generate_B.Text = "Generate";
            Generate_B.Click += new System.EventHandler(Generate_B_Click);
            // 
            // Current_L
            // 
            Current_L.BackColor = System.Drawing.Color.Transparent;
            Current_L.Font = new System.Drawing.Font("Segoe UI", 10F);
            Current_L.ForeColor = System.Drawing.Color.LightGray;
            Current_L.Location = new System.Drawing.Point(5, 69);
            Current_L.Name = "Current_L";
            Current_L.Size = new System.Drawing.Size(168, 29);
            Current_L.TabIndex = 8;
            Current_L.Text = "MAC Address Used:";
            Current_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // New_L
            // 
            New_L.BackColor = System.Drawing.Color.Transparent;
            New_L.Font = new System.Drawing.Font("Segoe UI", 10F);
            New_L.ForeColor = System.Drawing.Color.LightGray;
            New_L.Location = new System.Drawing.Point(5, 104);
            New_L.Name = "New_L";
            New_L.Size = new System.Drawing.Size(168, 29);
            New_L.TabIndex = 10;
            New_L.Text = "New MAC Address:";
            New_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // New_TB
            // 
            New_TB.BackColor = System.Drawing.Color.Transparent;
            New_TB.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            New_TB.BorderColor = System.Drawing.Color.Crimson;
            New_TB.FocusOnHover = false;
            New_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            New_TB.Location = new System.Drawing.Point(179, 104);
            New_TB.MaxLength = 12;
            New_TB.Multiline = false;
            New_TB.Name = "New_TB";
            New_TB.ReadOnly = false;
            New_TB.Size = new System.Drawing.Size(110, 29);
            New_TB.TabIndex = 9;
            New_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            New_TB.UseSystemPasswordChar = false;
            New_TB.KeyUp += new System.Windows.Forms.KeyEventHandler(New_TB_KeyUp);
            New_TB.TextChanged += new System.EventHandler(New_TB_TextChanged);
            // 
            // Current_TB
            // 
            Current_TB.BackColor = System.Drawing.Color.Transparent;
            Current_TB.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            Current_TB.BorderColor = System.Drawing.Color.SeaGreen;
            Current_TB.FocusOnHover = false;
            Current_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            Current_TB.Location = new System.Drawing.Point(179, 69);
            Current_TB.MaxLength = 12;
            Current_TB.Multiline = false;
            Current_TB.Name = "Current_TB";
            Current_TB.ReadOnly = true;
            Current_TB.Size = new System.Drawing.Size(110, 29);
            Current_TB.TabIndex = 7;
            Current_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            Current_TB.UseSystemPasswordChar = false;
            // 
            // Save_B
            // 
            Save_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            Save_B.Cursor = System.Windows.Forms.Cursors.Hand;
            Save_B.Font = new System.Drawing.Font("Segoe UI", 9F);
            Save_B.ForeColor = System.Drawing.Color.White;
            Save_B.HoverColor = System.Drawing.Color.DodgerBlue;
            Save_B.Image = null;
            Save_B.Location = new System.Drawing.Point(5, 136);
            Save_B.Name = "Save_B";
            Save_B.Size = new System.Drawing.Size(168, 35);
            Save_B.TabIndex = 11;
            Save_B.Text = "SAVE";
            Save_B.Click += new System.EventHandler(Save_B_Click);
            // 
            // Undo_B
            // 
            Undo_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            Undo_B.Cursor = System.Windows.Forms.Cursors.Hand;
            Undo_B.Font = new System.Drawing.Font("Segoe UI", 9F);
            Undo_B.ForeColor = System.Drawing.Color.White;
            Undo_B.HoverColor = System.Drawing.Color.DodgerBlue;
            Undo_B.Image = null;
            Undo_B.Location = new System.Drawing.Point(231, 139);
            Undo_B.Name = "Undo_B";
            Undo_B.Size = new System.Drawing.Size(168, 35);
            Undo_B.TabIndex = 12;
            Undo_B.Text = "UNDO";
            Undo_B.Click += new System.EventHandler(Undo_B_Click);
            // 
            // MAIN
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            ClientSize = new System.Drawing.Size(404, 182);
            Controls.Add(Undo_B);
            Controls.Add(Save_B);
            Controls.Add(New_L);
            Controls.Add(New_TB);
            Controls.Add(Current_L);
            Controls.Add(Current_TB);
            Controls.Add(Generate_B);
            Controls.Add(Refresh_B);
            Controls.Add(Adapters_CB);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            Image = global::MAChanger.Properties.Resources.Wifi;
            MaximizeBox = false;
            Name = "MAIN";
            Sizable = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "MAC Changer v1.5";
            Load += new System.EventHandler(MAIN_Load);
            ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.ComboBox.ForeverComboBox Adapters_CB;
        private ReaLTaiizor.Controls.Button.LostAcceptButton Refresh_B;
        private ReaLTaiizor.Controls.Button.LostCancelButton Generate_B;
        private ReaLTaiizor.Controls.Label.ForeverLabel Current_L;
        private ReaLTaiizor.Controls.Label.ForeverLabel New_L;
        private ReaLTaiizor.Controls.TextBox.ForeverTextBox New_TB;
        private ReaLTaiizor.Controls.TextBox.ForeverTextBox Current_TB;
        private ReaLTaiizor.Controls.Button.LostButton Save_B;
        private ReaLTaiizor.Controls.Button.LostButton Undo_B;
    }
}