using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Year_14_CA_SSD
{
    public partial class CustomerDataForm : Form
    {
        public event EventHandler AddCustomer;
        public CustomerDataForm()
        {
            InitializeComponent();
        }
        private void CustomerDataForm_Load(object sender, EventArgs e)
        {

        }
        private void ListViewCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Search_Button_Click(object sender, EventArgs e)
        {

        }
        private void Refresh_Button_Click(object sender, EventArgs e)
        {

        }
        private void Update_Customer_Button_Click(object sender, EventArgs e)
        {

        }
        private void Remove_Customer_Button_Click(object sender, EventArgs e)
        {

        }
        private void Add_Customer_Button_Click(object sender, EventArgs e)
        {

        }
    }
    public class Add_Customer_EventArgs : EventArgs
    {
        public int Id;
        public bool AddMode;
    }

}
