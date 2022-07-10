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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMailListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.telegramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Location = new System.Drawing.Point(13, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mail List";
            // 
            // button1
            // 
            this.button1.Image = global::Mail_Filters.Properties.Resources.selling_strategy_document_16px;
            this.button1.Location = new System.Drawing.Point(64, 283);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(210, 34);
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
            this.comboBox1.Location = new System.Drawing.Point(64, 256);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtResults);
            this.groupBox2.Location = new System.Drawing.Point(323, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 205);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Domain:";
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.contactToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(643, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMailListToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveResultsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openMailListToolStripMenuItem
            // 
            this.openMailListToolStripMenuItem.Image = global::Mail_Filters.Properties.Resources.file_16px;
            this.openMailListToolStripMenuItem.Name = "openMailListToolStripMenuItem";
            this.openMailListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openMailListToolStripMenuItem.Text = "Open List";
            this.openMailListToolStripMenuItem.Click += new System.EventHandler(this.openMailListToolStripMenuItem_Click);
            // 
            // saveResultsToolStripMenuItem
            // 
            this.saveResultsToolStripMenuItem.Image = global::Mail_Filters.Properties.Resources.open_file_under_cursor_16px;
            this.saveResultsToolStripMenuItem.Name = "saveResultsToolStripMenuItem";
            this.saveResultsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveResultsToolStripMenuItem.Text = "Save Results";
            this.saveResultsToolStripMenuItem.Click += new System.EventHandler(this.saveResultsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearListToolStripMenuItem,
            this.toolStripSeparator2,
            this.clearResultsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearListToolStripMenuItem
            // 
            this.clearListToolStripMenuItem.Image = global::Mail_Filters.Properties.Resources.delete_16px;
            this.clearListToolStripMenuItem.Name = "clearListToolStripMenuItem";
            this.clearListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearListToolStripMenuItem.Text = "Clear List";
            this.clearListToolStripMenuItem.Click += new System.EventHandler(this.clearListToolStripMenuItem_Click);
            // 
            // clearResultsToolStripMenuItem
            // 
            this.clearResultsToolStripMenuItem.Image = global::Mail_Filters.Properties.Resources.multiply_16px;
            this.clearResultsToolStripMenuItem.Name = "clearResultsToolStripMenuItem";
            this.clearResultsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearResultsToolStripMenuItem.Text = "Clear Results";
            this.clearResultsToolStripMenuItem.Click += new System.EventHandler(this.clearResultsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
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
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telegramToolStripMenuItem,
            this.homepageToolStripMenuItem});
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.contactToolStripMenuItem.Text = "Contact";
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
            this.groupBox3.Location = new System.Drawing.Point(323, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 77);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
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
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(49, 19);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(13, 13);
            this.labelTotal.TabIndex = 8;
            this.labelTotal.Text = "0";
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
            // telegramToolStripMenuItem
            // 
            this.telegramToolStripMenuItem.Image = global::Mail_Filters.Properties.Resources.telegram_app_16px;
            this.telegramToolStripMenuItem.Name = "telegramToolStripMenuItem";
            this.telegramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.telegramToolStripMenuItem.Text = "Telegram";
            this.telegramToolStripMenuItem.Click += new System.EventHandler(this.telegramToolStripMenuItem_Click);
            // 
            // homepageToolStripMenuItem
            // 
            this.homepageToolStripMenuItem.Image = global::Mail_Filters.Properties.Resources.github_16px;
            this.homepageToolStripMenuItem.Name = "homepageToolStripMenuItem";
            this.homepageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.homepageToolStripMenuItem.Text = "Homepage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 329);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Filters Pro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMailListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem clearResultsToolStripMenuItem;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telegramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homepageToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label2;
    }
}

