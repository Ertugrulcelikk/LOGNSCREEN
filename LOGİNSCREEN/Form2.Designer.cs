namespace LOGİNSCREEN
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
            this.lblsonuç = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblsonuç
            // 
            this.lblsonuç.AutoSize = true;
            this.lblsonuç.Location = new System.Drawing.Point(313, 111);
            this.lblsonuç.MaximumSize = new System.Drawing.Size(75, 75);
            this.lblsonuç.Name = "lblsonuç";
            this.lblsonuç.Size = new System.Drawing.Size(44, 16);
            this.lblsonuç.TabIndex = 0;
            this.lblsonuç.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblsonuç);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsonuç;
    }
}