using System;

namespace Ember
{
    partial class FormMain
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
            this.menuStripMainMenus = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBoxEditor = new System.Windows.Forms.RichTextBox();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMain = new System.Windows.Forms.SaveFileDialog();
            this.menuStripMainMenus.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMainMenus
            // 
            this.menuStripMainMenus.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripMainMenus.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripMainMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripMainMenus.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainMenus.Name = "menuStripMainMenus";
            this.menuStripMainMenus.Size = new System.Drawing.Size(1533, 33);
            this.menuStripMainMenus.TabIndex = 2;
            this.menuStripMainMenus.Text = "menuStripMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // richTextBoxEditor
            // 
            this.richTextBoxEditor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxEditor.Location = new System.Drawing.Point(0, 73);
            this.richTextBoxEditor.Name = "richTextBoxEditor";
            this.richTextBoxEditor.Size = new System.Drawing.Size(1533, 872);
            this.richTextBoxEditor.TabIndex = 3;
            this.richTextBoxEditor.Text = "";
            this.richTextBoxEditor.TextChanged += new System.EventHandler(this.richTextBoxEditor_TextChanged);
            // 
            // statusStripMain
            // 
            this.statusStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMain});
            this.statusStripMain.Location = new System.Drawing.Point(0, 41);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1533, 32);
            this.statusStripMain.TabIndex = 4;
            this.statusStripMain.Text = "statusStripMainStatus";
            // 
            // toolStripStatusLabelMain
            // 
            this.toolStripStatusLabelMain.Name = "toolStripStatusLabelMain";
            this.toolStripStatusLabelMain.Size = new System.Drawing.Size(208, 25);
            this.toolStripStatusLabelMain.Text = "toolStripStatusLabelMain";
            this.toolStripStatusLabelMain.Click += new System.EventHandler(this.toolStripStatusLabelMain_Click);
            // 
            // openFileDialogMain
            // 
            this.openFileDialogMain.FileName = "openFileDialogMain";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 945);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.richTextBoxEditor);
            this.Controls.Add(this.menuStripMainMenus);
            this.Name = "FormMain";
            this.Text = "Ember";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMainMenus.ResumeLayout(false);
            this.menuStripMainMenus.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void toolStripStatusLabelMain_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripMainMenus;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBoxEditor;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMain;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMain;
    }
}

