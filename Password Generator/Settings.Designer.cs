namespace Password_Generator
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordLen = new System.Windows.Forms.NumericUpDown();
            this.Symbols = new System.Windows.Forms.CheckBox();
            this.Numbers = new System.Windows.Forms.CheckBox();
            this.Upload = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Include Symbols";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Include Numbers";
            // 
            // PasswordLen
            // 
            this.PasswordLen.Location = new System.Drawing.Point(126, 18);
            this.PasswordLen.Name = "PasswordLen";
            this.PasswordLen.Size = new System.Drawing.Size(72, 23);
            this.PasswordLen.TabIndex = 3;
            this.PasswordLen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordLen.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Symbols
            // 
            this.Symbols.AutoSize = true;
            this.Symbols.Checked = true;
            this.Symbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Symbols.Location = new System.Drawing.Point(148, 51);
            this.Symbols.Name = "Symbols";
            this.Symbols.Size = new System.Drawing.Size(15, 14);
            this.Symbols.TabIndex = 4;
            this.Symbols.UseVisualStyleBackColor = true;
            // 
            // Numbers
            // 
            this.Numbers.AutoSize = true;
            this.Numbers.Checked = true;
            this.Numbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Numbers.Location = new System.Drawing.Point(148, 76);
            this.Numbers.Name = "Numbers";
            this.Numbers.Size = new System.Drawing.Size(15, 14);
            this.Numbers.TabIndex = 5;
            this.Numbers.UseVisualStyleBackColor = true;
            // 
            // Upload
            // 
            this.Upload.AutoSize = true;
            this.Upload.Checked = true;
            this.Upload.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Upload.Location = new System.Drawing.Point(148, 100);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(15, 14);
            this.Upload.TabIndex = 7;
            this.Upload.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Upload Password";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 143);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Numbers);
            this.Controls.Add(this.Symbols);
            this.Controls.Add(this.PasswordLen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(227, 182);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(227, 182);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        public NumericUpDown PasswordLen;
        public CheckBox Symbols;
        public CheckBox Numbers;
        public CheckBox Upload;
        private Label label4;
    }
}