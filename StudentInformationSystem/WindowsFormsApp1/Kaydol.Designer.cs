namespace WindowsFormsApp1
{
    partial class kaydol
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
            this.lblkaydol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblkaydol
            // 
            this.lblkaydol.AutoSize = true;
            this.lblkaydol.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblkaydol.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkaydol.ForeColor = System.Drawing.Color.Purple;
            this.lblkaydol.Location = new System.Drawing.Point(118, 158);
            this.lblkaydol.Name = "lblkaydol";
            this.lblkaydol.Size = new System.Drawing.Size(499, 91);
            this.lblkaydol.TabIndex = 1;
            this.lblkaydol.Text = "Hoş Geldiniz";
            // 
            // kaydol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblkaydol);
            this.Name = "kaydol";
            this.Text = "kaydol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblkaydol;
    }
}