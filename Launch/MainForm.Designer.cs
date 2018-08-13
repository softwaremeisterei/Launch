namespace Launch
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.editLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addLinkLabel = new System.Windows.Forms.LinkLabel();
            this.reorderLinkLabel = new System.Windows.Forms.LinkLabel();
            this.deleteLinkLabel = new System.Windows.Forms.LinkLabel();
            this.minimizeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.closeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.commandListBox = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.addTabLinkLabel = new System.Windows.Forms.LinkLabel();
            this.removeTabLinkLabel = new System.Windows.Forms.LinkLabel();
            this.renameTabLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // editLinkLabel
            // 
            this.editLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editLinkLabel.AutoSize = true;
            this.editLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.editLinkLabel.Location = new System.Drawing.Point(44, 249);
            this.editLinkLabel.Name = "editLinkLabel";
            this.editLinkLabel.Size = new System.Drawing.Size(31, 17);
            this.editLinkLabel.TabIndex = 2;
            this.editLinkLabel.TabStop = true;
            this.editLinkLabel.Text = "edit";
            this.editLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.editLinkLabel_LinkClicked);
            // 
            // addLinkLabel
            // 
            this.addLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addLinkLabel.AutoSize = true;
            this.addLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.addLinkLabel.Location = new System.Drawing.Point(6, 249);
            this.addLinkLabel.Name = "addLinkLabel";
            this.addLinkLabel.Size = new System.Drawing.Size(32, 17);
            this.addLinkLabel.TabIndex = 1;
            this.addLinkLabel.TabStop = true;
            this.addLinkLabel.Text = "add";
            this.addLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addLinkLabel_LinkClicked);
            // 
            // reorderLinkLabel
            // 
            this.reorderLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reorderLinkLabel.AutoSize = true;
            this.reorderLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.reorderLinkLabel.Location = new System.Drawing.Point(185, 249);
            this.reorderLinkLabel.Name = "reorderLinkLabel";
            this.reorderLinkLabel.Size = new System.Drawing.Size(55, 17);
            this.reorderLinkLabel.TabIndex = 4;
            this.reorderLinkLabel.TabStop = true;
            this.reorderLinkLabel.Text = "reorder";
            this.reorderLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reorderLinkLabel_LinkClicked);
            // 
            // deleteLinkLabel
            // 
            this.deleteLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteLinkLabel.AutoSize = true;
            this.deleteLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.deleteLinkLabel.Location = new System.Drawing.Point(80, 249);
            this.deleteLinkLabel.Name = "deleteLinkLabel";
            this.deleteLinkLabel.Size = new System.Drawing.Size(47, 17);
            this.deleteLinkLabel.TabIndex = 3;
            this.deleteLinkLabel.TabStop = true;
            this.deleteLinkLabel.Text = "delete";
            this.deleteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.deleteLinkLabel_LinkClicked);
            // 
            // minimizeLinkLabel
            // 
            this.minimizeLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeLinkLabel.AutoSize = true;
            this.minimizeLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.minimizeLinkLabel.Location = new System.Drawing.Point(218, 0);
            this.minimizeLinkLabel.Name = "minimizeLinkLabel";
            this.minimizeLinkLabel.Size = new System.Drawing.Size(16, 17);
            this.minimizeLinkLabel.TabIndex = 4;
            this.minimizeLinkLabel.TabStop = true;
            this.minimizeLinkLabel.Text = "_";
            this.minimizeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.minimizeLinkLabel_LinkClicked);
            // 
            // closeLinkLabel
            // 
            this.closeLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeLinkLabel.AutoSize = true;
            this.closeLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.closeLinkLabel.Location = new System.Drawing.Point(241, 0);
            this.closeLinkLabel.Name = "closeLinkLabel";
            this.closeLinkLabel.Size = new System.Drawing.Size(14, 17);
            this.closeLinkLabel.TabIndex = 4;
            this.closeLinkLabel.TabStop = true;
            this.closeLinkLabel.Text = "x";
            this.closeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.closeLinkLabel_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Launch.Properties.Resources.logo_noframe;
            this.pictureBox1.Location = new System.Drawing.Point(6, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 20);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(34, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(50, 17);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "launch";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.commandListBox);
            this.tabPage1.Controls.Add(this.addLinkLabel);
            this.tabPage1.Controls.Add(this.editLinkLabel);
            this.tabPage1.Controls.Add(this.deleteLinkLabel);
            this.tabPage1.Controls.Add(this.reorderLinkLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(246, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // commandListBox
            // 
            this.commandListBox.AllowDrop = true;
            this.commandListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandListBox.FormattingEnabled = true;
            this.commandListBox.ItemHeight = 16;
            this.commandListBox.Location = new System.Drawing.Point(3, 4);
            this.commandListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.commandListBox.Name = "commandListBox";
            this.commandListBox.Size = new System.Drawing.Size(240, 244);
            this.commandListBox.TabIndex = 0;
            this.commandListBox.SelectedIndexChanged += new System.EventHandler(this.commandListBox_SelectedIndexChanged);
            this.commandListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.commandListBox_DragDrop);
            this.commandListBox.DragOver += new System.Windows.Forms.DragEventHandler(this.commandListBox_DragOver);
            this.commandListBox.DoubleClick += new System.EventHandler(this.commandListBox_DoubleClick);
            this.commandListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.commandListBox_KeyDown);
            this.commandListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.commandListBox_MouseDown);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(254, 298);
            this.tabControl1.TabIndex = 7;
            // 
            // addTabLinkLabel
            // 
            this.addTabLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addTabLinkLabel.AutoSize = true;
            this.addTabLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.addTabLinkLabel.Location = new System.Drawing.Point(4, 321);
            this.addTabLinkLabel.Name = "addTabLinkLabel";
            this.addTabLinkLabel.Size = new System.Drawing.Size(56, 17);
            this.addTabLinkLabel.TabIndex = 1;
            this.addTabLinkLabel.TabStop = true;
            this.addTabLinkLabel.Text = "add tab";
            this.addTabLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addTabLinkLabel_LinkClicked);
            // 
            // removeTabLinkLabel
            // 
            this.removeTabLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeTabLinkLabel.AutoSize = true;
            this.removeTabLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.removeTabLinkLabel.Location = new System.Drawing.Point(151, 321);
            this.removeTabLinkLabel.Name = "removeTabLinkLabel";
            this.removeTabLinkLabel.Size = new System.Drawing.Size(79, 17);
            this.removeTabLinkLabel.TabIndex = 1;
            this.removeTabLinkLabel.TabStop = true;
            this.removeTabLinkLabel.Text = "remove tab";
            this.removeTabLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.removeTabLinkLabel_LinkClicked);
            // 
            // renameTabLinkLabel
            // 
            this.renameTabLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.renameTabLinkLabel.AutoSize = true;
            this.renameTabLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.renameTabLinkLabel.Location = new System.Drawing.Point(66, 321);
            this.renameTabLinkLabel.Name = "renameTabLinkLabel";
            this.renameTabLinkLabel.Size = new System.Drawing.Size(80, 17);
            this.renameTabLinkLabel.TabIndex = 1;
            this.renameTabLinkLabel.TabStop = true;
            this.renameTabLinkLabel.Text = "rename tab";
            this.renameTabLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.renameTabLinkLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 340);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.renameTabLinkLabel);
            this.Controls.Add(this.removeTabLinkLabel);
            this.Controls.Add(this.addTabLinkLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.closeLinkLabel);
            this.Controls.Add(this.minimizeLinkLabel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(225, 200);
            this.Name = "MainForm";
            this.Text = "Launch";
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel editLinkLabel;
        private System.Windows.Forms.LinkLabel addLinkLabel;
        private System.Windows.Forms.LinkLabel reorderLinkLabel;
        private System.Windows.Forms.LinkLabel deleteLinkLabel;
        private System.Windows.Forms.LinkLabel minimizeLinkLabel;
        private System.Windows.Forms.LinkLabel closeLinkLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox commandListBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.LinkLabel addTabLinkLabel;
        private System.Windows.Forms.LinkLabel removeTabLinkLabel;
        private System.Windows.Forms.LinkLabel renameTabLinkLabel;
    }
}

