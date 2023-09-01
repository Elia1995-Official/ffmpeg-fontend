namespace ffmpeg
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            convertBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            videoTextBox = new TextBox();
            outputTextBox = new TextBox();
            outputSearchBtn = new Button();
            exportBtn = new Button();
            videoSearchBtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // convertBtn
            // 
            convertBtn.FlatStyle = FlatStyle.Flat;
            convertBtn.Location = new Point(28, 226);
            convertBtn.Name = "convertBtn";
            convertBtn.Size = new Size(134, 23);
            convertBtn.TabIndex = 0;
            convertBtn.Text = "Convert VFR to CBR";
            convertBtn.UseVisualStyleBackColor = true;
            convertBtn.UseWaitCursor = true;
            convertBtn.Click += convertBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 32);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "Video file:";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 112);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 2;
            label2.Text = "Output folder:";
            label2.UseWaitCursor = true;
            // 
            // videoTextBox
            // 
            videoTextBox.AllowDrop = true;
            videoTextBox.Location = new Point(28, 50);
            videoTextBox.Name = "videoTextBox";
            videoTextBox.Size = new Size(287, 23);
            videoTextBox.TabIndex = 3;
            videoTextBox.UseWaitCursor = true;
            videoTextBox.DragDrop += videoTextBox_DragDrop;
            videoTextBox.DragEnter += videoTextBox_DragEnter;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(28, 130);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(287, 23);
            outputTextBox.TabIndex = 3;
            outputTextBox.UseWaitCursor = true;
            // 
            // outputSearchBtn
            // 
            outputSearchBtn.FlatStyle = FlatStyle.Flat;
            outputSearchBtn.Location = new Point(321, 130);
            outputSearchBtn.Name = "outputSearchBtn";
            outputSearchBtn.Size = new Size(29, 23);
            outputSearchBtn.TabIndex = 0;
            outputSearchBtn.Text = "...";
            outputSearchBtn.UseVisualStyleBackColor = true;
            outputSearchBtn.UseWaitCursor = true;
            outputSearchBtn.Click += outputSearchBtn_Click;
            // 
            // exportBtn
            // 
            exportBtn.FlatStyle = FlatStyle.Flat;
            exportBtn.Location = new Point(275, 226);
            exportBtn.Name = "exportBtn";
            exportBtn.Size = new Size(75, 23);
            exportBtn.TabIndex = 0;
            exportBtn.Text = "Export";
            exportBtn.UseVisualStyleBackColor = true;
            exportBtn.UseWaitCursor = true;
            exportBtn.Click += exportBtn_Click;
            // 
            // videoSearchBtn
            // 
            videoSearchBtn.FlatStyle = FlatStyle.Flat;
            videoSearchBtn.Location = new Point(321, 50);
            videoSearchBtn.Name = "videoSearchBtn";
            videoSearchBtn.Size = new Size(29, 23);
            videoSearchBtn.TabIndex = 0;
            videoSearchBtn.Text = "...";
            videoSearchBtn.UseVisualStyleBackColor = true;
            videoSearchBtn.UseWaitCursor = true;
            videoSearchBtn.Click += videoSearchBtn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "All files|*.*";
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.Description = "Select the Output folder";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(393, 263);
            Controls.Add(outputTextBox);
            Controls.Add(videoTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(videoSearchBtn);
            Controls.Add(outputSearchBtn);
            Controls.Add(exportBtn);
            Controls.Add(convertBtn);
            Name = "Form1";
            Text = "FFmpeg GUI";
            UseWaitCursor = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button convertBtn;
        private Label label1;
        private Label label2;
        private TextBox videoTextBox;
        private TextBox outputTextBox;
        private Button outputSearchBtn;
        private Button exportBtn;
        private Button videoSearchBtn;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}