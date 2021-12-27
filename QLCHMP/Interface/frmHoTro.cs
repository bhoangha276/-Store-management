using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace QLCHMP.Interface
{
    public partial class frmHoTro : Form
    {
        public frmHoTro()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {

                //Sending the email.
                //Now we must create a new Smtp client to send our email.

                SmtpClient client = new SmtpClient("smtp.gmail.com", 25);   //smtp.gmail.com // For Gmail
                                                                            //smtp.live.com // Windows live / Hotmail
                                                                            //smtp.mail.yahoo.com // Yahoo
                                                                            //smtp.aim.com // AIM
                                                                            //my.inbox.com // Inbox


                //Authentication.
                //This is where the valid email account comes into play. You must have a valid email account(with password) to give our program a place to send the mail from.

                NetworkCredential cred = new NetworkCredential("1fast0mail1@gmail.com", "asdfghjkl123456@");

                //To send an email we must first create a new mailMessage(an email) to send.
                MailMessage Msg = new MailMessage();

                // Sender e-mail address.
                Msg.From = new MailAddress(txtTen.Text);//Nothing But Above Credentials or your credentials (*******@gmail.com)

                // Recipient e-mail address.
                Msg.To.Add("alexnguyen123229@gmail.com");

                // Assign the subject of our message.
                Msg.Subject = txtTD.Text;

                // Create the content(body) of our message.
                Msg.Body = txtND.Text;

                // Send our account login details to the client.
                client.Credentials = cred;

                //Enabling SSL(Secure Sockets Layer, encyription) is reqiured by most email providers to send mail
                client.EnableSsl = true;

                //Confirmation After Click the Button
                MessageBox.Show("Succesfully", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                // Send our email.
                client.Send(Msg);



            }
            catch
            {
                // If Mail Doesnt Send Error Mesage Will Be Displayed
                MessageBox.Show("Error", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuiEmail_Click(object sender, EventArgs e)
        {
            try
            {

                //Sending the email.
                //Now we must create a new Smtp client to send our email.

                SmtpClient client = new SmtpClient("smtp.gmail.com", 25);   //smtp.gmail.com // For Gmail
                                                                            //smtp.live.com // Windows live / Hotmail
                                                                            //smtp.mail.yahoo.com // Yahoo
                                                                            //smtp.aim.com // AIM
                                                                            //my.inbox.com // Inbox


                //Authentication.
                //This is where the valid email account comes into play. You must have a valid email account(with password) to give our program a place to send the mail from.

                NetworkCredential cred = new NetworkCredential("1fast0mail1@gmail.com", "asdfghjkl123456@");

                //To send an email we must first create a new mailMessage(an email) to send.
                MailMessage Msg = new MailMessage();

                // Sender e-mail address.
                Msg.From = new MailAddress(txtTen.Text);//Nothing But Above Credentials or your credentials (*******@gmail.com)

                // Recipient e-mail address.
                Msg.To.Add("alexnguyen123229@gmail.com");

                // Assign the subject of our message.
                Msg.Subject = txtTD.Text;

                // Create the content(body) of our message.
                Msg.Body = txtND.Text;

                // Send our account login details to the client.
                client.Credentials = cred;

                //Enabling SSL(Secure Sockets Layer, encyription) is reqiured by most email providers to send mail
                client.EnableSsl = true;

                //Confirmation After Click the Button
                MessageBox.Show("Succesfully", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                // Send our email.
                client.Send(Msg);



            }
            catch
            {
                // If Mail Doesnt Send Error Mesage Will Be Displayed
                MessageBox.Show("Error", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

