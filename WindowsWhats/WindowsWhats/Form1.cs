using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppApi;

namespace WindowsWhats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private delegate void UpdateTextBox(TextBox textbox, String value);

        private void UpdateDataTextBox(TextBox textbox, String value)
        {
            textbox.Text = textbox.Text + value;
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            var thread = new Thread(t => {
                UpdateTextBox textbox = UpdateDataTextBox;
                WhatsApp wa = new WhatsApp(txbName.Text, txbPhone.Text, txbPass.Text, true);
                wa.OnConnectSuccess += () =>
                {
                    if (txbStatus.InvokeRequired)
                    {
                        Invoke(textbox, txbStatus,"Connected...");
                    }
                    wa.OnLoginSuccess += (phone, data) =>
                    {

                    };
                };
            });

            thread.Start();
           
        }

        private void mmmm()
        {
            string from = "+261349147482"; //(Enter Your Mobile Number)
            string to = "+261336126166";
            string msg = "";
            WhatsApp wa = new WhatsApp(from, "WhatsAppPassword", "NickName", false, false);
            
            wa.OnConnectSuccess += () =>
            {
                MessageBox.Show("Connected to WhatsApp...");
                wa.OnLoginSuccess += (phonenumber, data) =>
                {
                    wa.SendMessage(to, msg);
                    MessageBox.Show("Message Sent...");
                };
                wa.OnLoginFailed += (data) =>
                {
                    MessageBox.Show("Login Failed : {0} : ", data);
                };

                wa.Login();
            };
            wa.OnConnectFailed += (Exception) =>
            {
                MessageBox.Show("Connection Failed...");
            };
        }

        private void teste()
        {
            //var client = new RestClient("https://www.waboxapp.com/api/send/chat");
            //var request = new RestRequest(Method.POST);
            //request.AddHeader("content-type", "application/x-www-form-urlencoded");
            //request.AddParameter("application/x-www-form-urlencoded", "token=my-test-api-key&uid=12025550123&to=12025550193&custom_uid=msg-5436&text=Hello+world%21", ParameterType.RequestBody);
            //IRestResponse response = client.Execute(request);
        }
    

    }
}
