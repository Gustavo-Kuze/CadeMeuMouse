namespace CadeMeuMouse.GUI
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.paneMainContainer = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearchCursorImg = new System.Windows.Forms.Button();
            this.txtCursorImgPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkOpenAtStartup = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.nudEndSize = new System.Windows.Forms.NumericUpDown();
            this.nudStartSize = new System.Windows.Forms.NumericUpDown();
            this.nudEnabledTime = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nudScanningInterval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoSensitivityNormal = new System.Windows.Forms.RadioButton();
            this.rdoSensitivityVeryStrong = new System.Windows.Forms.RadioButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.paneMainContainer.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnabledTime)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScanningInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // paneMainContainer
            // 
            resources.ApplyResources(this.paneMainContainer, "paneMainContainer");
            this.paneMainContainer.Controls.Add(this.panel5);
            this.paneMainContainer.Controls.Add(this.panel3);
            this.paneMainContainer.Controls.Add(this.panel2);
            this.paneMainContainer.Controls.Add(this.panel10);
            this.paneMainContainer.Controls.Add(this.panel7);
            this.paneMainContainer.Controls.Add(this.panel8);
            this.paneMainContainer.Name = "paneMainContainer";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.btnSearchCursorImg);
            this.panel5.Controls.Add(this.txtCursorImgPath);
            this.panel5.Controls.Add(this.label4);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // panel6
            // 
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.panel6.Controls.Add(this.label7);
            this.panel6.Name = "panel6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label7.Name = "label7";
            // 
            // btnSearchCursorImg
            // 
            resources.ApplyResources(this.btnSearchCursorImg, "btnSearchCursorImg");
            this.btnSearchCursorImg.Name = "btnSearchCursorImg";
            this.btnSearchCursorImg.UseVisualStyleBackColor = true;
            this.btnSearchCursorImg.Click += new System.EventHandler(this.btnSearchCursorImg_Click);
            // 
            // txtCursorImgPath
            // 
            resources.ApplyResources(this.txtCursorImgPath, "txtCursorImgPath");
            this.txtCursorImgPath.Name = "txtCursorImgPath";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.chkOpenAtStartup);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.nudEndSize);
            this.panel3.Controls.Add(this.nudStartSize);
            this.panel3.Controls.Add(this.nudEnabledTime);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label5);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // chkOpenAtStartup
            // 
            resources.ApplyResources(this.chkOpenAtStartup, "chkOpenAtStartup");
            this.chkOpenAtStartup.Checked = true;
            this.chkOpenAtStartup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOpenAtStartup.Name = "chkOpenAtStartup";
            this.chkOpenAtStartup.UseVisualStyleBackColor = true;
            this.chkOpenAtStartup.Click += new System.EventHandler(this.chkOpenAtStartup_Click);
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.panel4.Controls.Add(this.label6);
            this.panel4.Name = "panel4";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label6.Name = "label6";
            // 
            // nudEndSize
            // 
            resources.ApplyResources(this.nudEndSize, "nudEndSize");
            this.nudEndSize.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nudEndSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEndSize.Name = "nudEndSize";
            this.nudEndSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudStartSize
            // 
            resources.ApplyResources(this.nudStartSize, "nudStartSize");
            this.nudStartSize.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nudStartSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStartSize.Name = "nudStartSize";
            this.nudStartSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudEnabledTime
            // 
            resources.ApplyResources(this.nudEnabledTime, "nudEnabledTime");
            this.nudEnabledTime.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudEnabledTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEnabledTime.Name = "nudEnabledTime";
            this.nudEnabledTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.nudScanningInterval);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.rdoSensitivityNormal);
            this.panel2.Controls.Add(this.rdoSensitivityVeryStrong);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label1.Name = "label1";
            // 
            // nudScanningInterval
            // 
            resources.ApplyResources(this.nudScanningInterval, "nudScanningInterval");
            this.nudScanningInterval.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudScanningInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudScanningInterval.Name = "nudScanningInterval";
            this.nudScanningInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // rdoSensitivityNormal
            // 
            resources.ApplyResources(this.rdoSensitivityNormal, "rdoSensitivityNormal");
            this.rdoSensitivityNormal.Checked = true;
            this.rdoSensitivityNormal.Name = "rdoSensitivityNormal";
            this.rdoSensitivityNormal.TabStop = true;
            this.rdoSensitivityNormal.UseVisualStyleBackColor = true;
            // 
            // rdoSensitivityVeryStrong
            // 
            resources.ApplyResources(this.rdoSensitivityVeryStrong, "rdoSensitivityVeryStrong");
            this.rdoSensitivityVeryStrong.Name = "rdoSensitivityVeryStrong";
            this.rdoSensitivityVeryStrong.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.panel10, "panel10");
            this.panel10.Name = "panel10";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // FrmSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.paneMainContainer);
            this.Name = "FrmSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSettings_FormClosing);
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.paneMainContainer.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnabledTime)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScanningInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneMainContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoSensitivityNormal;
        private System.Windows.Forms.RadioButton rdoSensitivityVeryStrong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudScanningInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown nudEnabledTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSearchCursorImg;
        private System.Windows.Forms.TextBox txtCursorImgPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudEndSize;
        private System.Windows.Forms.NumericUpDown nudStartSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.CheckBox chkOpenAtStartup;
    }
}