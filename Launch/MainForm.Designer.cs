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
            this.commandListBox.Location = new System.Drawing.Point(0, 2);
            this.commandListBox.Name = "commandListBox";
            this.commandListBox.Size = new System.Drawing.Size(356, 212);
            this.commandListBox.TabIndex = 1;
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
            this.editLinkLabel.Location = new System.Drawing.Point(41, 215);
            this.editLinkLabel.Name = "editLinkLabel";
            this.editLinkLabel.Size = new System.Drawing.Size(31, 17);
            this.editLinkLabel.TabIndex = 6;
            this.editLinkLabel.TabStop = true;
            this.editLinkLabel.Text = "edit";
            this.editLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.editLinkLabel_LinkClicked);
            // 
            // addLinkLabel
            // 
            this.addLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addLinkLabel.AutoSize = true;
            this.addLinkLabel.Location = new System.Drawing.Point(3, 215);
            this.addLinkLabel.Name = "addLinkLabel";
            this.addLinkLabel.Size = new System.Drawing.Size(32, 17);
            this.addLinkLabel.TabIndex = 6;
            this.addLinkLabel.TabStop = true;
            this.addLinkLabel.Text = "add";
            this.addLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addLinkLabel_LinkClicked);
            // 
            // reorderLinkLabel
            // 
            this.reorderLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reorderLinkLabel.AutoSize = true;
            this.reorderLinkLabel.Location = new System.Drawing.Point(301, 215);
            this.reorderLinkLabel.Name = "reorderLinkLabel";
            this.reorderLinkLabel.Size = new System.Drawing.Size(55, 17);
            this.reorderLinkLabel.TabIndex = 6;
            this.reorderLinkLabel.TabStop = true;
            this.reorderLinkLabel.Text = "reorder";
            this.reorderLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.reorderLinkLabel_LinkClicked);
            // 
            // deleteLinkLabel
            // 
            this.deleteLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteLinkLabel.AutoSize = true;
            this.deleteLinkLabel.Location = new System.Drawing.Point(78, 215);
            this.deleteLinkLabel.Name = "deleteLinkLabel";
            this.deleteLinkLabel.Size = new System.Drawing.Size(47, 17);
            this.deleteLinkLabel.TabIndex = 6;
            this.deleteLinkLabel.TabStop = true;
            this.deleteLinkLabel.Text = "delete";
            this.deleteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.deleteLinkLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 232);
            this.Controls.Add(this.reorderLinkLabel);
            this.Controls.Add(this.addLinkLabel);
            this.Controls.Add(this.deleteLinkLabel);
            this.Controls.Add(this.editLinkLabel);
            this.Controls.Add(this.commandListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Launch";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox commandListBox;
        private System.Windows.Forms.LinkLabel editLinkLabel;
        private System.Windows.Forms.LinkLabel addLinkLabel;
        private System.Windows.Forms.LinkLabel reorderLinkLabel;
        private System.Windows.Forms.LinkLabel deleteLinkLabel;
    }
}

