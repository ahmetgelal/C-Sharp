using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Send_Email
{
    public partial class FordMail : Form
    {
        public FordMail()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            String fromName = nameText.Text;
            String fromMail = fromMailText.Text;

            String toName = toMailText.Text;
            String toMail = toMailText.Text;
            String subject = subjectText.Text;
            String mailIcerik = icerikText.Text;

            String password = passwordText.Text;

            if (fromName != "" && fromMail != "" && toName != "" && toMail != "" && subject != "" && mailIcerik != "" && password!="")
            {
                emailSendOperation.sendEmail(fromName, fromMail, toName, toMail, subject, mailIcerik, password);
            }
            else
            {


            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }


    public class emailSendOperation
    {
        // Bu program Ahmet Gelal tarafindan yapilmistir... Her hakki mahfuzdur.

        public static void sendEmail(String fromName, String fromMail, String toName, String toMail, String subject, String mailIcerik, String password)
        {


            MailMessage mail = new MailMessage();

            mail.From = new MailAddress(fromMail, fromName);
            mail.To.Add(new MailAddress(toMail, toName));

            mail.Subject = subject;
            mail.Body = mailIcerik;
            mail.IsBodyHtml = true;

            SmtpClient client = new SmtpClient("smtp.kiralahepsini.com", 587);
            client.Credentials = new System.Net.NetworkCredential(fromMail, password);
            client.EnableSsl = false;
            client.Send(mail);


        }



    }
}
