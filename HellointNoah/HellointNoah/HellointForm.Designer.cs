namespace HellointNoah
{
    partial class frmHelloint
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.grbButtons = new System.Windows.Forms.GroupBox();
            this.radJapanese = new System.Windows.Forms.RadioButton();
            this.radRussian = new System.Windows.Forms.RadioButton();
            this.radSwedish = new System.Windows.Forms.RadioButton();
            this.radEnglish = new System.Windows.Forms.RadioButton();
            this.grbButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Lucida Sans", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(183, 119);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(431, 75);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello, World!";
            this.lblGreeting.Click += new System.EventHandler(this.LblGreeting_Click);
            // 
            // grbButtons
            // 
            this.grbButtons.Controls.Add(this.radJapanese);
            this.grbButtons.Controls.Add(this.radRussian);
            this.grbButtons.Controls.Add(this.radSwedish);
            this.grbButtons.Controls.Add(this.radEnglish);
            this.grbButtons.Location = new System.Drawing.Point(113, 256);
            this.grbButtons.Name = "grbButtons";
            this.grbButtons.Size = new System.Drawing.Size(555, 130);
            this.grbButtons.TabIndex = 1;
            this.grbButtons.TabStop = false;
            this.grbButtons.Text = "Language Select";
            this.grbButtons.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // radJapanese
            // 
            this.radJapanese.AutoSize = true;
            this.radJapanese.Location = new System.Drawing.Point(431, 70);
            this.radJapanese.Name = "radJapanese";
            this.radJapanese.Size = new System.Drawing.Size(61, 17);
            this.radJapanese.TabIndex = 3;
            this.radJapanese.TabStop = true;
            this.radJapanese.Text = "日本人";
            this.radJapanese.UseVisualStyleBackColor = true;
            this.radJapanese.CheckedChanged += new System.EventHandler(this.RadJapanese_CheckedChanged);
            // 
            // radRussian
            // 
            this.radRussian.AutoSize = true;
            this.radRussian.Location = new System.Drawing.Point(297, 70);
            this.radRussian.Name = "radRussian";
            this.radRussian.Size = new System.Drawing.Size(67, 17);
            this.radRussian.TabIndex = 2;
            this.radRussian.TabStop = true;
            this.radRussian.Text = "Pусский";
            this.radRussian.UseVisualStyleBackColor = true;
            this.radRussian.CheckedChanged += new System.EventHandler(this.RadRussian_CheckedChanged);
            // 
            // radSwedish
            // 
            this.radSwedish.AutoSize = true;
            this.radSwedish.Location = new System.Drawing.Point(146, 70);
            this.radSwedish.Name = "radSwedish";
            this.radSwedish.Size = new System.Drawing.Size(67, 17);
            this.radSwedish.TabIndex = 1;
            this.radSwedish.TabStop = true;
            this.radSwedish.Text = "Svenska";
            this.radSwedish.UseVisualStyleBackColor = true;
            this.radSwedish.CheckedChanged += new System.EventHandler(this.RadSwedish_CheckedChanged);
            // 
            // radEnglish
            // 
            this.radEnglish.AutoSize = true;
            this.radEnglish.Location = new System.Drawing.Point(36, 70);
            this.radEnglish.Name = "radEnglish";
            this.radEnglish.Size = new System.Drawing.Size(59, 17);
            this.radEnglish.TabIndex = 0;
            this.radEnglish.TabStop = true;
            this.radEnglish.Text = "English";
            this.radEnglish.UseVisualStyleBackColor = true;
            this.radEnglish.CheckedChanged += new System.EventHandler(this.RadEnglish_CheckedChanged);
            // 
            // frmHelloint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbButtons);
            this.Controls.Add(this.lblGreeting);
            this.Name = "frmHelloint";
            this.Text = "Hello, World! International by Noah.C";
            this.grbButtons.ResumeLayout(false);
            this.grbButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.GroupBox grbButtons;
        private System.Windows.Forms.RadioButton radJapanese;
        private System.Windows.Forms.RadioButton radRussian;
        private System.Windows.Forms.RadioButton radSwedish;
        private System.Windows.Forms.RadioButton radEnglish;
    }
}

