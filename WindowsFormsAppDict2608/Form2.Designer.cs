namespace WindowsFormsAppDict2608
{
    partial class Form2
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
            this.cbVertaling = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVertaling = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblTeVertalen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbVertaling
            // 
            this.cbVertaling.FormattingEnabled = true;
            this.cbVertaling.Location = new System.Drawing.Point(45, 39);
            this.cbVertaling.Name = "cbVertaling";
            this.cbVertaling.Size = new System.Drawing.Size(201, 21);
            this.cbVertaling.TabIndex = 0;
            this.cbVertaling.SelectedIndexChanged += new System.EventHandler(this.cbVertaling_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vertaling:";
            // 
            // lblVertaling
            // 
            this.lblVertaling.AutoSize = true;
            this.lblVertaling.Location = new System.Drawing.Point(154, 204);
            this.lblVertaling.Name = "lblVertaling";
            this.lblVertaling.Size = new System.Drawing.Size(0, 13);
            this.lblVertaling.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(45, 254);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(201, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Geef Nieuw Woord In";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(45, 300);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(201, 28);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Verwijder Woord";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblTeVertalen
            // 
            this.lblTeVertalen.AutoSize = true;
            this.lblTeVertalen.Location = new System.Drawing.Point(155, 177);
            this.lblTeVertalen.Name = "lblTeVertalen";
            this.lblTeVertalen.Size = new System.Drawing.Size(16, 13);
            this.lblTeVertalen.TabIndex = 5;
            this.lblTeVertalen.Text = "---";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 402);
            this.Controls.Add(this.lblTeVertalen);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblVertaling);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVertaling);
            this.Name = "Form2";
            this.Text = "Oefening 2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbVertaling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVertaling;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblTeVertalen;
    }
}