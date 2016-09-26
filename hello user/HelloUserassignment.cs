using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello_user
{
    public partial class frmHelloUser : Form
    {
        private object lblresult;
        private object lblResult;

        public frmHelloUser()
        {
            InitializeComponent();
        }

        private void btnHelloUser_Click(object sender, EventArgs e)
        {
            lblresult.text= "welcome";
        }

        private void frmHelloUser_Load(object sender, EventArgs e)
        {
            lblresult.text = "welcome";
        }
    }
}
