using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using MailKit.Net.Imap;



namespace mail
{
    public partial class Form2 : Form
    {
        string login;
        string password;
        public Form2(string l, string p)
        {
            InitializeComponent();
            login = l;
            password = p;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MailAddress fromAddress = new MailAddress(login, login);
            MailAddress toAddress = new MailAddress(tot.Text, "somebody");
            MailMessage m = new MailMessage(fromAddress, toAddress);
            m.Body = messageText.Text;
            m.Subject = subjectBox.Text;


            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.yandex.ru";
            smtpClient.Port = 25;
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(fromAddress.Address, "ruugkxhtywogzniv");

            smtpClient.Send(m);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
