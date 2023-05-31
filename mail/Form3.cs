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
    public partial class Form3 : Form
    {
        string login, password;
        
        int messageCount;
        public Form3()
        {
            InitializeComponent();
            Messages.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        public Form3(string l, string p)
        {
            InitializeComponent();
            login = l;
            password = p;
            using (OpenPop.Pop3.Pop3Client client = new Pop3Client())
            {
                client.Connect("pop.yandex.ru", 995, true);
                client.Authenticate(login, password, OpenPop.Pop3.AuthenticationMethod.UsernameAndPassword);
                if (client.Connected)
                {
                    messageCount = client.GetMessageCount();
                    allMessages = new List<Message>(messageCount);
                    for (int i = messageCount; i > 0; i--)
                    {
                        allMessages.Add(client.GetMessage(i));
                        Message message = client.GetMessage(i);

                        


                    }


                }
                allMessages.Sort(delegate (Message x, Message y)
                {
                    return y.Headers.DateSent.CompareTo(x.Headers.DateSent);
                });
                foreach(var mes in allMessages)
                {
                    Receive(mes);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        List<Message> allMessages;

        private void Messages_CellMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            Messages.Rows[e.RowIndex].Selected = true;
            Form4 form4 = new Form4(allMessages[e.RowIndex]);
            this.Hide();
            form4.ShowDialog();
            this.Show();


        }

        private void DayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Messages.Rows.Clear();
            foreach (var message in allMessages)
            {
                if (message.Headers.DateSent.ToString("d") == DateTime.Today.ToString("d"))
                {
                    Receive(message);
                }
                else break;
            }
        }

        private void WeekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Messages.Rows.Clear();
            foreach (var message in allMessages)
            {
                if (message.Headers.DateSent >= DateTime.Today.AddDays(-7))
                {
                    Receive(message);
                }
                else break;
            }
        }

        private void YearRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Messages.Rows.Clear();
            foreach (var message in allMessages)
            {
                if (message.Headers.DateSent >= DateTime.Today.AddYears(-1))
                {
                    Receive(message);
                }
                else break;
            }
        }

        private void AllTimeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Messages.Rows.Clear();
            foreach (var message in allMessages)
            {
                    Receive(message);
            }
        }

        private void Receive(Message message)
        {
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

            DataGridViewRow row = new DataGridViewRow();
            DataGridViewCell datacell = new DataGridViewTextBoxCell();
            DataGridViewCell subjectcell = new DataGridViewTextBoxCell();
            DataGridViewCell bodycell = new DataGridViewTextBoxCell();
            DataGridViewCell fromcell = new DataGridViewTextBoxCell();
            datacell.Value = date;
            subjectcell.Value = subject;
            bodycell.Value = body;
            fromcell.Value = from;
            row.Cells.AddRange(fromcell, datacell, subjectcell, bodycell);
            Messages.Rows.Add(row);
        }
    }
}
