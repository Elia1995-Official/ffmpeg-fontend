using System.Diagnostics;

namespace ffmpeg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void videoSearchBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                videoTextBox.Text = openFileDialog1.FileName;
            }
        }

        private void outputSearchBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                outputTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            Process p = new();
            p.StartInfo.FileName = "ffmpeg.exe";
            p.StartInfo.Arguments = "-i \"" + videoTextBox.Text + "\" -filter_complex" +
                " \"[0:v]minterpolate=fps=30:mi_mode=dup[v]\" -map [v] -map 0:a -c:a copy -c:v libx264 -preset:v medium -minrate:v 0 " +
                "-maxrate:v 0 -b:v 0 -crf:v 26 -r 30 -vsync cfr -x264-params \"opencl=true\" output.mkv";
            p.StartInfo.WorkingDirectory = outputTextBox.Text;

            p.Start();
            p.WaitForExit();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            Process p = new();
            p.StartInfo.FileName = "ffmpeg.exe";
            p.StartInfo.Arguments = "-i \"" + videoTextBox.Text + "\" -filter_complex" +
                " \"[0:v]minterpolate=fps=30:mi_mode=dup[v]\" -map [v] -an -map_metadata -1 -pix_fmt yuvj420p -c:v mjpeg -q:v 2 -r 30 -vsync cfr frame%016d.jpg";
            p.StartInfo.WorkingDirectory = outputTextBox.Text;

            p.Start();
            p.WaitForExit();
        }

        private void videoTextBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void videoTextBox_DragEnter(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length > 0)
            {
                videoTextBox.Text = files[0];
            }
        }
    }
}