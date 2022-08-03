namespace WindowsFormsApp1
{
    partial class Güncelle
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
            this.güncellemskbirth = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.güncellemskphone = new System.Windows.Forms.MaskedTextBox();
            this.güncelleEposta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.güncelleName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.cbstudents = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // güncellemskbirth
            // 
            this.güncellemskbirth.Location = new System.Drawing.Point(116, 115);
            this.güncellemskbirth.Mask = "00/00/0000";
            this.güncellemskbirth.Name = "güncellemskbirth";
            this.güncellemskbirth.Size = new System.Drawing.Size(152, 22);
            this.güncellemskbirth.TabIndex = 15;
            this.güncellemskbirth.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Doğum Tarihi";
            // 
            // güncellemskphone
            // 
            this.güncellemskphone.Location = new System.Drawing.Point(116, 87);
            this.güncellemskphone.Mask = "(999) 000-0000";
            this.güncellemskphone.Name = "güncellemskphone";
            this.güncellemskphone.Size = new System.Drawing.Size(152, 22);
            this.güncellemskphone.TabIndex = 13;
            // 
            // güncelleEposta
            // 
            this.güncelleEposta.Location = new System.Drawing.Point(116, 59);
            this.güncelleEposta.Name = "güncelleEposta";
            this.güncelleEposta.Size = new System.Drawing.Size(152, 22);
            this.güncelleEposta.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Telefon No";
            // 
            // güncelleName
            // 
            this.güncelleName.Location = new System.Drawing.Point(116, 31);
            this.güncelleName.Name = "güncelleName";
            this.güncelleName.Size = new System.Drawing.Size(152, 22);
            this.güncelleName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "E posta";
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnupdate.Location = new System.Drawing.Point(20, 191);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(121, 47);
            this.btnupdate.TabIndex = 17;
            this.btnupdate.Text = "Güncelle";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.cbstudents);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.güncelleName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.güncellemskbirth);
            this.groupBox1.Controls.Add(this.güncelleEposta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.güncellemskphone);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 259);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenciler";
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndelete.Location = new System.Drawing.Point(147, 191);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(129, 47);
            this.btndelete.TabIndex = 19;
            this.btndelete.Text = "Sil";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // cbstudents
            // 
            this.cbstudents.FormattingEnabled = true;
            this.cbstudents.Location = new System.Drawing.Point(116, 1);
            this.cbstudents.Name = "cbstudents";
            this.cbstudents.Size = new System.Drawing.Size(152, 24);
            this.cbstudents.TabIndex = 18;
            this.cbstudents.SelectedIndexChanged += new System.EventHandler(this.cbstudents_SelectedIndexChanged);
            // 
            // Güncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Güncelle";
            this.Text = "Güncelle";
            this.Load += new System.EventHandler(this.Güncelle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox güncellemskbirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox güncellemskphone;
        private System.Windows.Forms.TextBox güncelleEposta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox güncelleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbstudents;
        private System.Windows.Forms.Button btndelete;
    }
}