namespace FileApplication
{
    partial class FileApp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileExplorer = new System.Windows.Forms.Button();
            this.listOfFiles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numOfRepetitionsLabel = new System.Windows.Forms.Label();
            this.textBoxForSelectedFile = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 22);
            this.textBox1.TabIndex = 0;
            // 
            // openFileExplorer
            // 
            this.openFileExplorer.Location = new System.Drawing.Point(181, 24);
            this.openFileExplorer.Name = "openFileExplorer";
            this.openFileExplorer.Size = new System.Drawing.Size(102, 24);
            this.openFileExplorer.TabIndex = 1;
            this.openFileExplorer.Text = "File Explorer";
            this.openFileExplorer.UseVisualStyleBackColor = true;
            this.openFileExplorer.Click += new System.EventHandler(this.openFileExplorer_Click);
            // 
            // listOfFiles
            // 
            this.listOfFiles.FormattingEnabled = true;
            this.listOfFiles.ItemHeight = 16;
            this.listOfFiles.Location = new System.Drawing.Point(26, 114);
            this.listOfFiles.Name = "listOfFiles";
            this.listOfFiles.Size = new System.Drawing.Size(269, 228);
            this.listOfFiles.TabIndex = 2;
            this.listOfFiles.SelectedIndexChanged += new System.EventHandler(this.listOfFiles_SelectedIndexChanged);
            this.listOfFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listOfFiles_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter search string:";
            // 
            // numOfRepetitionsLabel
            // 
            this.numOfRepetitionsLabel.AutoSize = true;
            this.numOfRepetitionsLabel.Location = new System.Drawing.Point(132, 360);
            this.numOfRepetitionsLabel.Name = "numOfRepetitionsLabel";
            this.numOfRepetitionsLabel.Size = new System.Drawing.Size(127, 17);
            this.numOfRepetitionsLabel.TabIndex = 4;
            this.numOfRepetitionsLabel.Text = "Num of repetitions:";
            // 
            // textBoxForSelectedFile
            // 
            this.textBoxForSelectedFile.Location = new System.Drawing.Point(398, 82);
            this.textBoxForSelectedFile.Name = "textBoxForSelectedFile";
            this.textBoxForSelectedFile.Size = new System.Drawing.Size(299, 260);
            this.textBoxForSelectedFile.TabIndex = 6;
            this.textBoxForSelectedFile.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "List of matching files:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Text in selected file:";
            // 
            // FileApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 426);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxForSelectedFile);
            this.Controls.Add(this.numOfRepetitionsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listOfFiles);
            this.Controls.Add(this.openFileExplorer);
            this.Controls.Add(this.textBox1);
            this.Name = "FileApp";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button openFileExplorer;
        private System.Windows.Forms.ListBox listOfFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numOfRepetitionsLabel;
        private System.Windows.Forms.RichTextBox textBoxForSelectedFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

