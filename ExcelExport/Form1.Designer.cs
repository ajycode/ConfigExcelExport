using System;
using System.Windows.Forms;

namespace ExcelExport
{
    partial class Form1
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
            this.indirBtn = new System.Windows.Forms.Button();
            this.outdirBtn = new System.Windows.Forms.Button();
            this.indirTextBox = new System.Windows.Forms.TextBox();
            this.outDirTextBox = new System.Windows.Forms.TextBox();
            this.generatorTypeSelect = new System.Windows.Forms.ComboBox();
            this.generatorTypeLable = new System.Windows.Forms.Label();
            this.generatorBtn = new System.Windows.Forms.Button();
            this.fileCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.selectAllBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // indirBtn
            // 
            this.indirBtn.Location = new System.Drawing.Point(26, 56);
            this.indirBtn.Name = "indirBtn";
            this.indirBtn.Size = new System.Drawing.Size(134, 40);
            this.indirBtn.TabIndex = 1;
            this.indirBtn.Text = "选择目录文件夹";
            this.indirBtn.UseVisualStyleBackColor = true;
            this.indirBtn.Click += new System.EventHandler(this.indirBtn_Click);
            // 
            // outdirBtn
            // 
            this.outdirBtn.Location = new System.Drawing.Point(26, 111);
            this.outdirBtn.Name = "outdirBtn";
            this.outdirBtn.Size = new System.Drawing.Size(134, 40);
            this.outdirBtn.TabIndex = 2;
            this.outdirBtn.Text = "选择导出目录";
            this.outdirBtn.UseVisualStyleBackColor = true;
            this.outdirBtn.Click += new System.EventHandler(this.outdirBtn_Click);
            // 
            // indirTextBox
            // 
            this.indirTextBox.Location = new System.Drawing.Point(188, 66);
            this.indirTextBox.Name = "indirTextBox";
            this.indirTextBox.Size = new System.Drawing.Size(727, 25);
            this.indirTextBox.TabIndex = 3;
            // 
            // outDirTextBox
            // 
            this.outDirTextBox.Location = new System.Drawing.Point(188, 126);
            this.outDirTextBox.Name = "outDirTextBox";
            this.outDirTextBox.Size = new System.Drawing.Size(727, 25);
            this.outDirTextBox.TabIndex = 4;
            // 
            // generatorTypeSelect
            // 
            this.generatorTypeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generatorTypeSelect.FormattingEnabled = true;
            this.generatorTypeSelect.Location = new System.Drawing.Point(188, 170);
            this.generatorTypeSelect.Name = "generatorTypeSelect";
            this.generatorTypeSelect.Size = new System.Drawing.Size(121, 23);
            this.generatorTypeSelect.TabIndex = 5;
            // 
            // generatorTypeLable
            // 
            this.generatorTypeLable.AutoSize = true;
            this.generatorTypeLable.Location = new System.Drawing.Point(23, 178);
            this.generatorTypeLable.Name = "generatorTypeLable";
            this.generatorTypeLable.Size = new System.Drawing.Size(127, 15);
            this.generatorTypeLable.TabIndex = 6;
            this.generatorTypeLable.Text = "选择导出文件类型";
            // 
            // generatorBtn
            // 
            this.generatorBtn.Location = new System.Drawing.Point(368, 165);
            this.generatorBtn.Name = "generatorBtn";
            this.generatorBtn.Size = new System.Drawing.Size(75, 30);
            this.generatorBtn.TabIndex = 7;
            this.generatorBtn.Text = "导出";
            this.generatorBtn.UseVisualStyleBackColor = true;
            this.generatorBtn.Click += new System.EventHandler(this.generatorBtn_Click);
            // 
            // fileCheckListBox
            // 
            this.fileCheckListBox.FormattingEnabled = true;
            this.fileCheckListBox.Location = new System.Drawing.Point(26, 227);
            this.fileCheckListBox.Name = "fileCheckListBox";
            this.fileCheckListBox.Size = new System.Drawing.Size(1404, 504);
            this.fileCheckListBox.TabIndex = 8;
            // 
            // selectAllBox
            // 
            this.selectAllBox.AutoSize = true;
            this.selectAllBox.Location = new System.Drawing.Point(26, 748);
            this.selectAllBox.Name = "selectAllBox";
            this.selectAllBox.Size = new System.Drawing.Size(89, 19);
            this.selectAllBox.TabIndex = 9;
            this.selectAllBox.Text = "文件全选";
            this.selectAllBox.UseVisualStyleBackColor = true;
            this.selectAllBox.CheckedChanged += new System.EventHandler(this.on_SelectAllBox_CheckChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 807);
            this.Controls.Add(this.selectAllBox);
            this.Controls.Add(this.fileCheckListBox);
            this.Controls.Add(this.generatorBtn);
            this.Controls.Add(this.generatorTypeLable);
            this.Controls.Add(this.generatorTypeSelect);
            this.Controls.Add(this.outDirTextBox);
            this.Controls.Add(this.indirTextBox);
            this.Controls.Add(this.outdirBtn);
            this.Controls.Add(this.indirBtn);
            this.Name = "Form1";
            this.Text = "ExcelExport";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button indirBtn;
        private Button outdirBtn;
        private TextBox indirTextBox;
        private TextBox outDirTextBox;
        private ComboBox generatorTypeSelect;
        private Label generatorTypeLable;
        private Button generatorBtn;
        private CheckedListBox fileCheckListBox;
        private CheckBox selectAllBox;
    }
}

