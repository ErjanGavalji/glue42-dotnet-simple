namespace CompanyManager_WF
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbCompanies = new System.Windows.Forms.ListBox();
            this.lblCompanyDetails = new System.Windows.Forms.Label();
            this.txtCompanyDetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Companies";
            // 
            // lbCompanies
            // 
            this.lbCompanies.DisplayMember = "name";
            this.lbCompanies.FormattingEnabled = true;
            this.lbCompanies.Location = new System.Drawing.Point(60, 44);
            this.lbCompanies.Name = "lbCompanies";
            this.lbCompanies.Size = new System.Drawing.Size(133, 303);
            this.lbCompanies.TabIndex = 1;
            this.lbCompanies.SelectedIndexChanged += new System.EventHandler(this.lbCompanies_SelectedIndexChanged);
            // 
            // lblCompanyDetails
            // 
            this.lblCompanyDetails.AutoSize = true;
            this.lblCompanyDetails.Location = new System.Drawing.Point(327, 28);
            this.lblCompanyDetails.Name = "lblCompanyDetails";
            this.lblCompanyDetails.Size = new System.Drawing.Size(86, 13);
            this.lblCompanyDetails.TabIndex = 2;
            this.lblCompanyDetails.Text = "Company Details";
            // 
            // txtCompanyDetails
            // 
            this.txtCompanyDetails.Location = new System.Drawing.Point(330, 44);
            this.txtCompanyDetails.Multiline = true;
            this.txtCompanyDetails.Name = "txtCompanyDetails";
            this.txtCompanyDetails.Size = new System.Drawing.Size(264, 303);
            this.txtCompanyDetails.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCompanyDetails);
            this.Controls.Add(this.lblCompanyDetails);
            this.Controls.Add(this.lbCompanies);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbCompanies;
        private System.Windows.Forms.Label lblCompanyDetails;
        private System.Windows.Forms.TextBox txtCompanyDetails;
    }
}

