namespace HelloWorldNoah
{
    partial class frmHelloWorld
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
            this.lblSignature = new System.Windows.Forms.Label();
            this.picMagikarp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMagikarp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.BackColor = System.Drawing.Color.Transparent;
            this.lblGreeting.Font = new System.Drawing.Font("Vineta BT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.ForeColor = System.Drawing.Color.Crimson;
            this.lblGreeting.Location = new System.Drawing.Point(227, 35);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(692, 87);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Hello, World!";
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.Font = new System.Drawing.Font("Dutch801 XBd BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignature.Location = new System.Drawing.Point(493, 132);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(173, 39);
            this.lblSignature.TabIndex = 1;
            this.lblSignature.Text = "By Noah.C";
            // 
            // picMagikarp
            // 
            this.picMagikarp.Image = global::HelloWorldNoah.Properties.Resources.WeirdMagicarp;
            this.picMagikarp.Location = new System.Drawing.Point(304, 210);
            this.picMagikarp.Name = "picMagikarp";
            this.picMagikarp.Size = new System.Drawing.Size(517, 390);
            this.picMagikarp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMagikarp.TabIndex = 2;
            this.picMagikarp.TabStop = false;
            // 
            // frmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1120, 641);
            this.Controls.Add(this.picMagikarp);
            this.Controls.Add(this.lblSignature);
            this.Controls.Add(this.lblGreeting);
            this.Name = "frmHelloWorld";
            this.Text = "Hello, World! By Noah";
            this.Load += new System.EventHandler(this.FrmHelloWorld_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMagikarp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.PictureBox picMagikarp;
    }
}

