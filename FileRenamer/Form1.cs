using System;
using System.IO;
using System.Windows.Forms;

namespace FileRenamer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            folderBrowser.RootFolder = Environment.SpecialFolder.DesktopDirectory;
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = folderBrowser.SelectedPath.ToString();
            }
        }

        private void btRename_Click(object sender, EventArgs e)
        {
            btBrowse.Enabled = false;
            pbProgress.Visible = true;
            RenameAll(Directory.GetFiles(tbPath.Text));
            btBrowse.Enabled = true;
            pbProgress.Visible = false;
        }

        private void RenameAll(string[] files)
        {
            pbProgress.Value = 0;
            pbProgress.Maximum = files.Length;
            for (var i = 0; i < files.Length; i++)
            {
                var p = Path.Combine(tbPath.Text, GetName(files, i)).ToString();
                File.Move(files[i], p);
                pbProgress.Value = i + 1;
            }

        }

        private string GetName(string[] files,int i)
        {
            var ind = files[i].Length-files[i].LastIndexOf('.');
            var ext = ind>=0?files[i].Substring(files[i].Length - ind, ind):string.Empty;
            if (rbRandom.Checked) return GetRandom() + ext;
            if (rbNumeric.Checked) return i.ToString()+ ext;
            if (rbGuid.Checked) return Guid.NewGuid().ToString()+ ext;
            if(rbDate.Checked) return File.GetCreationTime(files[i]).ToShortDateString()+"_"+i.ToString() + ext;
            return GetRandom() + ext;
        }

        private string GetRandom()
        {
            var a = Path.GetRandomFileName();
            return a.Substring(0, a.Length-4);
        }
    }
}
