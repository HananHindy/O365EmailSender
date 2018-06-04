using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace O365EmailSender
{
    public partial class EmailForm : Form
    {
        public string Subject { get; set; }
        public string  Message { get; set; }
        public ExcelFileHandler FileHandler { get; set; }

        public EmailForm(string subject, string message, ExcelFileHandler fileHandler)
        {
            InitializeComponent();
            this.Subject = subject;
            this.Message = message;
            this.FileHandler = fileHandler;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                this.FileHandler.SendEmails(this.Subject, this.Message, txtUserName.Text, txtPassword.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            this.lblResult.Visible = true;
            btnSend.Enabled = false;
        }
    }
}
