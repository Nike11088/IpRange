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
    public partial class Navigation : UserControl
    {
        public Navigation()
        {
            InitializeComponent();
            txbxCurrentPage.Text = "0";
            txbxTotalPages.Text = "0";

            btnFirstPage.Click += Btn_Click;
            btnPreviousPage.Click += Btn_Click;
            btnNextPage.Click += Btn_Click;
            btnLastPage.Click += Btn_Click;
            txbxCurrentPage.TextChanged += txbxCurrentPage_TextChanged;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var button = (sender as Button);

            switch (button.Name)
            {
                case "btnFirstPage":
                    FirstPageClick?.Invoke(sender, e);
                    break;
                case "btnPreviousPage":
                    PreviousPageClick?.Invoke(sender, e);
                    break;
                case "btnNextPage":
                    NextPageClick?.Invoke(sender, e);
                    break;
                case "btnLastPage":
                    LastPageClick?.Invoke(sender, e);
                    break;
            }
        }

        private int currentPage = 0;
        public int CurrentPage
        {
            get
            {
                currentPage = int.Parse(txbxCurrentPage.Text);
                return currentPage;
            }

            set
            {
                currentPage = value;
                txbxCurrentPage.Text = currentPage.ToString();
            }
        }

        private int totalPages = 0;
        public int TotalPages
        {
            get
            {
                return totalPages;
            }

            set
            {
                totalPages = value;  
                txbxTotalPages.Text = totalPages.ToString();
            } 
        }
               
        public bool FirstPageEnabled
        {
            get { return btnFirstPage.Enabled; }
            set { btnFirstPage.Enabled = value; }
        }
        public bool PreviousPageEnabled
        {
            get { return btnPreviousPage.Enabled; }
            set { btnPreviousPage.Enabled = value; }
        }
        public bool NextPageEnabled
        {
            get { return btnNextPage.Enabled; }
            set { btnNextPage.Enabled = value; }
        }
        public bool LastPageEnabled
        {
            get { return btnLastPage.Enabled; }
            set { btnLastPage.Enabled = value; }
        }

        public bool CurrentPageReadOnly
        {
            get { return txbxCurrentPage.ReadOnly; }
            set { txbxCurrentPage.ReadOnly = value; }
        }

        public event EventHandler FirstPageClick;
        public event EventHandler PreviousPageClick;
        public event EventHandler NextPageClick;
        public event EventHandler LastPageClick;
        public event EventHandler CurrentPageTextChanged;


        private void txbxCurrentPage_TextChanged(object sender, EventArgs e)
        {
            

            //var number = int.Parse(txbxCurrentPage.Text);

            //if (number == 0 && totalPages > 0)
            //{
            //    (sender as TextBox).Text = "0";
            //}

            //if (number > totalPages)
            //{
            //    (sender as TextBox).Text = totalPages.ToString();
            //}
        }

        private void txbxCurrentPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txbxCurrentPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CurrentPageTextChanged?.Invoke(sender, e);
            }
        }
    }
}
