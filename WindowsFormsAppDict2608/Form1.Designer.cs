namespace WindowsFormsAppDict2608
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
            this.cbGetallen = new System.Windows.Forms.ComboBox();
            this.lblCijfer = new System.Windows.Forms.Label();
            this.lblVoluit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbGetallen
            // 
            this.cbGetallen.FormattingEnabled = true;
            this.cbGetallen.Location = new System.Drawing.Point(52, 28);
            this.cbGetallen.Name = "cbGetallen";
            this.cbGetallen.Size = new System.Drawing.Size(121, 21);
            this.cbGetallen.TabIndex = 0;
            this.cbGetallen.SelectedIndexChanged += new System.EventHandler(this.cbGetallen_SelectedIndexChanged);
            // 
            // lblCijfer
            // 
            this.lblCijfer.AutoSize = true;
            this.lblCijfer.Location = new System.Drawing.Point(52, 154);
            this.lblCijfer.Name = "lblCijfer";
            this.lblCijfer.Size = new System.Drawing.Size(30, 13);
            this.lblCijfer.TabIndex = 1;
            this.lblCijfer.Text = "Cijfer";
            // 
            // lblVoluit
            // 
            this.lblVoluit.AutoSize = true;
            this.lblVoluit.Location = new System.Drawing.Point(138, 154);
            this.lblVoluit.Name = "lblVoluit";
            this.lblVoluit.Size = new System.Drawing.Size(41, 13);
            this.lblVoluit.TabIndex = 2;
            this.lblVoluit.Text = "Notatie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 202);
            this.Controls.Add(this.lblVoluit);
            this.Controls.Add(this.lblCijfer);
            this.Controls.Add(this.cbGetallen);
            this.Name = "Form1";
            this.Text = "Oefening 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGetallen;
        private System.Windows.Forms.Label lblCijfer;
        private System.Windows.Forms.Label lblVoluit;
    }
}

