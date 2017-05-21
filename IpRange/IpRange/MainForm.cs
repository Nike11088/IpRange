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
              
            EnableNavigation(false);

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
                _currentPage = 0;
                _totalPages = 0;
                navigation.CurrentPage = _currentPage;
                navigation.TotalPages = _totalPages;

                EnableNavigation(false);
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
                await ShowIPAddresses(_currentPage, _startIPInt, _endIPInt);
            };

            navigation.PreviousPageClick += async (sender, e) =>
            {
                if (_currentPage == 1)
                {
                    return;
                }

                navigation.CurrentPage = --_currentPage;
                await ShowIPAddresses(_currentPage, _startIPInt, _endIPInt);
            };

            navigation.LastPageClick += async (sender, e) =>
            {
                _currentPage = _totalPages;                                
                navigation.CurrentPage = _currentPage;

                await ShowIPAddresses(_currentPage, _startIPInt, _endIPInt);
            };

            navigation.FirstPageClick += async (sender, e) =>
            {
                _currentPage = 1;
                navigation.CurrentPage = _currentPage;

                await ShowIPAddresses(_currentPage, _startIPInt, _endIPInt);
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

                await ShowIPAddresses(_currentPage, _startIPInt, _endIPInt);
            };                        
        }

        uint _startIPInt;
        uint _endIPInt;
        int _totalPages;
        int _currentPage;
        const int recordsPerPage = 1000;

        public void EnableNavigation(bool enabled)
        {
            navigation.FirstPageEnabled = enabled;
            navigation.PreviousPageEnabled = enabled;
            navigation.NextPageEnabled = enabled;
            navigation.LastPageEnabled = enabled;
            navigation.CurrentPageReadOnly = !enabled;
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

            _startIPInt = BitConverter.ToUInt32(startIPBytesArray, 0);
            _endIPInt = BitConverter.ToUInt32(endIPBytesArray, 0);

            double pagesCount = ((double)_endIPInt + 1) / (double)recordsPerPage;
            _totalPages = (int)(Math.Ceiling(pagesCount));

            _currentPage = _totalPages > 0 ? 1 : 0;

            if (_totalPages > 1)
            {
                EnableNavigation(true);
            }

            Action action = () =>
            {
                navigation.CurrentPage = _currentPage;
                navigation.TotalPages = _totalPages;
            };
            this.BeginInvoke(action);

            btnShowIPAdresses.Enabled = false;
            btnClear.Enabled = false;

            await ShowIPAddresses(_currentPage, _startIPInt, _endIPInt);

            btnShowIPAdresses.Enabled = true;
            btnClear.Enabled = true;
        }
         
        public Task ShowIPAddresses(int currentPage, uint startIPInt, uint endIPInt)
        {  
            return Task.Run(() =>
            {
                var IPAddressList = new List<string>();

                uint startIP = (uint)(startIPInt + (currentPage - 1) * recordsPerPage); 
                uint endIP;

                ulong longEndIP = (ulong)startIP + (ulong)recordsPerPage;

                //if (longEndIP > (ulong)uint.MaxValue)
                //{
                //    endIP = uint.MaxValue;
                //}
                if (longEndIP > (ulong)endIPInt)
                {
                    endIP = endIPInt;
                }
                else
                {
                    endIP = startIP + recordsPerPage - 1;
                }

                //if (endIP > endIPInt)
                //{
                //    endIP = endIPInt;
                //}

                for (var i = startIP; i <= endIP; i++)
                {                    
                    var IPBytesArray = BitConverter.GetBytes(i);

                    Array.Reverse(IPBytesArray);
                    var IPAddress = new System.Net.IPAddress(IPBytesArray);

                    IPAddressList.Add(IPAddress.ToString());

                    if (i == uint.MaxValue)
                    {
                        break;
                    }
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
