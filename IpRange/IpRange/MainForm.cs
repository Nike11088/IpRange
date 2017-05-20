using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace IpRange
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            ipAddressEnd.TextA = ipAddressStart.TextA;
            ipAddressEnd.TextB = ipAddressStart.TextB;

            btnShowIPAdresses.Click += (sender, e) =>
            {
                System.Net.IPAddress startIP;
                System.Net.IPAddress endIP;

                if (!System.Net.IPAddress.TryParse(ipAddressStart.Text, out startIP))
                {
                    return;
                }

                if (!System.Net.IPAddress.TryParse(ipAddressEnd.Text, out endIP))
                {
                    return;
                }

                WriteIPAddressesRange(startIP, endIP);
            };

            btnClear.Click += (sender, e) =>
            {
                ltbxIPAddressesRange.DataSource = null;
            };

            ipAddressStart.TextAChanged += (sender, e) =>
            {
                ipAddressEnd.TextA = e.Text;
            };

            ipAddressStart.TextBChanged += (sender, e) =>
            {
                ipAddressEnd.TextB = e.Text;
            };

            ipAddressEnd.TextAReadOnly = true;
            ipAddressEnd.TextBReadOnly = true;
        }        

        public async void WriteIPAddressesRange(System.Net.IPAddress startIP, System.Net.IPAddress endIP)
        {
            if (Compare(startIP, endIP) == 1)
            {
                var tempIp = endIP;
                endIP = startIP;
                startIP = tempIp;
            }

            ltbxIPAddressesRange.DataSource = null;

            var IPAddressesRange = new List<System.Net.IPAddress>();
            var startIPBytesArray = startIP.GetAddressBytes();
            var endIPBytesArray = endIP.GetAddressBytes();

            Array.Reverse(startIPBytesArray);
            Array.Reverse(endIPBytesArray);

            var startIPInt = BitConverter.ToInt32(startIPBytesArray, 0);
            var endIPInt = BitConverter.ToInt32(endIPBytesArray, 0);

            btnShowIPAdresses.Enabled = false;
            btnClear.Enabled = false;

            await AddIPAddressesToList(startIPInt, endIPInt);

            btnShowIPAdresses.Enabled = true;
            btnClear.Enabled = true;
        }

        public Task AddIPAddressesToList(int startIPInt, int endIPInt)
        {
            var IPAddressList = new List<string>();

            return Task.Run(() =>
            {
                for (var i = startIPInt; i <= endIPInt; i++)
                {
                    var IPBytesArray = BitConverter.GetBytes(i);

                    Array.Reverse(IPBytesArray);
                    var IPAddress = new System.Net.IPAddress(IPBytesArray);

                    IPAddressList.Add(IPAddress.ToString());                    
                }

                Action action = () =>
                {
                    ltbxIPAddressesRange.DataSource = IPAddressList;
                };
                this.BeginInvoke(action);
            });
        }

        public int Compare(System.Net.IPAddress IP1, System.Net.IPAddress IP2)
        {
            int returnVal = 0;
            if (IP1.AddressFamily == IP2.AddressFamily)
            {
                byte[] b1 = IP1.GetAddressBytes();
                byte[] b2 = IP2.GetAddressBytes();

                for (int i = 0; i < b1.Length; i++)
                {
                    if (b1[i] < b2[i])
                    {
                        returnVal = -1;
                        break;
                    }
                    else if (b1[i] > b2[i])
                    {
                        returnVal = 1;
                        break;
                    }
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("value",
                      "Cannot compare two addresses no in the same Address Family.");
            }

            return returnVal;
        }
    }
}
