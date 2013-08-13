namespace SkypeFx
{
    partial class SettingsForm
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
            this.LogPathTxt = new System.Windows.Forms.TextBox();
            this.LogPathLbl = new System.Windows.Forms.Label();
            this.SaveSettingsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogPathTxt
            // 
            this.LogPathTxt.Location = new System.Drawing.Point(71, 23);
            this.LogPathTxt.Name = "LogPathTxt";
            this.LogPathTxt.Size = new System.Drawing.Size(127, 20);
            this.LogPathTxt.TabIndex = 0;
            // 
            // LogPathLbl
            // 
            this.LogPathLbl.AutoSize = true;
            this.LogPathLbl.Location = new System.Drawing.Point(12, 26);
            this.LogPathLbl.Name = "LogPathLbl";
            this.LogPathLbl.Size = new System.Drawing.Size(53, 13);
            this.LogPathLbl.TabIndex = 1;
            this.LogPathLbl.Text = "Log Path:";
            // 
            // SaveSettingsBtn
            // 
            this.SaveSettingsBtn.Location = new System.Drawing.Point(338, 20);
            this.SaveSettingsBtn.Name = "SaveSettingsBtn";
            this.SaveSettingsBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveSettingsBtn.TabIndex = 2;
            this.SaveSettingsBtn.Text = "Save";
            this.SaveSettingsBtn.UseVisualStyleBackColor = true;
            this.SaveSettingsBtn.Click += new System.EventHandler(this.SaveSettingsBtn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 264);
            this.Controls.Add(this.SaveSettingsBtn);
            this.Controls.Add(this.LogPathLbl);
            this.Controls.Add(this.LogPathTxt);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LogPathTxt;
        private System.Windows.Forms.Label LogPathLbl;
        private System.Windows.Forms.Button SaveSettingsBtn;
    }
}