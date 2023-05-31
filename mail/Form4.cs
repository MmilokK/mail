using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenPop.Mime;
using OpenPop.Pop3;
using OpenPop.Common;
using Message = OpenPop.Mime.Message;

namespace mail
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(Message message)
        {
            InitializeComponent();
            string subject = message.Headers.Subject; //заголовок
            string date = message.Headers.DateSent.ToString(); //Дата/Время
            string from = message.Headers.From.ToString(); //от кого
            string body = "";

            MessagePart mpPlain = message.FindFirstPlainTextVersion();

            if (mpPlain != null)
            {
                Encoding enc = mpPlain.BodyEncoding;
                body = enc.GetString(mpPlain.Body); //получаем текст сообщения
            }

            fromLabel.Text = from;
            dataLabel.Text = date;
            subjectLabel.Text = subject;
            
            bodyBox.Text = body;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
