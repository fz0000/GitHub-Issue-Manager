using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GitHub_Issue_Manager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private string RunGH(string strArgs = "", int intTimeout = 5000)
        {
            Process ps = new Process();
            string tmpOutput = "";
            ps.StartInfo.FileName = "gh.exe";
            ps.StartInfo.Arguments = strArgs;
            ps.StartInfo.UseShellExecute = false;
            ps.StartInfo.CreateNoWindow = true;
            ps.StartInfo.RedirectStandardOutput = true;
            ps.StartInfo.RedirectStandardError = true;
            ps.StartInfo.RedirectStandardInput = true;
            try
            {
                ps.Start();
                if (!ps.WaitForExit(intTimeout))
                {
                    ps.Kill();
                }
                tmpOutput = ps.StandardOutput.ReadToEnd();
            }
            catch
            {
                MessageBox.Show("GitHub CLI 未安装." + Environment.NewLine +
                    "请安装GitHub CLI或将gh.exe放到本程序所在的文件夹中。", "GitHub CLI未找到", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tmpOutput;
        }

        private void ToolStripButtonOpen_Click(object sender, EventArgs e)
        {
            string strArgs = "";
            string strOutput = RunGH(strArgs);
            if (strOutput != "")
            {
                MessageBox.Show(strOutput);
            }
        }
    }
}
