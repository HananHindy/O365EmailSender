namespace O365EmailSender
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.dgvToInfo = new System.Windows.Forms.DataGridView();
            this.Name2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblToInfoMessage = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtEmailTemplate = new System.Windows.Forms.TextBox();
            this.lblEmailInfo = new System.Windows.Forms.Label();
            this.btnNext2 = new System.Windows.Forms.Button();
            this.lblPreview = new System.Windows.Forms.Label();
            this.btnSendEmails = new System.Windows.Forms.Button();
            this.txtSubject = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(12, 61);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(745, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(682, 23);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(12, 23);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(654, 20);
            this.txtFilePath.TabIndex = 0;
            // 
            // dgvToInfo
            // 
            this.dgvToInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name2,
            this.Email});
            this.dgvToInfo.Enabled = false;
            this.dgvToInfo.Location = new System.Drawing.Point(12, 139);
            this.dgvToInfo.Name = "dgvToInfo";
            this.dgvToInfo.Size = new System.Drawing.Size(745, 576);
            this.dgvToInfo.TabIndex = 3;
            this.dgvToInfo.Visible = false;
            // 
            // Name2
            // 
            this.Name2.HeaderText = "Name";
            this.Name2.MinimumWidth = 15;
            this.Name2.Name = "Name2";
            this.Name2.Width = 300;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 30;
            this.Email.Name = "Email";
            this.Email.Width = 400;
            // 
            // lblToInfoMessage
            // 
            this.lblToInfoMessage.AutoSize = true;
            this.lblToInfoMessage.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToInfoMessage.Location = new System.Drawing.Point(118, 103);
            this.lblToInfoMessage.Name = "lblToInfoMessage";
            this.lblToInfoMessage.Size = new System.Drawing.Size(508, 24);
            this.lblToInfoMessage.TabIndex = 7;
            this.lblToInfoMessage.Text = "Please review the data below and press Next";
            this.lblToInfoMessage.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(703, 737);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtEmailTemplate
            // 
            this.txtEmailTemplate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailTemplate.Location = new System.Drawing.Point(816, 111);
            this.txtEmailTemplate.Multiline = true;
            this.txtEmailTemplate.Name = "txtEmailTemplate";
            this.txtEmailTemplate.Size = new System.Drawing.Size(684, 292);
            this.txtEmailTemplate.TabIndex = 6;
            this.txtEmailTemplate.Visible = false;
            // 
            // lblEmailInfo
            // 
            this.lblEmailInfo.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailInfo.Location = new System.Drawing.Point(816, 9);
            this.lblEmailInfo.Name = "lblEmailInfo";
            this.lblEmailInfo.Size = new System.Drawing.Size(684, 60);
            this.lblEmailInfo.TabIndex = 10;
            this.lblEmailInfo.Text = "Please write the email here with {0} in place of Name. Press Next to preview the " +
    "email with first Name";
            this.lblEmailInfo.Visible = false;
            // 
            // btnNext2
            // 
            this.btnNext2.Location = new System.Drawing.Point(1425, 406);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.Size = new System.Drawing.Size(75, 23);
            this.btnNext2.TabIndex = 7;
            this.btnNext2.Text = "Next";
            this.btnNext2.UseVisualStyleBackColor = true;
            this.btnNext2.Visible = false;
            this.btnNext2.Click += new System.EventHandler(this.btnNext2_Click);
            // 
            // lblPreview
            // 
            this.lblPreview.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreview.Location = new System.Drawing.Point(826, 444);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(674, 290);
            this.lblPreview.TabIndex = 12;
            this.lblPreview.Text = "TEST";
            this.lblPreview.Visible = false;
            // 
            // btnSendEmails
            // 
            this.btnSendEmails.Location = new System.Drawing.Point(830, 737);
            this.btnSendEmails.Name = "btnSendEmails";
            this.btnSendEmails.Size = new System.Drawing.Size(670, 23);
            this.btnSendEmails.TabIndex = 8;
            this.btnSendEmails.Text = "Start Sending Emails";
            this.btnSendEmails.UseVisualStyleBackColor = true;
            this.btnSendEmails.Visible = false;
            this.btnSendEmails.Click += new System.EventHandler(this.btnSendEmails_Click);
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtSubject.Location = new System.Drawing.Point(816, 82);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(684, 26);
            this.txtSubject.TabIndex = 5;
            this.txtSubject.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1549, 772);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.btnSendEmails);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.btnNext2);
            this.Controls.Add(this.lblEmailInfo);
            this.Controls.Add(this.txtEmailTemplate);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblToInfoMessage);
            this.Controls.Add(this.dgvToInfo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFilePath);
            this.Name = "Form1";
            this.Text = "Mail Template Sender";
            ((System.ComponentModel.ISupportInitialize)(this.dgvToInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.DataGridView dgvToInfo;
        private System.Windows.Forms.Label lblToInfoMessage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtEmailTemplate;
        private System.Windows.Forms.Label lblEmailInfo;
        private System.Windows.Forms.Button btnNext2;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Button btnSendEmails;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}

