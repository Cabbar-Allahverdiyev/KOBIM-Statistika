
namespace Statistika.Forms
{
    partial class Dashbard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashbard));
            this.listBoxFacebook = new System.Windows.Forms.ListBox();
            this.buttonFacebookGetir = new System.Windows.Forms.Button();
            this.buttonFacebookYaz = new System.Windows.Forms.Button();
            this.groupBoxFacebook = new System.Windows.Forms.GroupBox();
            this.labelFacebook = new System.Windows.Forms.Label();
            this.groupBoxInstagram = new System.Windows.Forms.GroupBox();
            this.labelInstagram = new System.Windows.Forms.Label();
            this.listBoxInstagram = new System.Windows.Forms.ListBox();
            this.buttonInstagramGetir = new System.Windows.Forms.Button();
            this.labelFbSuccesIcon = new System.Windows.Forms.Label();
            this.labelInstaSuccessIcon = new System.Windows.Forms.Label();
            this.labelFbErrorIcon = new System.Windows.Forms.Label();
            this.labelInstaErrorIcon = new System.Windows.Forms.Label();
            this.groupBoxFacebook.SuspendLayout();
            this.groupBoxInstagram.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxFacebook
            // 
            this.listBoxFacebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.listBoxFacebook.FormattingEnabled = true;
            this.listBoxFacebook.ItemHeight = 15;
            this.listBoxFacebook.Location = new System.Drawing.Point(6, 51);
            this.listBoxFacebook.Name = "listBoxFacebook";
            this.listBoxFacebook.Size = new System.Drawing.Size(156, 229);
            this.listBoxFacebook.TabIndex = 0;
            // 
            // buttonFacebookGetir
            // 
            this.buttonFacebookGetir.Location = new System.Drawing.Point(87, 21);
            this.buttonFacebookGetir.Name = "buttonFacebookGetir";
            this.buttonFacebookGetir.Size = new System.Drawing.Size(75, 23);
            this.buttonFacebookGetir.TabIndex = 3;
            this.buttonFacebookGetir.Text = "Gətir";
            this.buttonFacebookGetir.UseVisualStyleBackColor = true;
            this.buttonFacebookGetir.Click += new System.EventHandler(this.buttonGetir_Click);
            // 
            // buttonFacebookYaz
            // 
            this.buttonFacebookYaz.Location = new System.Drawing.Point(273, 304);
            this.buttonFacebookYaz.Name = "buttonFacebookYaz";
            this.buttonFacebookYaz.Size = new System.Drawing.Size(75, 23);
            this.buttonFacebookYaz.TabIndex = 5;
            this.buttonFacebookYaz.Text = "Yaz";
            this.buttonFacebookYaz.UseVisualStyleBackColor = true;
            this.buttonFacebookYaz.Click += new System.EventHandler(this.buttonYaz_Click);
            // 
            // groupBoxFacebook
            // 
            this.groupBoxFacebook.Controls.Add(this.labelFbErrorIcon);
            this.groupBoxFacebook.Controls.Add(this.labelFbSuccesIcon);
            this.groupBoxFacebook.Controls.Add(this.labelFacebook);
            this.groupBoxFacebook.Controls.Add(this.listBoxFacebook);
            this.groupBoxFacebook.Controls.Add(this.buttonFacebookGetir);
            this.groupBoxFacebook.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFacebook.Name = "groupBoxFacebook";
            this.groupBoxFacebook.Size = new System.Drawing.Size(168, 286);
            this.groupBoxFacebook.TabIndex = 6;
            this.groupBoxFacebook.TabStop = false;
            this.groupBoxFacebook.Text = "Facebook";
            // 
            // labelFacebook
            // 
            this.labelFacebook.AutoSize = true;
            this.labelFacebook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFacebook.ForeColor = System.Drawing.Color.DarkRed;
            this.labelFacebook.Location = new System.Drawing.Point(6, 21);
            this.labelFacebook.Name = "labelFacebook";
            this.labelFacebook.Size = new System.Drawing.Size(19, 21);
            this.labelFacebook.TabIndex = 4;
            this.labelFacebook.Text = "0";
            // 
            // groupBoxInstagram
            // 
            this.groupBoxInstagram.Controls.Add(this.labelInstaErrorIcon);
            this.groupBoxInstagram.Controls.Add(this.labelInstaSuccessIcon);
            this.groupBoxInstagram.Controls.Add(this.labelInstagram);
            this.groupBoxInstagram.Controls.Add(this.listBoxInstagram);
            this.groupBoxInstagram.Controls.Add(this.buttonInstagramGetir);
            this.groupBoxInstagram.Location = new System.Drawing.Point(186, 12);
            this.groupBoxInstagram.Name = "groupBoxInstagram";
            this.groupBoxInstagram.Size = new System.Drawing.Size(168, 286);
            this.groupBoxInstagram.TabIndex = 7;
            this.groupBoxInstagram.TabStop = false;
            this.groupBoxInstagram.Text = "Instagram";
            // 
            // labelInstagram
            // 
            this.labelInstagram.AutoSize = true;
            this.labelInstagram.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInstagram.ForeColor = System.Drawing.Color.DarkRed;
            this.labelInstagram.Location = new System.Drawing.Point(6, 21);
            this.labelInstagram.Name = "labelInstagram";
            this.labelInstagram.Size = new System.Drawing.Size(19, 21);
            this.labelInstagram.TabIndex = 4;
            this.labelInstagram.Text = "0";
            this.labelInstagram.Click += new System.EventHandler(this.labelInstagram_Click);
            // 
            // listBoxInstagram
            // 
            this.listBoxInstagram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.listBoxInstagram.FormattingEnabled = true;
            this.listBoxInstagram.ItemHeight = 15;
            this.listBoxInstagram.Location = new System.Drawing.Point(6, 51);
            this.listBoxInstagram.Name = "listBoxInstagram";
            this.listBoxInstagram.Size = new System.Drawing.Size(156, 229);
            this.listBoxInstagram.TabIndex = 0;
            // 
            // buttonInstagramGetir
            // 
            this.buttonInstagramGetir.Location = new System.Drawing.Point(87, 22);
            this.buttonInstagramGetir.Name = "buttonInstagramGetir";
            this.buttonInstagramGetir.Size = new System.Drawing.Size(75, 23);
            this.buttonInstagramGetir.TabIndex = 3;
            this.buttonInstagramGetir.Text = "Gətir";
            this.buttonInstagramGetir.UseVisualStyleBackColor = true;
            this.buttonInstagramGetir.Click += new System.EventHandler(this.buttonInstagramGetir_Click);
            // 
            // labelFbSuccesIcon
            // 
            this.labelFbSuccesIcon.AutoSize = true;
            this.labelFbSuccesIcon.Image = ((System.Drawing.Image)(resources.GetObject("labelFbSuccesIcon.Image")));
            this.labelFbSuccesIcon.Location = new System.Drawing.Point(43, 25);
            this.labelFbSuccesIcon.Name = "labelFbSuccesIcon";
            this.labelFbSuccesIcon.Size = new System.Drawing.Size(16, 15);
            this.labelFbSuccesIcon.TabIndex = 5;
            this.labelFbSuccesIcon.Text = "   ";
            // 
            // labelInstaSuccessIcon
            // 
            this.labelInstaSuccessIcon.AutoSize = true;
            this.labelInstaSuccessIcon.Image = ((System.Drawing.Image)(resources.GetObject("labelInstaSuccessIcon.Image")));
            this.labelInstaSuccessIcon.Location = new System.Drawing.Point(43, 26);
            this.labelInstaSuccessIcon.Name = "labelInstaSuccessIcon";
            this.labelInstaSuccessIcon.Size = new System.Drawing.Size(16, 15);
            this.labelInstaSuccessIcon.TabIndex = 6;
            this.labelInstaSuccessIcon.Text = "   ";
            // 
            // labelFbErrorIcon
            // 
            this.labelFbErrorIcon.AutoSize = true;
            this.labelFbErrorIcon.Image = ((System.Drawing.Image)(resources.GetObject("labelFbErrorIcon.Image")));
            this.labelFbErrorIcon.Location = new System.Drawing.Point(43, 26);
            this.labelFbErrorIcon.Name = "labelFbErrorIcon";
            this.labelFbErrorIcon.Size = new System.Drawing.Size(16, 15);
            this.labelFbErrorIcon.TabIndex = 6;
            this.labelFbErrorIcon.Text = "   ";
            // 
            // labelInstaErrorIcon
            // 
            this.labelInstaErrorIcon.AutoSize = true;
            this.labelInstaErrorIcon.Image = ((System.Drawing.Image)(resources.GetObject("labelInstaErrorIcon.Image")));
            this.labelInstaErrorIcon.Location = new System.Drawing.Point(43, 26);
            this.labelInstaErrorIcon.Name = "labelInstaErrorIcon";
            this.labelInstaErrorIcon.Size = new System.Drawing.Size(16, 15);
            this.labelInstaErrorIcon.TabIndex = 7;
            this.labelInstaErrorIcon.Text = "   ";
            // 
            // Dashbard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(363, 345);
            this.Controls.Add(this.groupBoxInstagram);
            this.Controls.Add(this.buttonFacebookYaz);
            this.Controls.Add(this.groupBoxFacebook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashbard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Əsas Sahifə";
            this.Load += new System.EventHandler(this.Dashbard_Load);
            this.groupBoxFacebook.ResumeLayout(false);
            this.groupBoxFacebook.PerformLayout();
            this.groupBoxInstagram.ResumeLayout(false);
            this.groupBoxInstagram.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFacebook;
        private System.Windows.Forms.Button buttonFacebookGetir;
        private System.Windows.Forms.Button buttonFacebookYaz;
        private System.Windows.Forms.GroupBox groupBoxFacebook;
        private System.Windows.Forms.GroupBox groupBoxInstagram;
        private System.Windows.Forms.ListBox listBoxInstagram;
        private System.Windows.Forms.Button buttonInstagramGetir;
        private System.Windows.Forms.Label labelFacebook;
        private System.Windows.Forms.Label labelInstagram;
        private System.Windows.Forms.Label labelFbErrorIcon;
        private System.Windows.Forms.Label labelFbSuccesIcon;
        private System.Windows.Forms.Label labelInstaErrorIcon;
        private System.Windows.Forms.Label labelInstaSuccessIcon;
    }
}