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
using IpRange.Helpers;
using System.IO;
using System.Diagnostics;

namespace IpRange
{
    public partial class MainForm : Form
    {
        uint _startIP;
        uint _endIP;
        int _totalPages;
        int _currentPage;
        const int _recordsPerPage = 1000;
            
        public MainForm()
        {
            InitializeComponent();
              
            EnableNavigation(false);

            btnUnload.Enabled = false;

            btnShowIPAdresses.Click += async (sender, e) =>
            {
                System.Net.IPAddress startIP = System.Net.IPAddress.Parse(ipAddressStart.Text);
                System.Net.IPAddress endIP = System.Net.IPAddress.Parse(ipAddressEnd.Text);

                Initial(startIP, endIP);
                ltbxIPAddressesRange.DataSource = await Helper.GetIPAddresses(_currentPage, _recordsPerPage, _startIP, _endIP);

                btnUnload.Enabled = true;
                toolStripBtnOpenFile.Visible = false;
            };

            btnClear.Click += (sender, e) =>
            {
                ltbxIPAddressesRange.DataSource = null;              
                navigation.CurrentPage = _currentPage = 0;
                navigation.TotalPages = _totalPages = 0;

                EnableNavigation(false);
                btnUnload.Enabled = false;
                toolStripBtnOpenFile.Visible = false;
            };

            CancellationTokenSource token = new CancellationTokenSource();

            string _fileName = string.Empty;
            btnUnload.Click += async (sender, e) =>
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog()
                {
                    Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*",
                    FileName = "ip_addresses_range"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                _fileName = saveFileDialog.FileName;

                panelControls.Enabled = false;
                toolStripProgress.Visible = true;
                toolStripBtnStop.Visible = true;
                toolStripProgress.Maximum = _totalPages;

                await UnloadIPAddresses(_fileName, token);                             
            };

            toolStripBtnOpenFile.Click += (sender, e) =>
            {
                Process.Start(_fileName);
            };

            toolStripBtnStop.Click += (sender, e) =>
            {
                token.Cancel();             
            };

            ipAddressStart.TextAChanged += (sender, e) =>
            {
                ipAddressEnd.TextA = e.Text;
            };

            ipAddressStart.TextBChanged += (sender, e) =>
            {
                ipAddressEnd.TextB = e.Text;
            };

            navigation.NextPageClick += async (sender, e) =>
            {           
                if (_currentPage == _totalPages)
                {
                    return;
                }   
                      
                navigation.CurrentPage = ++_currentPage;
                ltbxIPAddressesRange.DataSource = await Helper.GetIPAddresses(_currentPage, _recordsPerPage, _startIP, _endIP);
            };

            navigation.PreviousPageClick += async (sender, e) =>
            {
                if (_currentPage == 1)
                {
                    return;
                }

                navigation.CurrentPage = --_currentPage;
                ltbxIPAddressesRange.DataSource = await Helper.GetIPAddresses(_currentPage, _recordsPerPage, _startIP, _endIP);
            };

            navigation.LastPageClick += async (sender, e) =>
            {
                _currentPage = _totalPages;                                
                navigation.CurrentPage = _currentPage;

                ltbxIPAddressesRange.DataSource = await Helper.GetIPAddresses(_currentPage, _recordsPerPage, _startIP, _endIP);
            };

            navigation.FirstPageClick += async (sender, e) =>
            {
                _currentPage = 1;
                navigation.CurrentPage = _currentPage;

                ltbxIPAddressesRange.DataSource = await Helper.GetIPAddresses(_currentPage, _recordsPerPage, _startIP, _endIP);
            };

            navigation.CurrentPageTextChanged += async (sender, e) =>
            {
                _currentPage = navigation.CurrentPage;

                if (_currentPage == 0 && _totalPages > 0)
                {
                    _currentPage = 1;
                    navigation.CurrentPage = 1;
                }

                if (_currentPage > _totalPages)
                {
                    _currentPage = _totalPages;
                    navigation.CurrentPage = _currentPage;
                }

                ltbxIPAddressesRange.DataSource = await Helper.GetIPAddresses(_currentPage, _recordsPerPage, _startIP, _endIP);
            };                        
        }        

        public void EnableNavigation(bool enabled)
        {
            navigation.FirstPageEnabled = enabled;
            navigation.PreviousPageEnabled = enabled;
            navigation.NextPageEnabled = enabled;
            navigation.LastPageEnabled = enabled;
            navigation.CurrentPageReadOnly = !enabled;
        }

        public async Task UnloadIPAddresses(string fileName, CancellationTokenSource token)
        {
            using (FileStream fstream = new FileStream(fileName, FileMode.Truncate))
            {
                for (var i = 1; i <= _totalPages; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        panelControls.Enabled = true;
                        toolStripProgress.Visible = false;
                        toolStripBtnStop.Visible = false;
                        toolStripBtnOpenFile.Visible = true;
                        fstream.Close();
                        return;
                    }

                    var IPAddresses = await Helper.GetIPAddresses(i, _recordsPerPage, _startIP, _endIP);

                    StringBuilder sb = new StringBuilder();
                    foreach (var IPAddress in IPAddresses)
                    {
                        sb.Append(IPAddress + "\n");
                    }
                    byte[] array = Encoding.Default.GetBytes(sb.ToString());
                    fstream.Write(array, 0, array.Length);

                    toolStripProgress.Value = i;
                }
            }

            panelControls.Enabled = true;
            toolStripProgress.Visible = false;
            toolStripBtnStop.Visible = false;
            toolStripBtnOpenFile.Visible = true;
        }

        public void Initial(System.Net.IPAddress startIP, System.Net.IPAddress endIP)
        {
            if (Helper.Compare(startIP, endIP) == 1)
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

            _startIP = BitConverter.ToUInt32(startIPBytesArray, 0);
            _endIP = BitConverter.ToUInt32(endIPBytesArray, 0);

            double pagesCount = ((double)_endIP + 1) / (double)_recordsPerPage;
            _totalPages = (int)(Math.Ceiling(pagesCount));

            _currentPage = _totalPages > 0 ? 1 : 0;

            if (_totalPages > 1)
            {
                EnableNavigation(true);
            }
            
            navigation.CurrentPage = _currentPage;
            navigation.TotalPages = _totalPages;            
        }  
    }
}
