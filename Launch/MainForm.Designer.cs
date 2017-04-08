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
            this.commandListBox = new System.Windows.Forms.ListBox();
            this.editLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addLinkLabel = new System.Windows.Forms.LinkLabel();
            this.reorderLinkLabel = new System.Windows.Forms.LinkLabel();
            this.deleteLinkLabel = new System.Windows.Forms.LinkLabel();
            this.minimizeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.closeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // commandListBox
            // 
            this.commandListBox.AllowDrop = true;
            this.commandListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandListBox.FormattingEnabled = true;
            this.commandListBox.ItemHeight = 16;
            this.commandListBox.Location = new System.Drawing.Point(0, 18);
            this.commandListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.commandListBox.Name = "commandListBox";
            this.commandListBox.Size = new System.Drawing.Size(255, 196);
            this.commandListBox.TabIndex = 0;
            this.commandListBox.SelectedIndexChanged += new System.EventHandler(this.commandListBox_SelectedIndexChanged);
            this.commandListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.commandListBox_DragDrop);
            this.commandListBox.DragOver += new System.Windows.Forms.DragEventHandler(this.commandListBox_DragOver);
            this.commandListBox.DoubleClick += new System.EventHandler(this.commandListBox_DoubleClick);
            this.commandListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.commandListBox_KeyDown);
            this.commandListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.commandListBox_MouseDown);
            // 
            // editLinkLabel
            // 
            this.editLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editLinkLabel.AutoSize = true;
            this.editLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.editLinkLabel.Location = new System.Drawing.Point(41, 215);
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
            this.addLinkLabel.Location = new System.Drawing.Point(3, 215);
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
            this.reorderLinkLabel.Location = new System.Drawing.Point(200, 215);
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
            this.deleteLinkLabel.Location = new System.Drawing.Point(77, 215);
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
            this.minimizeLinkLabel.Location = new System.Drawing.Point(213, 0);
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
            this.closeLinkLabel.Location = new System.Drawing.Point(236, 0);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 231);
            this.Controls.Add(this.closeLinkLabel);
            this.Controls.Add(this.minimizeLinkLabel);
            this.Controls.Add(this.reorderLinkLabel);
            this.Controls.Add(this.addLinkLabel);
            this.Controls.Add(this.deleteLinkLabel);
            this.Controls.Add(this.editLinkLabel);
            this.Controls.Add(this.commandListBox);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Launch";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox commandListBox;
        private System.Windows.Forms.LinkLabel editLinkLabel;
        private System.Windows.Forms.LinkLabel addLinkLabel;
        private System.Windows.Forms.LinkLabel reorderLinkLabel;
        private System.Windows.Forms.LinkLabel deleteLinkLabel;
        private System.Windows.Forms.LinkLabel minimizeLinkLabel;
        private System.Windows.Forms.LinkLabel closeLinkLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

