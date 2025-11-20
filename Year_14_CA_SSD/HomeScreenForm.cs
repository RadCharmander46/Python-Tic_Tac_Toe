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
    public partial class HomeScreenForm : Form
    {
        public event EventHandler SignIn;
        public HomeScreenForm()
        {
            InitializeComponent();
        }

        private void HomeScreenForm_Load(object sender, EventArgs e)
        {
            if(!Globals.signedIn)
            {
                Signed_In_Label.Visible = true;
                Sign_In_Button.Visible = true;
            }
            else
            {
                Signed_In_Label.Visible = false;
                Sign_In_Button.Visible = false;

            }
        }

        private void Sign_In_Button_Click(object sender, EventArgs e)
        {
            if(SignIn != null)
            {
                SignIn.Invoke(this, EventArgs.Empty);
            }
            this.Close();
        }
    }
}
