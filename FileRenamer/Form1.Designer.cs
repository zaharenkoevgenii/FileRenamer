using System;
using System.IO;

namespace FileRenamer
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
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.rbNumeric = new System.Windows.Forms.RadioButton();
            this.rbDate = new System.Windows.Forms.RadioButton();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.rbGuid = new System.Windows.Forms.RadioButton();
            this.btRename = new System.Windows.Forms.Button();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(13, 21);
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(257, 20);
            this.tbPath.TabIndex = 0;
            this.tbPath.Text = "C:\\Users\\zahar\\Desktop";
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(276, 19);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(75, 23);
            this.btBrowse.TabIndex = 1;
            this.btBrowse.Text = "Browse";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // rbNumeric
            // 
            this.rbNumeric.AutoSize = true;
            this.rbNumeric.Location = new System.Drawing.Point(13, 66);
            this.rbNumeric.Name = "rbNumeric";
            this.rbNumeric.Size = new System.Drawing.Size(62, 17);
            this.rbNumeric.TabIndex = 2;
            this.rbNumeric.Text = "numeric";
            this.rbNumeric.UseVisualStyleBackColor = true;
            // 
            // rbDate
            // 
            this.rbDate.AutoSize = true;
            this.rbDate.Location = new System.Drawing.Point(81, 66);
            this.rbDate.Name = "rbDate";
            this.rbDate.Size = new System.Drawing.Size(46, 17);
            this.rbDate.TabIndex = 3;
            this.rbDate.Text = "date";
            this.rbDate.UseVisualStyleBackColor = true;
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Checked = true;
            this.rbRandom.Location = new System.Drawing.Point(133, 66);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(60, 17);
            this.rbRandom.TabIndex = 4;
            this.rbRandom.TabStop = true;
            this.rbRandom.Text = "random";
            this.rbRandom.UseVisualStyleBackColor = true;
            // 
            // rbGuid
            // 
            this.rbGuid.AutoSize = true;
            this.rbGuid.Location = new System.Drawing.Point(199, 66);
            this.rbGuid.Name = "rbGuid";
            this.rbGuid.Size = new System.Drawing.Size(45, 17);
            this.rbGuid.TabIndex = 5;
            this.rbGuid.Text = "guid";
            this.rbGuid.UseVisualStyleBackColor = true;
            // 
            // btRename
            // 
            this.btRename.Location = new System.Drawing.Point(276, 63);
            this.btRename.Name = "btRename";
            this.btRename.Size = new System.Drawing.Size(75, 23);
            this.btRename.TabIndex = 6;
            this.btRename.Text = "Rename";
            this.btRename.UseVisualStyleBackColor = true;
            this.btRename.Click += new System.EventHandler(this.btRename_Click);
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(13, 21);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(257, 20);
            this.pbProgress.TabIndex = 7;
            this.pbProgress.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 104);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.btRename);
            this.Controls.Add(this.rbGuid);
            this.Controls.Add(this.rbRandom);
            this.Controls.Add(this.rbDate);
            this.Controls.Add(this.rbNumeric);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.tbPath);
            this.Name = "Form1";
            this.Text = "File Renamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.RadioButton rbNumeric;
        private System.Windows.Forms.RadioButton rbDate;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.RadioButton rbGuid;
        private System.Windows.Forms.Button btRename;
        private System.Windows.Forms.ProgressBar pbProgress;
    }
}

