
namespace KobimStatistika.Forms
{
    partial class Dashboard
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
            this.buttonGetir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUri = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonGetir
            // 
            this.buttonGetir.Location = new System.Drawing.Point(268, 25);
            this.buttonGetir.Name = "buttonGetir";
            this.buttonGetir.Size = new System.Drawing.Size(75, 23);
            this.buttonGetir.TabIndex = 0;
            this.buttonGetir.Text = "Getir";
            this.buttonGetir.UseVisualStyleBackColor = true;
            this.buttonGetir.Click += new System.EventHandler(this.buttonGetir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "adres";
            // 
            // textBoxUri
            // 
            this.textBoxUri.Location = new System.Drawing.Point(77, 27);
            this.textBoxUri.Name = "textBoxUri";
            this.textBoxUri.Size = new System.Drawing.Size(154, 20);
            this.textBoxUri.TabIndex = 2;
            this.textBoxUri.Text = "https://www.instagram.com/kobimucar/";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(328, 225);
            this.listBox1.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxUri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGetir);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUri;
        private System.Windows.Forms.ListBox listBox1;
    }
}