using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace POS_DDT
{
    public partial class UpdateProduct : UserControl
    {
        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void btnsendmail_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient clientDetails = new SmtpClient();
                clientDetails.Port = Convert.ToInt32(txtPortNo.Text.Trim());
                clientDetails.Host = txtSmptserver.Text.Trim();
                clientDetails.EnableSsl = cbxSSL.Checked;
                clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                clientDetails.UseDefaultCredentials = false;
                clientDetails.Credentials = new NetworkCredential(txtSender.Text.Trim(), txtPassword.Text.Trim());

                MailMessage mailDetails = new MailMessage();
                mailDetails.From = new MailAddress(txtSender.Text.Trim());
                mailDetails.To.Add(txtRecipient.Text.Trim());
                mailDetails.Subject = txtSubject.Text.Trim();
                mailDetails.IsBodyHtml = cbxSSL.Checked;
                mailDetails.Body = txtBody.Text.Trim();

                clientDetails.Send(mailDetails);


                MessageBox.Show("Email Sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
