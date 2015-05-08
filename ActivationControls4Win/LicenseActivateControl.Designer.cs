﻿namespace ActivationControls4Win
{
    partial class LicenseActivateControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkCopy = new System.Windows.Forms.LinkLabel();
            this.lnkMailSN = new System.Windows.Forms.LinkLabel();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtLicense);
            this.groupBox2.Location = new System.Drawing.Point(3, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 269);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "许可证";
            // 
            // txtLicense
            // 
            this.txtLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLicense.Location = new System.Drawing.Point(7, 20);
            this.txtLicense.Multiline = true;
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLicense.Size = new System.Drawing.Size(381, 243);
            this.txtLicense.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lnkCopy);
            this.groupBox1.Controls.Add(this.lnkMailSN);
            this.groupBox1.Controls.Add(this.txtUID);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 90);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "许可证标识号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "请提供以下标识号给供应商以购买许可证";
            // 
            // lnkCopy
            // 
            this.lnkCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkCopy.AutoSize = true;
            this.lnkCopy.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkCopy.Location = new System.Drawing.Point(212, 64);
            this.lnkCopy.Name = "lnkCopy";
            this.lnkCopy.Size = new System.Drawing.Size(79, 13);
            this.lnkCopy.TabIndex = 2;
            this.lnkCopy.TabStop = true;
            this.lnkCopy.Text = "复制到剪贴板";
            this.lnkCopy.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // lnkMailSN
            // 
            this.lnkMailSN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkMailSN.AutoSize = true;
            this.lnkMailSN.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkMailSN.Location = new System.Drawing.Point(297, 64);
            this.lnkMailSN.Name = "lnkMailSN";
            this.lnkMailSN.Size = new System.Drawing.Size(91, 13);
            this.lnkMailSN.TabIndex = 3;
            this.lnkMailSN.TabStop = true;
            this.lnkMailSN.Text = "邮件发送序列号";
            this.lnkMailSN.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // txtUID
            // 
            this.txtUID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUID.Location = new System.Drawing.Point(7, 41);
            this.txtUID.Name = "txtUID";
            this.txtUID.ReadOnly = true;
            this.txtUID.Size = new System.Drawing.Size(381, 20);
            this.txtUID.TabIndex = 1;
            this.txtUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LicenseActivateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LicenseActivateControl";
            this.Size = new System.Drawing.Size(408, 371);
            this.Load += new System.EventHandler(this.LicenseActivateControl_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkCopy;
        private System.Windows.Forms.LinkLabel lnkMailSN;
        private System.Windows.Forms.TextBox txtUID;
    }
}
