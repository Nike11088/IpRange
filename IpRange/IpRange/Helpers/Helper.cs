using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IpRange.Helpers
{
    public static class Helper
    {
        static public Task<List<string>> GetIPAddresses(int currentPage, int recordsPerPage, uint startIPInt, uint endIPInt)
        {
            return Task.Run(() =>
            {
                var IPAddressList = new List<string>();

                uint startIP = (uint)(startIPInt + (currentPage - 1) * recordsPerPage);
                uint endIP;

                ulong longEndIP = startIP + (ulong)recordsPerPage;

                if (longEndIP > endIPInt)
                {
                    endIP = endIPInt;
                }
                else
                {
                    endIP = startIP + (uint)recordsPerPage - 1;
                }

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

                return IPAddressList;
            });
        }

        static public int Compare(System.Net.IPAddress IP1, System.Net.IPAddress IP2)
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
