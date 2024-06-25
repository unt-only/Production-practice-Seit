using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayNetworkInformation();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
        }
        private void DisplayNetworkInformation()
        {
            label1.Text = ""; 

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    
                    string name = nic.Name;
                    string description = nic.Description;
                    string type = nic.NetworkInterfaceType.ToString();
                    string status = nic.OperationalStatus.ToString();
                    string speed = (nic.Speed / 1_000_000).ToString() + " Mbps"; 
                    string macAddress = nic.GetPhysicalAddress().ToString();

                    
                    string ipAddresses = "";
                    foreach (UnicastIPAddressInformation ip in nic.GetIPProperties().UnicastAddresses)
                    {
                        ipAddresses += ip.Address.ToString() + "\n";
                    }

                    
                    string dnsServers = "";
                    foreach (IPAddress dns in nic.GetIPProperties().DnsAddresses)
                    {
                        dnsServers += dns.ToString() + "\n";
                    }

                    
                    string networkInfo = $"Название: {name}\nОписание: {description}\nТип: {type}\nСтатус: {status}\nСкорость интернета: {speed}\nMac-адресс: {macAddress}\nIp-Адресс: {ipAddresses}\nDNS-сервер: {dnsServers}\n------------------------------------------------\n";

                    
                    label1.Text += networkInfo;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Show();
            label1.Text = ("");
            pictureBox4.Hide();
            pictureBox3.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.Show();
            pictureBox4.Show();
            pictureBox2.Hide();
            Font newFont = new Font("Arial", 14, FontStyle.Bold);
            label2.Font = newFont;
            label2.Text = ("Wi-Fi роутер Xiaomi Router 4A Gigabit Edition*");
            label1.Text = ("Способы приобретения Wi-Fi роутера Xiaomi Router 4A Gigabit Edition: \nПо акции 1р от агента прямых продаж");

        }

        private void button4_Click(object sender, EventArgs e)
        {
             
            SecondForm secondForm = new SecondForm();
            secondForm.Show();
            this.Hide();
        }
    }
}