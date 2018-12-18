using ExcelDataReader;
using Microsoft.Exchange.WebServices.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace O365EmailSender
{
    public class ExcelFileHandler
    {
        public string FilePath { get; set; }
        public List<User> Users { get; set; }
        public string[] Attachments{ get; set; }
        public List<User> ReadUsers()
        {
            Users = new List<User>();


            FileInfo file = new FileInfo(this.FilePath);
            FileStream stream = File.Open(this.FilePath, FileMode.Open, FileAccess.Read);

            IExcelDataReader excelReader;
            if (file.Extension.Equals(".xls"))
            {
                excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
            }
            else
            {
                excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            }

            var conf = new ExcelDataSetConfiguration
            {
                ConfigureDataTable = _ => new ExcelDataTableConfiguration
                {
                    UseHeaderRow = true
                }
            };

            var _allFileData = excelReader.AsDataSet(conf);

            var rows = _allFileData.Tables[0].Rows.Cast<DataRow>();
            bool hasCompany = _allFileData.Tables[0].Columns.Count > 2;

            foreach (var row in rows)
            {
                Users.Add(new User()
                {
                    Name = row[0].ToString(),
                    Email = row[1].ToString(),
                    Company = hasCompany ? row[2].ToString() : string.Empty
                });
            }

            return Users;
        }

        public void SendEmails(string subject, string message, string userName, string password)
        {
            var service = new ExchangeService(ExchangeVersion.Exchange2013);
            service.Credentials =
                new WebCredentials(userName, password);
            service.TraceEnabled = true;
            service.TraceFlags = TraceFlags.All;
            service.AutodiscoverUrl(userName, RedirectionUrlValidationCallback);

            foreach (User user in this.Users)
            {
                EmailMessage email = new EmailMessage(service);

                email.Subject = subject;

                email.Body = new MessageBody(string.Format(message, user.Name, user.Company));
                email.Body.BodyType = BodyType.Text;

                if (this.Attachments != null && this.Attachments.Length > 0)
                {
                    foreach (string att in this.Attachments)
                    {
                        email.Attachments.AddFileAttachment(att);
                    }
                }
                
                email.ToRecipients.Add(user.Email);

                email.SendAndSaveCopy();
            }
        }

        private static bool RedirectionUrlValidationCallback(string redirectionUrl)
        {
            var redirectionUri = new Uri(redirectionUrl);
            var result = redirectionUri.Scheme == "https";
            return result;
        }
    }
}
