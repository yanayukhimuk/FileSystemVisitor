
namespace FileSystemVisitor
{
    partial class FileSystemVisitorForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.foundFilesListView = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileTypeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(33, 28);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(93, 22);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // foundFilesListView
            // 
            this.foundFilesListView.HideSelection = false;
            this.foundFilesListView.LargeImageList = this.iconList;
            this.foundFilesListView.Location = new System.Drawing.Point(33, 71);
            this.foundFilesListView.Name = "foundFilesListView";
            this.foundFilesListView.Size = new System.Drawing.Size(714, 304);
            this.foundFilesListView.SmallImageList = this.iconList;
            this.foundFilesListView.TabIndex = 1;
            this.foundFilesListView.UseCompatibleStateImageBehavior = false;
            this.foundFilesListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.foundFilesListView_ItemSelectionChanged);
            this.foundFilesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.foundFilesListView_MouseDoubleClick);
            // 
            // iconList
            // 
            this.iconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.iconList.ImageSize = new System.Drawing.Size(48, 48);
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(132, 28);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(500, 22);
            this.filePathTextBox.TabIndex = 2;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(651, 28);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(96, 22);
            this.findButton.TabIndex = 3;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "--";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(30, 424);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(69, 16);
            this.fileNameLabel.TabIndex = 5;
            this.fileNameLabel.Text = "File Name";
            this.fileNameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // fileTypeLabel
            // 
            this.fileTypeLabel.AutoSize = true;
            this.fileTypeLabel.Location = new System.Drawing.Point(610, 424);
            this.fileTypeLabel.Name = "fileTypeLabel";
            this.fileTypeLabel.Size = new System.Drawing.Size(64, 16);
            this.fileTypeLabel.TabIndex = 6;
            this.fileTypeLabel.Text = "File Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(699, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "--";
            // 
            // FileSystemVisitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 464);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fileTypeLabel);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.foundFilesListView);
            this.Controls.Add(this.backButton);
            this.Name = "FileSystemVisitorForm";
            this.Text = "FileSystemVisitor";
            this.Load += new System.EventHandler(this.FileSystemVisitorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListView foundFilesListView;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label fileTypeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList iconList;
    }
}

