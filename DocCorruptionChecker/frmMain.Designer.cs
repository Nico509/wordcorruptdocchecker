﻿namespace DocCorruptionChecker
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbxFileName = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnFixDocument = new System.Windows.Forms.Button();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "File path:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "\".docx\"";
            this.openFileDialog1.Filter = "\"Word Open XML Documents | *.docx; *.dotx; *.docm; *.dotm\"";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Select Word Document To Fix";
            // 
            // tbxFileName
            // 
            this.tbxFileName.Location = new System.Drawing.Point(98, 9);
            this.tbxFileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxFileName.Name = "tbxFileName";
            this.tbxFileName.Size = new System.Drawing.Size(782, 26);
            this.tbxFileName.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowse.Location = new System.Drawing.Point(891, 6);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(66, 33);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // btnFixDocument
            // 
            this.btnFixDocument.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFixDocument.Location = new System.Drawing.Point(966, 6);
            this.btnFixDocument.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFixDocument.Name = "btnFixDocument";
            this.btnFixDocument.Size = new System.Drawing.Size(129, 33);
            this.btnFixDocument.TabIndex = 3;
            this.btnFixDocument.Text = "Fix Document";
            this.btnFixDocument.UseVisualStyleBackColor = true;
            this.btnFixDocument.Click += new System.EventHandler(this.BtnFixDocument_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.HorizontalScrollbar = true;
            this.lstOutput.ItemHeight = 20;
            this.lstOutput.Location = new System.Drawing.Point(22, 46);
            this.lstOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(1070, 524);
            this.lstOutput.TabIndex = 4;
            // 
            // btnCopy
            // 
            this.btnCopy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCopy.Location = new System.Drawing.Point(930, 583);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(165, 38);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "Copy Error Details";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.Location = new System.Drawing.Point(810, 581);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(110, 38);
            this.BtnSettings.TabIndex = 9;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1110, 636);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnFixDocument);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbxFileName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Corrupt Word Document Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbxFileName;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnFixDocument;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button BtnSettings;
    }
}

