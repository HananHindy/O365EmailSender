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

namespace O365EmailSender
{
    public partial class Form1 : Form
    {
        public ExcelFileHandler FileHandler = new ExcelFileHandler();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string readFilePath = fileDialog.FileName;
                txtFilePath.Text = readFilePath;
                this.FileHandler.FilePath = readFilePath;
                btnStart.Enabled = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            dgvToInfo.Rows.Clear();
            var users = this.FileHandler.ReadUsers();
            if (users.Count <= 0)
            {
                MessageBox.Show("List cannot be empty");
                return;
            }

            foreach (var u in users)
            {
                dgvToInfo.Rows.Add(u.Name, u.Email);
            }

            lblToInfoMessage.Visible = true;
            dgvToInfo.Visible = true;
            btnNext.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            lblEmailInfo.Visible =
            txtSubject.Visible = 
            txtEmailTemplate.Visible = 
            btnNext2.Visible = true;
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            lblPreview.Text = string.Format(txtEmailTemplate.Text, dgvToInfo.Rows[0].Cells[0].Value.ToString());
            lblPreview.Visible = true;
            btnSendEmails.Visible = true;
            btnAttach.Visible = true;
            txtAttachments.Visible = true;
        }

        private void btnSendEmails_Click(object sender, EventArgs e)
        {
            new EmailForm(txtSubject.Text, txtEmailTemplate.Text, this.FileHandler).Show();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readFilePaths = fileDialog.FileNames;
                txtAttachments.Text = string.Join(",", readFilePaths);
                this.FileHandler.Attachments = readFilePaths;
            }
        }
    }
}
