using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelToLua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] arr = new String[] { "Lua", "Json", "Xml" };
            for (int i = 0; i < arr.Length; i++)
            {
                this.generatorTypeSelect.Items.Add(arr[i]);
            }
            this.selectAllBox.Checked = true;
        }

        private void indirBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择excel文件夹目录";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                Generator.indir = foldPath;
                indirTextBox.Text = foldPath;

                //
                DirectoryInfo fdir = new DirectoryInfo(foldPath);
                FileInfo[] files = fdir.GetFiles("*.xlsx");
                fileCheckListBox.Items.Clear();
                foreach (FileInfo file in files)
                {
                   fileCheckListBox.Items.Add(file.Name);
                }
                bool isCheck = this.selectAllBox.Checked;
                for (int i = 0; i < fileCheckListBox.Items.Count; i++)
                {
                    fileCheckListBox.SetItemChecked(i, isCheck);
                }
            }
        }

        private void outdirBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择导出文件夹目录";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                Generator.outdir = foldPath;
                outDirTextBox.Text = foldPath;
            }
        }

        private void generatorBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Generator.indir))
            {
                MessageBox.Show("请选择excel文件目录");
                return;
            }
            if (string.IsNullOrEmpty(Generator.outdir))
            {
                MessageBox.Show("请选择导出目录");
                return;
            }
            string generatorType = (string)this.generatorTypeSelect.SelectedItem;
            if (string.IsNullOrEmpty(generatorType))
            {
                MessageBox.Show("请选择导出文件类型");
                return;
            }
            if(fileCheckListBox.CheckedItems.Count <= 0)
            {
                MessageBox.Show("请选择要导出的excel文件");
                return;
            }
            List<string> exportFiles = new List<string>(fileCheckListBox.CheckedItems.Count);
            foreach(var item in fileCheckListBox.CheckedItems)
            {
                exportFiles.Add((string)item);
            }
            Generator.Gen(generatorType, exportFiles);
        }

        private void on_SelectAllBox_CheckChange(object sender, EventArgs e)
        {
            if (selectAllBox.Checked)
            {
                for (int i = 0; i < fileCheckListBox.Items.Count; i++)
                {
                    fileCheckListBox.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < fileCheckListBox.Items.Count; i++)
                {
                    fileCheckListBox.SetItemChecked(i, false);
                }
            }
        }
    }
}
