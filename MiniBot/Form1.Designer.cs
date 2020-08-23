namespace MiniBot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pcLife = new System.Windows.Forms.PictureBox();
            this.cbLifeHotkey = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbManaHotKey = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nupLifePercent = new System.Windows.Forms.NumericUpDown();
            this.nupManaPercent = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcLife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupLifePercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupManaPercent)).BeginInit();
            this.SuspendLayout();
            // 
            // pcLife
            // 
            this.pcLife.Image = ((System.Drawing.Image)(resources.GetObject("pcLife.Image")));
            this.pcLife.Location = new System.Drawing.Point(12, 12);
            this.pcLife.Name = "pcLife";
            this.pcLife.Size = new System.Drawing.Size(35, 35);
            this.pcLife.TabIndex = 0;
            this.pcLife.TabStop = false;
            // 
            // cbLifeHotkey
            // 
            this.cbLifeHotkey.FormattingEnabled = true;
            this.cbLifeHotkey.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.cbLifeHotkey.Location = new System.Drawing.Point(53, 26);
            this.cbLifeHotkey.Name = "cbLifeHotkey";
            this.cbLifeHotkey.Size = new System.Drawing.Size(76, 21);
            this.cbLifeHotkey.TabIndex = 1;
            this.cbLifeHotkey.SelectedIndexChanged += new System.EventHandler(this.cbLifeHotkey_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Life HotKey";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mana HotKey";
            // 
            // cbManaHotKey
            // 
            this.cbManaHotKey.FormattingEnabled = true;
            this.cbManaHotKey.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.cbManaHotKey.Location = new System.Drawing.Point(53, 84);
            this.cbManaHotKey.Name = "cbManaHotKey";
            this.cbManaHotKey.Size = new System.Drawing.Size(76, 21);
            this.cbManaHotKey.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // nupLifePercent
            // 
            this.nupLifePercent.Location = new System.Drawing.Point(141, 26);
            this.nupLifePercent.Name = "nupLifePercent";
            this.nupLifePercent.Size = new System.Drawing.Size(56, 20);
            this.nupLifePercent.TabIndex = 7;
            // 
            // nupManaPercent
            // 
            this.nupManaPercent.Location = new System.Drawing.Point(141, 84);
            this.nupManaPercent.Name = "nupManaPercent";
            this.nupManaPercent.Size = new System.Drawing.Size(56, 20);
            this.nupManaPercent.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Use at %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Use at %";
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(12, 177);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(190, 41);
            this.btnSaveConfig.TabIndex = 11;
            this.btnSaveConfig.Text = "Save Config";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 230);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nupManaPercent);
            this.Controls.Add(this.nupLifePercent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbManaHotKey);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLifeHotkey);
            this.Controls.Add(this.pcLife);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Capybara Bot";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcLife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupLifePercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupManaPercent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcLife;
        private System.Windows.Forms.ComboBox cbLifeHotkey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbManaHotKey;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nupLifePercent;
        private System.Windows.Forms.NumericUpDown nupManaPercent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveConfig;
    }
}

