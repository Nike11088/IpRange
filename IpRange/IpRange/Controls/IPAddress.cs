using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IpRange.Controls
{
    public partial class IPAddress : UserControl
    {
        public IPAddress()
        {
            InitializeComponent();

            txbxIPA.KeyPress += txbxIP_KeyPress;
            txbxIPB.KeyPress += txbxIP_KeyPress;
            txbxIPC.KeyPress += txbxIP_KeyPress;
            txbxIPD.KeyPress += txbxIP_KeyPress;

            txbxIPA.TextChanged += txbxIP_TextChanged;
            txbxIPB.TextChanged += txbxIP_TextChanged;
            txbxIPC.TextChanged += txbxIP_TextChanged;
            txbxIPD.TextChanged += txbxIP_TextChanged;          
        }               
        
        private void txbxIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' )
            {
                e.Handled = true;
            }            
        }

        private void txbxIP_TextChanged(object sender, EventArgs e)
        {
            var txbxIP = (sender as TextBox);
               
            if (txbxIP.Name == "txbxIPA")
            {
                if (TextAChanged != null)
                    TextAChanged(this, new TextEventArgs(txbxIP.Text));
            }

            if (txbxIP.Name == "txbxIPB")
            {
                if (TextBChanged != null)
                    TextBChanged(this, new TextEventArgs(txbxIP.Text));
            }

            int number; 

            if (!int.TryParse(txbxIP.Text, out number))
            {
                txbxIP.Text = "111";
            }

            if (number < 0)
            {
                (sender as TextBox).Text = "0";
                return;
            }

            if (number > 255)
            {
                (sender as TextBox).Text = "255";
                return;
            }                        

            txbxIP.Text = number.ToString();           
        }

        public override string Text
        {
            get { return txbxIPA.Text + "." + txbxIPB.Text + "." + txbxIPC.Text + "." + txbxIPD.Text; }
        }

        public string TextA
        {
            get { return txbxIPA.Text; }
            set { txbxIPA.Text = value; }            
        }

        public string TextB
        {
            get { return txbxIPB.Text; }
            set { txbxIPB.Text = value; }
        }

        public string TextC
        {
            get { return txbxIPC.Text; }
            set { txbxIPC.Text = value; }
        }

        public string TextD
        {
            get { return txbxIPD.Text; }
            set { txbxIPD.Text = value; }
        }

        public bool TextAReadOnly
        {
            get { return txbxIPA.ReadOnly; }
            set { txbxIPA.ReadOnly = value; }
        }

        public bool TextBReadOnly
        {
            get { return txbxIPB.ReadOnly; }
            set { txbxIPB.ReadOnly = value; }
        }

        public bool TextCReadOnly
        {
            get { return txbxIPC.ReadOnly; }
            set { txbxIPC.ReadOnly = value; }
        }

        public bool TextDReadOnly
        {
            get { return txbxIPD.ReadOnly; }
            set { txbxIPD.ReadOnly = value; }
        }

        public delegate void TextStateHandler(object sender, TextEventArgs e);
        public event TextStateHandler TextAChanged;
        public event TextStateHandler TextBChanged;

        public class TextEventArgs
        {
            public string Text
            {
                get; private set;
            }

            public TextEventArgs(string text)
            {
                Text = text;
            }
        }
    }
}
