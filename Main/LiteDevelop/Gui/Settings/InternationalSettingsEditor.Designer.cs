﻿namespace LiteDevelop.Gui.Settings
{
    partial class InternationalSettingsEditor
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
            System.Windows.Forms.Label applicationLanguageLabel;
            System.Windows.Forms.Label label2;
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            applicationLanguageLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // applicationLanguageLabel
            // 
            applicationLanguageLabel.AutoSize = true;
            applicationLanguageLabel.Location = new System.Drawing.Point(9, 11);
            applicationLanguageLabel.Name = "applicationLanguageLabel";
            applicationLanguageLabel.Size = new System.Drawing.Size(113, 13);
            applicationLanguageLabel.TabIndex = 0;
            applicationLanguageLabel.Text = "Application Language:";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoEllipsis = true;
            label2.Location = new System.Drawing.Point(12, 72);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(144, 100);
            label2.TabIndex = 2;
            label2.Text = "Some parts or extensions of LiteDevelop might not have the selected language impl" +
    "emented or installed. In this case the default language will be used.";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // InternationalSettingsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(applicationLanguageLabel);
            this.Name = "InternationalSettingsEditor";
            this.Size = new System.Drawing.Size(168, 182);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
    }
}
