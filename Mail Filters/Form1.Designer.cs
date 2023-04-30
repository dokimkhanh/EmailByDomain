namespace Mail_Filters
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelResults = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rInclude = new System.Windows.Forms.RadioButton();
            this.rExcept = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.menuList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.clearItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuResult = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuList.SuspendLayout();
            this.menuResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mail List";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.SystemColors.Control;
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMail.Location = new System.Drawing.Point(3, 16);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(298, 186);
            this.txtMail.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Filter";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "@gmail.com",
            "@hotmail.com",
            "@yahoo.com",
            "<Custom...>"});
            this.comboBox1.Location = new System.Drawing.Point(111, 541);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtResults);
            this.groupBox2.Location = new System.Drawing.Point(16, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 205);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // txtResults
            // 
            this.txtResults.BackColor = System.Drawing.SystemColors.Control;
            this.txtResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResults.Location = new System.Drawing.Point(3, 16);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(298, 186);
            this.txtResults.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 544);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Domain:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 43);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(292, 23);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelResults);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.labelTotal);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Location = new System.Drawing.Point(16, 434);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 77);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelResults.Location = new System.Drawing.Point(174, 19);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(13, 13);
            this.labelResults.TabIndex = 10;
            this.labelResults.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Results:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(49, 19);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(13, 13);
            this.labelTotal.TabIndex = 8;
            this.labelTotal.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total: ";
            // 
            // rInclude
            // 
            this.rInclude.AutoSize = true;
            this.rInclude.Checked = true;
            this.rInclude.Location = new System.Drawing.Point(111, 518);
            this.rInclude.Name = "rInclude";
            this.rInclude.Size = new System.Drawing.Size(60, 17);
            this.rInclude.TabIndex = 8;
            this.rInclude.TabStop = true;
            this.rInclude.Text = "Include";
            this.rInclude.UseVisualStyleBackColor = true;
            // 
            // rExcept
            // 
            this.rExcept.AutoSize = true;
            this.rExcept.Location = new System.Drawing.Point(177, 518);
            this.rExcept.Name = "rExcept";
            this.rExcept.Size = new System.Drawing.Size(58, 17);
            this.rExcept.TabIndex = 8;
            this.rExcept.Text = "Except";
            this.rExcept.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mode:";
            // 
            // menuList
            // 
            this.menuList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openItemMenu,
            this.clearItemMenu});
            this.menuList.Name = "menuList";
            this.menuList.Size = new System.Drawing.Size(104, 48);
            // 
            // openItemMenu
            // 
            this.openItemMenu.Name = "openItemMenu";
            this.openItemMenu.Size = new System.Drawing.Size(103, 22);
            this.openItemMenu.Text = "Open";
            this.openItemMenu.Click += new System.EventHandler(this.openItemMenu_Click);
            // 
            // clearItemMenu
            // 
            this.clearItemMenu.Name = "clearItemMenu";
            this.clearItemMenu.Size = new System.Drawing.Size(103, 22);
            this.clearItemMenu.Text = "Clear";
            this.clearItemMenu.Click += new System.EventHandler(this.clearItemMenu_Click);
            // 
            // menuResult
            // 
            this.menuResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuResult.Name = "menuResult";
            this.menuResult.Size = new System.Drawing.Size(102, 48);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 624);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rExcept);
            this.Controls.Add(this.rInclude);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmailByDomain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuList.ResumeLayout(false);
            this.menuResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rInclude;
        private System.Windows.Forms.RadioButton rExcept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip menuList;
        private System.Windows.Forms.ToolStripMenuItem openItemMenu;
        private System.Windows.Forms.ToolStripMenuItem clearItemMenu;
        private System.Windows.Forms.ContextMenuStrip menuResult;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}

