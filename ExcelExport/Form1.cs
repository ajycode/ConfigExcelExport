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

namespace ExcelExport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] arr = new String[] { "Lua", "Json" };
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
                indirTextBox.Text = foldPath;

                //
                DirectoryInfo fdir = new DirectoryInfo(foldPath);
                FileInfo[] files = fdir.GetFiles().Where(s => s.Name.EndsWith(".xlsx") || s.Name.EndsWith(".xls")).ToArray();
                fileCheckListBox.Items.Clear();
                foreach (FileInfo file in files)
                {
                   fileCheckListBox.Items.Add(file.FullName);
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
                outDirTextBox.Text = foldPath;
            }
        }

        private void generatorBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(indirTextBox.Text))
            {
                MessageBox.Show("请选择excel文件目录");
                return;
            }
            if (string.IsNullOrEmpty(outDirTextBox.Text))
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
            switch (generatorType)
            {
                case "Lua":
                    GenLua.Generator(exportFiles, outDirTextBox.Text);
                    break;
                case "Json":
                    break;
                default:
                    break;
            }
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
